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
    public class ClienteController : Controller
    {
        // GET: Cliente
        private IClienteService ClienteService;
        private ITarifasService TarifasService;
        private IClienteInformacionAdministrativaService ClienteinformacionAdministrativaService;        

        public ClienteController(IClienteService clienteService, ITarifasService tarifasService, IClienteInformacionAdministrativaService clienteinformacionadministrativaService)
        {
            ClienteService = clienteService;
            TarifasService = tarifasService;
            ClienteinformacionAdministrativaService = clienteinformacionadministrativaService;

        }
        // GET: Cliente

        public ActionResult Index()
        {
            this.SessionOnline();

            var clientes = ClienteService.ObtenerLista(null);
            if (TempData.ContainsKey("msg")) ViewData["msg"] = TempData["msg"].ToString();
            return View(clientes);
        }

        public ActionResult Edit(int? id)
        {
            this.SessionOnline();

            var entity = new ClienteEdit() { cliente = new ClienteEntity() };
            try
            {
                ViewBag.Form = false;
                if (id.HasValue)
                {
                    //editar
                    ViewBag.Form = true;

                    entity.cliente = ClienteService.ObtenerDetalle(id);
                }

                entity.ddltarifas = TarifasService.Obtenerddl();
                entity.ddlclienteinformacionadministrativa = ClienteinformacionAdministrativaService.Obtenerddl();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


            return View(entity);
        }



        [HttpPost]
        public ActionResult Save(ClienteEntity entity)
        {
            try
            {
                var result = new DBEntity();

                if (entity.IdCliente.HasValue)
                {
                    result = ClienteService.Actualizar(entity);
                }
                else
                {
                    result = ClienteService.Insertar(entity);
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

                var result = ClienteService.Eliminar(new ClienteEntity { IdCliente = id });
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