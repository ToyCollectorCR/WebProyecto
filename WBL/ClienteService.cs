using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClienteService : IDisposable
    {
        List<ClienteEntity> ObtenerLista(int? IdCliente);
        ClienteEntity ObtenerDetalle(int? IdCliente);
        DBEntity Insertar(ClienteEntity entity);
        DBEntity Actualizar(ClienteEntity entity);
        DBEntity Eliminar(ClienteEntity entity);
    }

    public class ClienteService : IClienteService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        /*public List<ClienteEntity> ObtenerLista()
        {
            try
            {
                var result = sql.Query<ClienteEntity, ClienteInformacionAdministrativaEntity>("ClienteObtener",
                    split: "IdClienteInformacionAdmin");

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/

        public List<ClienteEntity> ObtenerLista(int? IdCliente)
        {
            try
            {
                var result = sql.Query<ClienteEntity, ClienteInformacionAdministrativaEntity>("ClienteObtener"
                    , "IdClienteInformacionAdmin", new
                    {
                        IdCliente
                    });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ClienteEntity ObtenerDetalle(int? IdCliente)
        {
            try
            {
                var result = sql.QueryFirst<ClienteEntity>("ClienteObtener", new
                {
                    IdCliente
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DBEntity Insertar(ClienteEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteInsertar", new
                {
                    entity.IdClienteInformacionAdmin,
                    entity.NombreCliente,
                    entity.Apellido1Cliente,
                    entity.Apellido2Cliente,
                    entity.DireccionCliente,
                    entity.FechaNacimientoCliente,
                    entity.TelefonoCliente,
                    entity.DNICliente,
                    entity.TarifaTieneHijos,
                    TarifaCantidadHijos = entity.TarifaTieneHijos ? entity.TarifaCantidadHijos : null,
                    entity.EstadoCliente,

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ClienteEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteActualizar", new
                {
                    entity.IdCliente,
                    entity.IdClienteInformacionAdmin,
                    entity.NombreCliente,
                    entity.Apellido1Cliente,
                    entity.Apellido2Cliente,
                    entity.DireccionCliente,
                    entity.FechaNacimientoCliente,
                    entity.TelefonoCliente,
                    entity.DNICliente,
                    entity.TarifaTieneHijos,
                    entity.TarifaCantidadHijos,
                    entity.EstadoCliente,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ClienteEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteEliminar", new
                {
                    entity.IdCliente


                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


    }



}