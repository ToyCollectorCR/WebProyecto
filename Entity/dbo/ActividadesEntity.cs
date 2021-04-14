using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ActividadesEntity : EN
    {
        public int? IdActividades { get; set; }
        public string NombreActividad { get; set; }
        public string Descripcion { get; set; }
        public int? Salas { get; set; }
        
    }
}
