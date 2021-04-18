using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GuarderiaEntity:EN
    {
        public int? IdGuarderia { get; set; }
        public string NombreGuarderia { get; set; }
        public DateTime DiaDeLaSemanaGuarderia { get; set; }
        public DateTime HoraDeComienzoGuarderia { get; set; }
        public string ProfesorResponsableGuarderia { get; set; }

    }
}
