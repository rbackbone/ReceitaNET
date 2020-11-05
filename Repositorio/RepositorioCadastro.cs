using mvc001.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc001.Repositorio
{
    public interface IRepositorioCadastro
    { }
    public class RepositorioCadastro : RepositorioBase<Cadastro>, IRepositorioCadastro
    {
        public RepositorioCadastro(AppContext contexto) : base(contexto)
        {
        }

        public IList<Cadastro> GetReceitas()
        {
            return contexto.Set<Cadastro>().ToList();
        }
    }
}
