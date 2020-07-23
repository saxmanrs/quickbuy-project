using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBay.Dominio.Entidade
{
    public class Pedido
    {

        public int Id_pedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataEntrega { get; set; }
        
        public int FormaPagamentoId {get;set;}
        public FormaPagamento FormaPagamento{get;set;}



        public ICollection<ItemPedido> ItensPedidos { get; set; }




    }
}
