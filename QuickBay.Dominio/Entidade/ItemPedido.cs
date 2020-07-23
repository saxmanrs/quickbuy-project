using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBay.Dominio.Entidade
{
   public class ItemPedido
    {
        public int IdPedido { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }


        public ICollection <ItemPedido> itensPedidos{get;set;}
    }
}
