using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TarifasEntity : EN
    {
        public int? IdTarifa { get; set; }
        public string Tarifas { get; set; }
        public string Ofertas { get; set; }
        public int? MesesDuracion { get; set; }
        public int? InclusionBebes { get; set; }
        public int? PrecioTarifa { get; set; }
        public string DescripcionOfertas { get; set; }
        public bool EstadoOfertas { get; set; }
    }
}