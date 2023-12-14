using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class Marca
    {
                public int id{get;set;}
        public string nome {get; set;}
        public string descricao {get; set;}
        public ICollection<Produto> produtos{get;set;}
    }
}