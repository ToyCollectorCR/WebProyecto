using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SalasEntity : EN
    {
        public int? IdSalas { get; set; }
        public string NombreSalas { get; set; }
        public int? CantidadSalas { get; set; }
        public bool EstadoSalas { get; set; }
    }
}