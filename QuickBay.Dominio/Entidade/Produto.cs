using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBay.Dominio.Entidade
{
   public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; } 
        public string Descricao { get; set; }   
        public decimal Preco { get; set; }
    
    }
}
