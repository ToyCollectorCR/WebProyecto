using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductosEntity : EN
    {
        public int? IdProductos { get; set; }
        public string NombreProductos { get; set; }
        public string SesionesRayosUVA { get; set; }
        public string RenovacionCuota { get; set; }
        public string ProductosConsumidos { get; set; }
        public string CompraProveedores { get; set; }
        public bool EstadoProducto { get; set; }
    }
}