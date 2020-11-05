
namespace mvc001.Models
{
    public class AlteraQuantidadeResposta
    {
        public AlteraQuantidadeResposta(ItemReceita itemReceita)
        {
            this.itemReceita = itemReceita;
        }

        public ItemReceita itemReceita { get; }
    }
}
