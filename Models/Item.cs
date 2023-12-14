using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class Item
    {
                public int id{get;set;}
        public double preco{get;set;}
        public int percentual{get;set;}
        public int quantidade{get;set;}
        public Produto produto{get;set;}
        public NotaDeVenda notaDeVenda{get;set;}
    }
}