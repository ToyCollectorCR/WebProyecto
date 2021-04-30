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
    public class ProductosController : Controller
    {
            // GET: Productos
            private IProductosService ProductosService;
            private IProveedoresService ProveedoresService;

            public ProductosController(IProductosService productosService, IProveedoresService proveedoresService)
            {
                ProductosService = productosService;
                ProveedoresService = proveedoresService;

            }
            // GET: Productos
            public ActionResult Index()
        {
            this.SessionOnline();
            
            var productos = ProductosService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(productos);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            //var entity = new ProductosEntity();
            var entity = new ProductosEdit() { productos = new ProductosEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    //entity = IApp.productosService.ObtenerLista(id).FirstOrDefault();
                    entity.productos = ProductosService.ObtenerDetalle(id);
                }

                entity.ddlproveedores = ProveedoresService.Obtenerddl();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(ProductosEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdProductos.HasValue)
                {
                    result = IApp.productosService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.productosService.Insertar(entity);
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

                var result = IApp.productosService.Eliminar(new ProductosEntity { IdProductos = id });
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