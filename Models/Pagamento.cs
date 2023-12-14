using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class Pagamento
    {
                public int id{get;set;}
        public DateTime dataLimite{get; set;}
        public double valor{get;set;}
        public bool pago{get;set;}
        public NotaDeVenda notaDeVenda{get;set;}
    }
}
