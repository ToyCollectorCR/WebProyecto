using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClienteEntity : EN
    {
        public int? IdCliente { get; set; }

        public /*bool*/ int? IdBebe { get; set; }
        //fk
        public BebeEntity Bebe { get; set; }

        public int? IdClases { get; set; }
        //fK
        public ClasesEntity Clases { get; set; }

        public int? IdSalas { get; set; }
        //fK
        public SalasEntity Salas { get; set; }

        public int? IdTarifa { get; set; }
        //fK
        public TarifasEntity Tarifas { get; set; }

        public int? IdProductos { get; set; }
        //fK
        public ProductosEntity Productos { get; set; }

        public string NombreCliente { get; set; }
        public string Apellido1Cliente { get; set; }
        public string Apellido2Cliente { get; set; }
        public string DireccionCliente { get; set; }
        public string FechaNacimientoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DNICliente { get; set; }
        public bool EstadoCliente { get; set; }

        public ClienteEntity()
        {
            //depency injection manual
            Bebe = Bebe ?? new BebeEntity();
            Clases = Clases ?? new ClasesEntity();
            Salas = Salas ?? new SalasEntity();
            Tarifas = Tarifas ?? new TarifasEntity();
            Productos = Productos ?? new ProductosEntity();
        }

    }
}