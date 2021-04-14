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
    public class ClasesController : Controller
    {
        // GET: Clases

        //private IBebeService bebeService;
        private IClasesService clasesService;
        //private ISalasService salasService;
        //private ITarifasService tarifasService;
        //private IProductosService productosService;
        //private IClientesService clientesService;

        public ClasesController(IClasesService clasesService/*, IClasesService clasesService, ISalasService salasService, ITarifasService tarifasService, IProductosService productosService, IClientesService clientesService*/)
        {
            //this.bebeService = bebeService;
            this.clasesService = clasesService;
            //this.salasService = salasService;
            //this.tarifasService = tarifasService;
            //this.productosService = productosService;
            //this.clientesService = clientesService;
        }
       
        public ActionResult Index()
        { 
            this.SessionOnline();

            var clases = clasesService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(clases);
        }

        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new ClasesEdit() { clases = new ClasesEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity.clases = clasesService.ObtenerDetalle(id);
                }
                //entity.ddlbebe = bebeService.Obtenerddl(id);
                //entity.ddlclases = clasesService.Obtenerddl(id);
                //entity.ddltarifas = tarifasService.Obtenerddl(id);
                //entity.ddlproductos = productosService.Obtenerddl(id);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(ClasesEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdClases.HasValue)
                {
                    result = clasesService.Actualizar(entity);
                }
                else
                {
                    result = clasesService.Insertar(entity);
                }

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {

                var result = clasesService.Eliminar(new ClasesEntity { IdClases = id });
                TempData["msg"] = "0";

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