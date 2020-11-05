using Microsoft.EntityFrameworkCore;
using mvc001.Repositorio;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace mvc001
{
    public partial class Startup
    {
        class DataService : IDataService
        {

            private readonly AppContext contexto;
            private readonly IRepositorioInsumo repositorioInsumo;

            // geração do contexto através de injeção de dependência
            public DataService(AppContext contexto, 
                               IRepositorioInsumo repositorioInsumo )
            {
                this.contexto = contexto;
                this.repositorioInsumo = repositorioInsumo;
            }

            public void InicializaDB()
            {
                // ---- gera o banco de dados caso não exista

                contexto.Database.Migrate();

                // ---- atenção para a linha acima : 
                //            O Método EnsureCreated se executado, ao invés do Migrate
                //            não irá mais permitir migrações


                List<ImportInsumo> listaInsumos = GetInsumos();
                repositorioInsumo.SalvaInsumos(listaInsumos);

                List<ImportCategoria> listaCateg = GetCategoria();
                repositorioInsumo.SalvaCategoria(listaCateg);
            }


            static List<ImportInsumo> GetInsumos()
            {
                var listaConv = new List<ImportInsumo>();

                var contactsJson = File.ReadAllText("insumos.json");

                if (contactsJson != "")
                {
                    listaConv = JsonConvert.DeserializeObject<List<ImportInsumo>>(contactsJson);
                }

                return listaConv;
            }
            static List<ImportCategoria> GetCategoria()
            {
                var listaConv = new List<ImportCategoria>();

                var contactsJson = File.ReadAllText("categorias.json");

                if (contactsJson != "")
                {
                    listaConv = JsonConvert.DeserializeObject<List<ImportCategoria>>(contactsJson);
                }

                return listaConv;
            }
        }

    }



}
