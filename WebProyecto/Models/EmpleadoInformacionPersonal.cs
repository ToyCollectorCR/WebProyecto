using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class EmpleadoInformacionPersonal
    {
        public EmpleadoInformacionAdministrativaEntity EmpleadoInformacionAdministrativa { get; set; } = new EmpleadoInformacionAdministrativaEntity();

        public List<EmpleadoEntity> ddlEmpleados { get; set; }

        //public List<ProvinciaEntity> ddlProvincias { get; set; }
    }
}