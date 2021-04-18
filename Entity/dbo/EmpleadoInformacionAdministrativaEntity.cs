using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpleadoInformacionAdministrativaEntity : EN
    {
        public int? IdEmpleadoInformacionAdministrativa { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string CuentaBanco { get; set; }
        public int? RetencionCCSS { get; set; }
        public string GeneracionDePagos { get; set; }
        public string CategoriaProfesional { get; set; }
        public string AsignarActividades { get; set; }
        public string AsignarGuarderias { get; set; }
        
    }
}