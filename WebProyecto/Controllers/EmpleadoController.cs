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
    public class EmpleadoController : Controller
    {
        //private IClasesService clasesservice;
        private IEmpleadoInformacionAdministrativaService EmpleadoInformacionAdministrativaService;
        private IEmpleadoService EmpleadoService;

        //public EmpleadoController(IClasesService clasesservice, IPuestosService puestosService, IEmpleadoService empleadoService)
        public EmpleadoController(IEmpleadoService empleadoService, IEmpleadoInformacionAdministrativaService empleadoInformacionAdministrativaService)
        {
            //this.clasesservice = clasesservice;
            this.EmpleadoInformacionAdministrativaService = empleadoInformacionAdministrativaService;
            this.EmpleadoService = empleadoService;
        }
        public ActionResult Index()
        {
            this.SessionOnline();

            var empleados = EmpleadoService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(empleados);
        }

        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new EmpleadoEdit() { empleado = new EmpleadoEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity.empleado = EmpleadoService.ObtenerDetalle(id);
                }

                //entity.ddlPuestos = puestosService.Obtenerddl();
                //entity.ddlContratos = tiposContratos.Obtenerddl(id);

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }



        [HttpPost]
        public ActionResult Save(EmpleadoEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdEmpleado.HasValue)
                {
                    result = EmpleadoService.Actualizar(entity);
                }
                else
                {
                    result = EmpleadoService.Insertar(entity);
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

                var result = EmpleadoService.Eliminar(new EmpleadoEntity { IdEmpleado = id });
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