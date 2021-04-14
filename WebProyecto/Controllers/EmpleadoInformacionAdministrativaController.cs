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
        // GET: EmpleadoInformacionAdministrativa
        private IEmpleadoInformacionAdministrativaService empleadoinformacionadministrativaService;
        private IEmpleadoService empleadoService;
        //private IProvinciaService provinciaService;
        //private ICantonService cantonService;
        //private IDistritoService distritoService;

        public EmpleadoInformacionAdministrativaController(IEmpleadoInformacionAdministrativaService empleadoinformacionadministrativaService, IEmpleadoService empleadoService)
        {
            this.empleadoinformacionadministrativaService = empleadoinformacionadministrativaService;
            this.empleadoService = empleadoService;
            //this.provinciaService = provinciaService;
            //this.cantonService = cantonService;
            //this.distritoService = distritoService;
        }

        public ActionResult Index()
        {
            this.SessionOnline();
            return View(empleadoinformacionadministrativaService.ObtenerLista(null));
        }
        public ActionResult Edit()
        {
            this.SessionOnline();

            var entity = new EmpleadoInformacionPersonal();
            try
            {

                entity.ddlEmpleados = empleadoService.ObtenerLista(null);
                //entity.ddlProvincias = provinciaService.ObtenerDll();

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

                result = empleadoinformacionadministrativaService.Insertar(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }

        /*[HttpPost]
        public ActionResult ddlCanton(InformacionPersonalEntity entity)
        {
            try
            {
                var result = new List<CantonEntity>();

                result = cantonService.ObtenerDll(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new List<CantonEntity>());
            }
        }

        [HttpPost]
        public ActionResult ddlDistrito(InformacionPersonalEntity entity)
        {
            try
            {
                var result = new List<DistritoEntity>();

                result = distritoService.ObtenerDll(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new List<DistritoEntity>());
            }
        }*/
    }
}