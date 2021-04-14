using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClienteInformacionAdministrativaService : IDisposable
    {
        List<ClienteInformacionAdministrativaEntity> ObtenerLista(int? IdClienteInformacionAdmin);
        ClienteInformacionAdministrativaEntity ObtenerDetalle(int? IdClienteInformacionAdmin);
        List<ClienteInformacionAdministrativaEntity> Obtenerddl(int? IdClienteInformacionAdmin);
        DBEntity Insertar(ClienteInformacionAdministrativaEntity entity);
        DBEntity Actualizar(ClienteInformacionAdministrativaEntity entity);
        DBEntity Eliminar(ClienteInformacionAdministrativaEntity entity);

    }

    public class ClienteInformacionAdministrativaService : IClienteInformacionAdministrativaService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }

        public List<ClienteInformacionAdministrativaEntity> ObtenerLista(int? IdClienteInformacionAdmin)
        {
            try
            {
                var result = sql.Query<ClienteInformacionAdministrativaEntity, ClienteEntity>("ClienteInformacionAdministrativaObtener", "IdCliente"
                    , new
                    {
                        IdClienteInformacionAdmin
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClienteInformacionAdministrativaEntity ObtenerDetalle(int? IdClienteInformacionAdmin)
        {
            try
            {
                var result = sql.QueryFirst<ClienteInformacionAdministrativaEntity>("ClienteInformacionAdministrativaObtener", new
                {
                    IdClienteInformacionAdmin
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClienteInformacionAdministrativaEntity> Obtenerddl(int? IdClienteInformacionAdmi)
        {
            try
            {
                var result = sql.Query<ClienteInformacionAdministrativaEntity>("ClienteInformacionAdministrativaLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DBEntity Insertar(ClienteInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteInformacionAdministrativaInsertar", new
                {
                    entity.IdCliente,
                    entity.Tarifa,
                    entity.SesionesRayosUVA,
                    entity.FechaProximaRenovacion,
                    entity.Casillero,
                    entity.SaldoMonederoVirtual,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ClienteInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteInformacionAdministrativaActualizar", new
                {
                    entity.IdClienteInformacionAdmin,
                    entity.IdCliente,
                    entity.Tarifa,
                    entity.SesionesRayosUVA,
                    entity.FechaProximaRenovacion,
                    entity.Casillero,
                    entity.SaldoMonederoVirtual,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ClienteInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteInformacionAdministrativaEliminar", new
                {
                    entity.IdClienteInformacionAdmin
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