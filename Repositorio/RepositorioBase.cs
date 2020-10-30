using Microsoft.EntityFrameworkCore;
using mvc001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc001.Repositorio
{
    public class RepositorioBase<T> where T : BaseModel
    {
        // ---- como protected deixo visivel para as classes derivadas
        protected readonly DbSet<T> dbSet;
        protected readonly AppContext contexto;

        public RepositorioBase(AppContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
