using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProyecto.Controllers
{
    public class GuarderiaController : Controller
    {
        // GET: Guarderia

        public ActionResult Index()
        {
            this.SessionOnline();
            var guarderia = IApp.guarderiaService.ObtenerLista(null);

            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();

            return View(guarderia);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new GuarderiaEntity();
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity = IApp.guarderiaService.ObtenerLista(id).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(GuarderiaEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdGuarderia.HasValue)
                {
                    result = IApp.guarderiaService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.guarderiaService.Insertar(entity);
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

                var result = IApp.guarderiaService.Eliminar(new GuarderiaEntity { IdGuarderia = id });
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