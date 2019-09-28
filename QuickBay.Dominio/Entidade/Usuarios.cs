using System.Collections.Generic;

namespace QuickBay.Dominio.Entidade
{
   public class Usuarios
    {
        public int Id_usuarios { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string MyProperty { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
        
    }
}
    