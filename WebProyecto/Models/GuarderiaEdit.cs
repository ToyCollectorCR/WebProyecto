using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;


namespace WebProyecto.Models
{
    public class GuarderiaEdit
    {
        public GuarderiaEntity Guarderia { get; set; } = new GuarderiaEntity();
        public GuarderiaEntity IdGuarderia { get; set; } = new GuarderiaEntity();
        //public List<BebeEntity> ddlbebe { get; set; }
        //public List<ClasesEntity> ddlclases { get; set; }
        //public List<SalasEntity> ddlsalas { get; set; }
        //public List<TarifasEntity> ddltarifas { get; set; }
        //public List<ProductosEntity> ddlproductos { get; set; }
    }
}