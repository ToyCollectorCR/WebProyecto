using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WBL;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        private IPedidosService PedidosService;
        private IProductosService ProductosService;
        private IProveedoresService ProveedoresService;

        public PedidosController(IPedidosService pedidosService, IProductosService productosService, IProveedoresService proveedoresService)
        {
            PedidosService = pedidosService;
            ProductosService = productosService;
            ProveedoresService = proveedoresService;

        }



        public ActionResult Index()
        {
            this.SessionOnline();

            var pedidos = PedidosService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(pedidos);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            //var entity = new PedidosEntity();
            var entity = new PedidosEdit() { pedidos = new PedidosEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    //entity = IApp.pedidosService.ObtenerLista(id).FirstOrDefault();
                    entity.pedidos = PedidosService.ObtenerDetalle(id);
                }

                entity.ddlproductos = ProductosService.Obtenerddl();
                entity.ddlproveedores = ProveedoresService.Obtenerddl();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(PedidosEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdPedidos.HasValue)
                {
                    result = IApp.pedidosService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.pedidosService.Insertar(entity);
                    TempData["msg"] = "Se agrego el registro con exito!";
                }


                if (result.CodeError != 0) throw new Exception(result.MsgError);



                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {

                var result = IApp.pedidosService.Eliminar(new PedidosEntity { IdPedidos = id });
                TempData["msg"] = "Se elimino el registro con exito!";

                if (result.CodeError != 0) throw new Exception(result.MsgError);

                return RedirectToAction("index");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}