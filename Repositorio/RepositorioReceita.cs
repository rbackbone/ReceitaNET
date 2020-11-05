using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using mvc001.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc001.Repositorio
{


    public class RepositorioReceita : RepositorioBase<Receita>, IRepositorioReceita
    {
        private readonly IHttpContextAccessor contextAccessor;

        public RepositorioReceita(AppContext contexto,
                                  IHttpContextAccessor _contextAccessor) : base(contexto)
        {
            this.contextAccessor = _contextAccessor;
        }

        public void AddInsumo(string codigo)
        {

            var insumo = contexto.Set<Insumo>()
                          .Where(p => p.Codigo == codigo)
                          .SingleOrDefault();

            if (insumo == null)
            {
                //throw new ArgumentException("Insumo não encontrada");
                return;
            }

            var receita = GetReceita();
            var itemReceita = contexto.Set<ItemReceita>()
                             .Where(i => i.Insumo.Codigo == codigo
                                       && i.ReceitaId == receita.ReceitaId)
                             .SingleOrDefault();
            if (itemReceita == null)
            {
                itemReceita = new ItemReceita(receita, insumo, 1);
                
                contexto.Set<ItemReceita>()
                    .Add(itemReceita);
                contexto.SaveChanges();
            }


        }

        public Receita GetReceita(int receitaId)
        {
            Receita receita;
            if (receitaId == 0)
            {
                receita = GetReceita();
            }
            else
            {
                receita = ConsultaReceita(receitaId);
                GravaReceita(receita);
            }            
            return receita;

        }
        public Receita GetReceita()
        {
            Receita receita;
            var receitaId = GetReceitaId();
            int intRec = 0;

            if (receitaId != null)
            { 
                intRec = (int)receitaId;
                receita = ConsultaReceita(intRec);
            }
            else
            {
                receita = new Receita("R001", "Torta Scaffould");
                dbSet.Add(receita);
                GravaReceita(receita);
            }
            
            return receita;
        }

        private Receita ConsultaReceita(int receitaId)
        {
            var receita = dbSet
                        .Include(p => p.Itens)
                        .ThenInclude(i => i.Insumo)
                        .Where(p => p.ReceitaId == receitaId).SingleOrDefault();

            return receita;
        }

        private void GravaReceita (Receita receita)
        {
            contexto.SaveChanges();
            SetReceitaId(receita.ReceitaId);

        }

        public IList<Receita> GetReceitas()
        {
            return contexto.Set<Receita>().ToList();
        }

        private int? GetReceitaId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("receitaId");
        }

        private void SetReceitaId(int receitaId)
        {
            contextAccessor.HttpContext.Session.SetInt32("receitaId",receitaId);
        }


    }
}
