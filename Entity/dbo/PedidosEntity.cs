using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PedidosEntity : EN
    {
        public int? IdPedidos { get; set; }
        public string Pedidos { get; set; }
        public bool EstadoPedidos { get; set; }
    }
}
