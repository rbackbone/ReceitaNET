using Microsoft.EntityFrameworkCore;
using mvc001.Models;

namespace mvc001
{
    public class AppContext : DbContext
    {
        public DbSet<Insumo> Insumo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public AppContext(DbContextOptions options) : base(options)
        {
        }
        public AppContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Categoria>()
                .HasKey(pp => pp.Id);

            modelBuilder
                .Entity<Insumo>()
                .HasKey(pp => pp.InsumoId);

            modelBuilder
                .Entity<Receita>()
                .HasKey(pp => pp.ReceitaId);

            modelBuilder
                .Entity<Receita>()
                .HasMany(t => t.Itens)
                .WithOne(t => t.Receita);

            modelBuilder
                .Entity<ItemReceita>()
                .HasKey(pp => new { pp.InsumoId, pp.ReceitaId });

            modelBuilder
                .Entity<Cadastro>().HasKey(pp => pp.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}