using mvc001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
