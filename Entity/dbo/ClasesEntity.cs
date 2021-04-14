using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClasesEntity : EN
    {
        public int? IdClases { get; set; }
        public string SalaImpartidaClases { get; set; }
        public string DiaDeLaSemanaClases { get; set; }
        public string HoraDeComienzoClases { get; set; }
        public string ActividadImpartidaClases { get; set; }
        public string ProfesorResponsableClases { get; set; }
        public bool EstadoClases { get; set; }
       
    }
}
