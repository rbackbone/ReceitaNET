using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace mvc001.Models
{
    [DataContract]
    public class BaseModel
    {
        //[DataMember]
    }


    public class Categoria : BaseModel
    {
        public Categoria()
        { }

        public Categoria(string codigo,string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        [Required]
        public int Id { get; private set; }
        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        
    }
    public class Insumo : BaseModel
    {
        public Insumo()
        {

        }

        [Key]
        public int InsumoId { get; set; }
        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public int Xicara { get; private set; }
        [Required]
        public int Gramas { get; private set; }
        [Required]
        public int ColherSopa { get; private set; }
        [Required]
        public int ColherCha { get; private set; }


        public Insumo(string codigo, string nome, int xicara, int gramas, int colherSopa, int colherCha)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Xicara = xicara;
            this.Gramas = gramas;
            this.ColherSopa = colherSopa;
            this.ColherCha = colherCha;
        }
    }

    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        [Required]
        public int Id { get; private set; }
        [Required]
        public string Nome { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Telefone { get; set; } = "";
        [Required]
        public string Endereco { get; set; } = "";
        [Required]
        public string Complemento { get; set; } = "";
        [Required]
        public string Bairro { get; set; } = "";
        [Required]
        public string Municipio { get; set; } = "";
        [Required]
        public string UF { get; set; } = "";
        [Required]
        public string CEP { get; set; } = "";
    }

    [DataContract]
    public class ItemReceita : BaseModel
    {
        [Required]
        [DataMember]
        public int InsumoId { get; private set; }
        [Required]
        [DataMember]
        public int ReceitaId { get; private set; }
        [Required]
        [DataMember]
        public int Quantidade { get; private set; }
        [DataMember]
        public Receita Receita { get; private set; }
        //[Required]
        [DataMember]
        public Insumo Insumo { get; private set; }
        //[Required]
        public bool um2Meio { get; private set; }
        //[Required]
        public bool um4Quarto { get; private set; }


        public ItemReceita()
        {

        }

        public ItemReceita(Receita receita, Insumo insumo, int quantidade)
        {
            Receita = receita;
            Insumo = insumo;
            Quantidade = quantidade;
        }

        public void AlteraQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
    }

    public class Receita : BaseModel
    {
        public Receita()
        {
            //Cadastro = new Cadastro();
        }

        public Receita(string _codigo, string _titulo)
        {
            Codigo = _codigo;
            Titulo = _titulo;
        }

        [Key]
        public int ReceitaId { get; set; }
        [Required]
        public string Titulo { get; private set; }
        [Required]
        public string Codigo { get; private set; }
        public string Preparo { get; private set; }
        public Categoria Categoria { get; private set; }
        public List<ItemReceita> Itens { get;  set; } = new List<ItemReceita>();
        public virtual Cadastro Cadastro { get; private set; }
    }



}
