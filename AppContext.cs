using Microsoft.EntityFrameworkCore;
using mvc001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            // 
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

            //modelBuilder
            //    .Entity<Receita>()
            //    .HasOne(t => t.CadastroId)
            //    .WithOne(t => t.);
            //  .IsRequired()
            //  .HasForeignKey<Cadastro>(b => b.ReceitaId);

            modelBuilder
                .Entity<ItemReceita>()
                .HasKey(pp => new { pp.InsumoId, pp.ReceitaId });



            //modelBuilder
            //    .Entity<ItemReceita>().HasOne(t => t.ReceitaId);
            //modelBuilder
            //    .Entity<ItemReceita>().HasOne(t => t.InsumoId);

            modelBuilder
                .Entity<Cadastro>().HasKey(pp => pp.Id);

            //modelBuilder
            //    .Entity<Cadastro>().HasOne(t => t.ReceitaId);


            base.OnModelCreating(modelBuilder);
        }


    }
}