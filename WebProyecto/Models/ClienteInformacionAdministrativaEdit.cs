using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class ClienteInformacionAdministrativaEdit
    {
        public ClienteInformacionAdministrativaEntity clienteInformacionAdministrativa { get; set; } = new ClienteInformacionAdministrativaEntity();

        public List<ClienteEntity> ddlClientes { get; set; }

        //public List<ProvinciaEntity> ddlProvincias { get; set; }
    }
}