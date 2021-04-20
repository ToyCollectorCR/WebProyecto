using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WBL;
using Entity;
using System.Web.Mvc;

namespace WebProyecto
{
    public struct IApp
    {
        public static IActividadesService actividadesService => new ActividadesService();
        public static IBebeService bebeService => new BebeService();
        public static IClasesService clasesService => new ClasesService();
        public static IClientesService clienteService => new ClienteService();
        public static IClienteInformacionAdministrativaService clienteinformacionadministrativaService => new ClienteInformacionAdministrativaService();
        public static IEmpleadoInformacionAdministrativaService empleadoinformacionadministrativaService => new EmpleadoInformacionAdministrativaService();
        public static IEmpleadoService empleadoService => new EmpleadoService();
        public static IGuarderiaService guarderiaService => new GuarderiaService();
        public static IPedidosService pedidosService => new PedidosService();
        public static IProductosService productosService => new ProductosService();
        public static IProveedoresService proveedoresService => new ProveedoresService();
        public static ISalasService salasService => new SalasService();
        public static ITarifasService tarifasService => new TarifasService();
        public static UsuarioEntity UsuarioSesion => HttpContext.Current.Session["UsuarioSession"] as UsuarioEntity ?? new UsuarioEntity();
    }

    public static class SessionExtension
    {
        public static void SessionOnline(this Controller ct)
        {
            if (!IApp.UsuarioSesion.IdUsuario.HasValue)
            {
                ct.Response.Redirect("/Login");
                ct.Response.Flush();
            }
        }
    }
}