using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class TipoDePagamento
    {
                 public int id{get;set;}
        public string nomeDoCobrado{get; set;}
        public string informacoesAdicionais{get;set;}
        public ICollection<NotaDeVenda> notaDeVenda{get;set;}
    }
}