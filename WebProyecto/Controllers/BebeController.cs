using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProyecto.Controllers
{
    public class BebeController : Controller
    {
        // GET: Bebe
        public ActionResult Index()
        {
            this.SessionOnline();
            var bebe = IApp.bebeService.ObtenerLista(null);

            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();

            return View(bebe);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new BebeEntity();
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity = IApp.bebeService.ObtenerLista(id).FirstOrDefault();
                }

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
                    result = IApp.bebeService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.bebeService.Insertar(entity);
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

                var result = IApp.bebeService.Eliminar(new BebeEntity { IdBebe = id });
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