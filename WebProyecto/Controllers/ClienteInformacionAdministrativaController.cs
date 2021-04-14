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
    public class ClienteInformacionAdministrativaController : Controller
    {
        // GET: ClienteInformacionAdministrativa
        private IClienteInformacionAdministrativaService clienteinformacionadministrativaService;
        private IClientesService clientesService;
        //private IProvinciaService provinciaService;
        //private ICantonService cantonService;
        //private IDistritoService distritoService;

        public ClienteInformacionAdministrativaController(IClienteInformacionAdministrativaService clienteinformacionadministrativaService, IClientesService clientesService)
        {
            this.clienteinformacionadministrativaService = clienteinformacionadministrativaService;
            this.clientesService = clientesService;
            //this.provinciaService = provinciaService;
            //this.cantonService = cantonService;
            //this.distritoService = distritoService;
        }

        public ActionResult Index()
        {
            this.SessionOnline();

            var clientesIA = clienteinformacionadministrativaService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(clientesIA);
        }

        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new ClienteInformacionAdministrativaEdit() { clienteInformacionAdministrativa = new ClienteInformacionAdministrativaEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity.clienteInformacionAdministrativa = clienteinformacionadministrativaService.ObtenerDetalle(id);
                }
                entity.ddlClientes = clientesService.Obtenerddl(id);
                //entity.ddlclases = clasesService.Obtenerddl(id);
                //entity.ddlsalas = salasService.Obtenerddl(id);
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
        public ActionResult Save(ClienteInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdClienteInformacionAdmin.HasValue)
                {
                    result = clienteinformacionadministrativaService.Actualizar(entity);
                }
                else
                {
                    result = clienteinformacionadministrativaService.Insertar(entity);
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

                var result = clienteinformacionadministrativaService.Eliminar(new ClienteInformacionAdministrativaEntity { IdClienteInformacionAdmin = id });
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