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
    public class BebeController : Controller
    {
        // GET: Bebe

        private IBebeService bebeService;
        //private IClasesService clasesService;
        //private ISalasService salasService;
        //private ITarifasService tarifasService;
        //private IProductosService productosService;
        //private IClientesService clientesService;

        public BebeController(IBebeService bebeService/*, IClasesService clasesService, ISalasService salasService, ITarifasService tarifasService, IProductosService productosService, IClientesService clientesService*/)
        {
            this.bebeService = bebeService;
            //this.clasesService = clasesService;
            //this.salasService = salasService;
            //this.tarifasService = tarifasService;
            //this.productosService = productosService;
            //this.clientesService = clientesService;
        }

        public ActionResult Index()
        {
            this.SessionOnline();

            var bebes = bebeService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(bebes);
        }

        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new BebeEdit() { bebe = new BebeEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity.bebe = bebeService.ObtenerDetalle(id);
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
        public ActionResult Save(BebeEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdBebe.HasValue)
                {
                    result = bebeService.Actualizar(entity);
                }
                else
                {
                    result = bebeService.Insertar(entity);
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

                var result = bebeService.Eliminar(new BebeEntity { IdBebe = id });
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