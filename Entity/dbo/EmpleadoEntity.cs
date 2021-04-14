using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class EmpleadoEntity : EN
    {
        public int? IdEmpleado { get; set; }
        //public int? IdCliente { get; set; }
        //public ClienteEntity Cliente { get; set; }
        public string TipoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Apellido1Empleado { get; set; }
        public string Apellido2Empleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string DNIEmpleado { get; set; }

        /*public BebeEntity()
        {
            Cliente = Cliente ?? new ClienteEntity();
        }*/
    }
}
