using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProveedoresEntity : EN
    {
        public int? IdProveedores { get; set; }
        //public int? IdCliente { get; set; }
        //public ClienteEntity Cliente { get; set; }
        public string NombreProveedores { get; set; }
        public string TelefonoProveedores { get; set; }
        public string CorreoProveedores { get; set; }
        public bool EstadoProveedores { get; set; }

        /*public BebeEntity()
        {
            Cliente = Cliente ?? new ClienteEntity();
        }*/
    }
}