using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpleadoInformacionAdministrativaEntity : EN
    {
        public int? IdInformacionAdministrativaEmpleado { get; set; }
        public int? IdEmpleado { get; set; }
        public EmpleadoEntity Empleado { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string CuentaBanco { get; set; }
        public int? RetencionCCSS { get; set; }
        public string GeneracionDePagos { get; set; }
        public string CategoriaProfesional { get; set; }
        public string AsignarActividades { get; set; }
        public string AsignarGuarderias { get; set; }
        
        public EmpleadoInformacionAdministrativaEntity()
        {
            Empleado = Empleado ?? new EmpleadoEntity();
        }
    }
}