using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class EmpleadoEdit
    {
        public EmpleadoEntity empleado { get; set; }

        public List<ClienteEntity> ddlClientes { get; set; }
        public List<ClienteInformacionAdministrativaEntity> ddlClienteInformacionAdministrativa { get; set; }
    }
}