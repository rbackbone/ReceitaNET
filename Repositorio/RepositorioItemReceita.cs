using mvc001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc001.Repositorio
{

    public class RepositorioItemReceita : RepositorioBase<ItemReceita>, IRepositorioItemReceita
    {
        public RepositorioItemReceita(AppContext contexto) : base(contexto)
        {
        }

        public List<ItemReceita> GetItensReceita(int receitaId)
        {
            return dbSet
                .Where(p => p.ReceitaId == receitaId)
                .ToList();
        }
        public AlteraQuantidadeResposta AlteraQuantidade(ItemReceita itemReceita)
        {
            var item = dbSet
                .Where(p => p.InsumoId == itemReceita.InsumoId
                         && p.ReceitaId == itemReceita.ReceitaId)
                .SingleOrDefault();

            if (item != null)
            {
                item.AlteraQuantidade(itemReceita.Quantidade);

                if (itemReceita.Quantidade == 0)
                {
                    RemoveItemReceita(itemReceita.InsumoId, itemReceita.ReceitaId );
                }

                contexto.SaveChanges();

                return new AlteraQuantidadeResposta(item);
            }

            throw new ArgumentException("Item da Receita não encontrado.");
        }

        public ItemReceita GetItemReceita(int insumoId, int receitaId)
        {
            return
                dbSet
                .Where(p => p.InsumoId == insumoId
                         && p.ReceitaId == receitaId)
                .SingleOrDefault();
        }       

        public IList<ItemReceita> GetReceitas()
        {
            return contexto.Set<ItemReceita>().ToList();
        }

        public void RemoveItemReceita(int insumoId, int receitaId)
        {
            dbSet.Remove(GetItemReceita(insumoId, receitaId));
        }
    }
}
