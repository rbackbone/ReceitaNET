using System.Collections.Generic;
using System.Linq;

namespace mvc001.Models
{
    public class ReceitaViewModel
    {
        public ReceitaViewModel(IList<ItemReceita> itens)
        {
            Itens = itens;
        }

        public IList<ItemReceita> Itens { get; }

        public decimal Total => Itens.Sum(i => i.Quantidade);
    }
}
