using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class PedidosEdit
    {
        public PedidosEntity pedidos { get; set; }
        public List<ProveedoresEntity> ddlproveedores { get; set; }
        public List<ProductosEntity> ddlproductos { get; set; }
    }
}