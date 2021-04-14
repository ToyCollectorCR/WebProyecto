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
        //public int? IdCliente { get; set; }
        //public ClienteEntity Cliente { get; set; }
        public string Tarifas { get; set; }
        public string Ofertas { get; set; }
        public int? MesesDuracion { get; set; }
        public int? InclusionBebes { get; set; }
        public int? PrecioTarifa { get; set; }

        /*public BebeEntity()
        {
            Cliente = Cliente ?? new ClienteEntity();
        }*/
    }
}