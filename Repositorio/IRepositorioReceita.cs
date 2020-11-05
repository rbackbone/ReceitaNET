using mvc001.Models;
using System.Collections.Generic;

namespace mvc001.Repositorio
{
    public interface IRepositorioReceita
    {
        IList<Receita> GetReceitas();

        Receita GetReceita(int receitaId);
        void AddInsumo(string codigo);
    }
}
