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

        private IBebeService bebeService;
        private IClasesService clasesService;
        private ISalasService salasService;
        private ITarifasService tarifasService;
        private IProductosService productosService;
        private IClientesService clientesService;

        public ClienteController(IBebeService bebeService, IClasesService clasesService, ISalasService salasService, ITarifasService tarifasService, IProductosService productosService, IClientesService clientesService)
        {
            this.bebeService = bebeService;
            this.clasesService = clasesService;
            this.salasService = salasService;
            this.tarifasService = tarifasService;
            this.productosService = productosService;
            this.clientesService = clientesService;
        }
        public ActionResult Index()
        {
            this.SessionOnline();

            var clientes = clientesService.ObtenerLista(null);
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

                    entity.cliente = clientesService.ObtenerDetalle(id);
                }
                //entity.ddlbebe = bebeService.Obtenerddl(id);
                entity.ddlclases = clasesService.Obtenerddl(id);
                entity.ddlsalas = salasService.Obtenerddl(id);
                //entity.ddltarifas = tarifasService.Obtenerddl(id);
                entity.ddlproductos = productosService.Obtenerddl(id);
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
                    result = clientesService.Actualizar(entity);
                }
                else
                {
                    result = clientesService.Insertar(entity);
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

                var result = clientesService.Eliminar(new ClienteEntity { IdCliente = id });
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