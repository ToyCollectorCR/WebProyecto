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

        public int? IdProductos { get; set; }
        //FK
        public ProductosEntity Productos { get; set; }

        public int? IdProveedores { get; set; }
        //FK
        public ProveedoresEntity Proveedores { get; set; }

        public string Descripcion { get; set; }
        public string FechaCompra { get; set; }
        public string FechaRecepcion { get; set; }
        public int? MontoCompra { get; set; }
        public int? CantidadUnidades { get; set; }
        public string FechaCaducidad { get; set; }
        public string MotivoDevolucion { get; set; }
        public bool EstadoPedidos { get; set; }

        public PedidosEntity()
        {
            //depency injection manual
            Proveedores = Proveedores ?? new ProveedoresEntity();

            Productos = Productos ?? new ProductosEntity();

        }


    }
}
