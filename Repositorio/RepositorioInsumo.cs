using Microsoft.EntityFrameworkCore;
using mvc001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc001.Repositorio
{
    public class RepositorioInsumo : RepositorioBase<Insumo>, IRepositorioInsumo
    {
        public RepositorioInsumo(AppContext contexto) : base(contexto)
        {

        }

        public IList<Insumo> GetInsumos()
        {
            return contexto.Set<Insumo>().ToList();
        }
        public IList<Categoria> GetCategorias()
        {
            return contexto.Set<Categoria>().ToList();
        }

        public void SalvaInsumos(List<ImportInsumo> listaConv)
        {
            foreach (var item in listaConv)
            {
                if (!dbSet.Where(p => p.Codigo == item.Codigo).Any())
                {
                    dbSet.Add(new Insumo(item.Codigo,
                                         item.Nome,
                                         item.xicara,
                                         item.gramas,
                                         item.colherSopa,
                                         item.colherCha));
                }
            }
            contexto.SaveChanges();
        }
        public void SalvaCategoria(List<ImportCategoria> listaConv)
        {
            foreach (var item in listaConv)
            {
                if (!contexto.Set<Categoria>().Where(p => p.Codigo == item.Codigo).Any())
                {
                    contexto.Set<Categoria>().Add(new Categoria(item.Codigo,
                                                                item.Nome));

                    contexto.SaveChanges();
                }
            }
        }
    }
    public class ImportInsumo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int xicara { get; set; }
        public int gramas { get; set; }
        public int colherSopa { get; set; }
        public int colherCha { get; set; }
    }
    public class ImportCategoria
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }
}
