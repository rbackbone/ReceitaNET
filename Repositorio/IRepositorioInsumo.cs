using mvc001.Models;
using System.Collections.Generic;

namespace mvc001.Repositorio
{
    public interface IRepositorioInsumo
    {
        void SalvaInsumos(List<ImportInsumo> listaConv);
        IList<Insumo> GetInsumos();
        void SalvaCategoria(List<ImportCategoria> listaConv);
        IList<Categoria> GetCategorias();        
    }
}