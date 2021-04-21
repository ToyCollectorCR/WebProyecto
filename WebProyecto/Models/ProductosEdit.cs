using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Models
{
    public class ProductosEdit
    {
        public ProductosEntity productos { get; set; }
        public List<ProveedoresEntity> ddlproveedores { get; set; }
    }
}