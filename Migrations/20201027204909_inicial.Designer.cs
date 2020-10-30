﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc001;

namespace mvc001.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20201027204909_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mvc001.Models.Cadastro", b =>
                {
                    b.Property<int>("CadastroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CadastroId");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("mvc001.Models.Insumo", b =>
                {
                    b.Property<int>("InsumoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColherCha")
                        .HasColumnType("int");

                    b.Property<int>("ColherSopa")
                        .HasColumnType("int");

                    b.Property<int>("Gramas")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Xicara")
                        .HasColumnType("int");

                    b.HasKey("InsumoId");

                    b.ToTable("Insumo");
                });

            modelBuilder.Entity("mvc001.Models.ItemReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InsumoId1")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("ReceitaId1")
                        .HasColumnType("int");

                    b.Property<bool>("um2Meio")
                        .HasColumnType("bit");

                    b.Property<bool>("um4Quarto")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId1");

                    b.HasIndex("ReceitaId1");

                    b.ToTable("ItemReceita");
                });

            modelBuilder.Entity("mvc001.Models.Receita", b =>
                {
                    b.Property<int>("ReceitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CadastroId1")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ReceitaId");

                    b.HasIndex("CadastroId1");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("mvc001.Models.ItemReceita", b =>
                {
                    b.HasOne("mvc001.Models.Insumo", "InsumoId")
                        .WithMany()
                        .HasForeignKey("InsumoId1");

                    b.HasOne("mvc001.Models.Receita", "ReceitaId")
                        .WithMany("Itens")
                        .HasForeignKey("ReceitaId1");
                });

            modelBuilder.Entity("mvc001.Models.Receita", b =>
                {
                    b.HasOne("mvc001.Models.Cadastro", "CadastroId")
                        .WithMany()
                        .HasForeignKey("CadastroId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
