using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class Transportadora
    {
                public int id{get;set;}
        public string nome{get;set;}
        public ICollection<NotaDeVenda> notaDeVendas{get;set;}
    }
}