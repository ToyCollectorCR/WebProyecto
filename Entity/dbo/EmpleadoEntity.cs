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
        public int? IdEmpleadoInformacionAdministrativa { get; set; }
        public EmpleadoInformacionAdministrativaEntity EmpleadoInformacionAdministrativa { get; set; }
        public string TipoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Apellido1Empleado { get; set; }
        public string Apellido2Empleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string DNIEmpleado { get; set; }
        public bool EstadoEmpleado { get; set; }

        public EmpleadoEntity()
        {
            EmpleadoInformacionAdministrativa = EmpleadoInformacionAdministrativa ?? new EmpleadoInformacionAdministrativaEntity();
        }
    }
}
