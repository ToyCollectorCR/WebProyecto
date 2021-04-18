using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClienteInformacionAdministrativaEntity : EN
    {

        public int? IdClienteInformacionAdmin { get; set; }
        public int? Tarifa { get; set; }
        public string SesionesRayosUVA { get; set; }
        public string FechaProximaRenovacion { get; set; }
        public int Casillero { get; set; }
        public int SaldoMonederoVirtual { get; set; }
        
    }
}