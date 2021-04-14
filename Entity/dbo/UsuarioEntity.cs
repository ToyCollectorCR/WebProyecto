using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UsuarioEntity : EN
    {

        public int? IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public bool Estado { get; set; }
    }
}
