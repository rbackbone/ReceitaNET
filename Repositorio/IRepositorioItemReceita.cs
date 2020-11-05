using mvc001.Models;
using System.Collections.Generic;

namespace mvc001.Repositorio
{
    public interface IRepositorioItemReceita
    {
        AlteraQuantidadeResposta AlteraQuantidade(ItemReceita itemReceita);
        void RemoveItemReceita(int insumoId, int receitaId);
        ItemReceita GetItemReceita(int insumoId, int receitaId);
        public List<ItemReceita> GetItensReceita(int receitaId);
    }
}
