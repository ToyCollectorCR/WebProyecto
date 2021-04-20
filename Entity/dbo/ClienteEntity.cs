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

        public int? IdClienteInformacionAdmin { get; set; }
        //FK
        public ClienteInformacionAdministrativaEntity ClienteInformacionAdministrativa { get; set; }

        public string NombreCliente { get; set; }
        public string Apellido1Cliente { get; set; }
        public string Apellido2Cliente { get; set; }
        public string DireccionCliente { get; set; }
        public string FechaNacimientoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DNICliente { get; set; }
        public bool TarifaTieneHijos { get; set; }
        public string TarifaCantidadHijos { get; set; }
        public bool EstadoCliente { get; set; }

        public ClienteEntity()
        {
            //depency injection manual
            ClienteInformacionAdministrativa = ClienteInformacionAdministrativa ?? new ClienteInformacionAdministrativaEntity();
        }

    }
}