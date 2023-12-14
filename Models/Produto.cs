using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class Produto
    {
                public int id{get;set;}
        public string nome {get; set;}
        public string descricao {get; set;}
        public int quantidade {get; set;}
        public double preco{get; set;}
        public Marca marca{get;set;}
        public ICollection<Item> itens{get;set;}
    }
}