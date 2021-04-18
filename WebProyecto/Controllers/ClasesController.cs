using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProyecto.Controllers
{
    public class ClasesController : Controller
    {
        // GET: Clases
        public ActionResult Index()
        {
            this.SessionOnline();
            var clases = IApp.clasesService.ObtenerLista(null);

            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();

            return View(clases);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new ClasesEntity();
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity = IApp.clasesService.ObtenerLista(id).FirstOrDefault();
                }

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
                    result = IApp.clasesService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.clasesService.Insertar(entity);
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

                var result = IApp.clasesService.Eliminar(new ClasesEntity { IdClases = id });
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