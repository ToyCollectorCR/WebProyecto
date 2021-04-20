using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class ClienteEdit
    {
        public ClienteEntity cliente { get; set; }
        public List<TarifasEntity> ddltarifas { get; set; }
        public List<ClienteInformacionAdministrativaEntity> ddlclienteinformacionadministrativa { get; set; }

    }
}