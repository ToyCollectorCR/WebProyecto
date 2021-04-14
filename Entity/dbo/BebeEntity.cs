using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BebeEntity : EN
    {
        public int? IdBebe { get; set; }
        public string NombreBebe { get; set; }
        public string Apellido1Bebe { get; set; }
        public string Apellido2Bebe { get; set; }
        public string NombrePadreMadreBebe { get; set; }
        public string FechaNaciminetoBebe { get; set; }
        public int? InscripcionClasesBebe { get; set; }
        public int? AforoDisponibleBebe { get; set; }
        public bool EstadoBebe { get; set; }
    }
}