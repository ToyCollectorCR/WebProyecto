using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProyecto.Controllers
{
    public class SalasController : Controller
    {
        // GET: Salas
        public ActionResult Index()
        {
            this.SessionOnline();
            var salas = IApp.salasService.ObtenerLista(null);

            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();

            return View(salas);
        }
        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new SalasEntity();
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity = IApp.salasService.ObtenerLista(id).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }

        [HttpPost]
        public ActionResult Save(SalasEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdSalas.HasValue)
                {
                    result = IApp.salasService.Actualizar(entity);
                    TempData["msg"] = "Se Actualizo el registro con exito!";

                }
                else
                {
                    result = IApp.salasService.Insertar(entity);
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

                var result = IApp.salasService.Eliminar(new SalasEntity { IdSalas = id });
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