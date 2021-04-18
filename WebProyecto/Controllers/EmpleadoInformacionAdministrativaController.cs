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
    public class EmpleadoInformacionAdministrativaController : Controller
    {
        // GET: Tarifas
        public ActionResult Index()
        {
            this.SessionOnline();
            var contratos = IApp.empleadoinformacionadministrativaService.ObtenerLista(null);

            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();

            return View(contratos);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new EmpleadoInformacionAdministrativaEntity();
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity = IApp.empleadoinformacionadministrativaService.ObtenerLista(id).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(EmpleadoInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdInformacionAdministrativaEmpleado.HasValue)
                {
                    result = IApp.empleadoinformacionadministrativaService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.empleadoinformacionadministrativaService.Insertar(entity);
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

                var result = IApp.empleadoinformacionadministrativaService.Eliminar(new EmpleadoInformacionAdministrativaEntity { IdInformacionAdministrativaEmpleado = id });
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