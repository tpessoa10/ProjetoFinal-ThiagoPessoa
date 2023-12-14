using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_ThiagoPessoa.Models
{
    public class NotaDeVenda
    {
         
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }
        public TipoDePagamento TipoDePagamento { get; set; }
        public int TipoDePagamentoId { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
        public Transportadora? Transportadora { get; set; }
        public int? TransportadoraId { get; set; }

        public void Cancelar(){
            //
        }

        public void Devolver(){
            //
        }
    }
}