using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProveedoresService : IDisposable
    {
        List<ProveedoresEntity> ObtenerLista(int? IdProveedores);
        ProveedoresEntity ObtenerDetalle(int? IdProveedores);
        List<ProveedoresEntity> Obtenerddl(int? IdProveedores);
        DBEntity Insertar(ProveedoresEntity entity);
        DBEntity Actualizar(ProveedoresEntity entity);
        DBEntity Eliminar(ProveedoresEntity entity);
    }
    public class ProveedoresService : IProveedoresService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<ProveedoresEntity> ObtenerLista(int? IdProveedores)
        {
            try
            {
                var result = sql.Query<ProveedoresEntity>("ProveedoresObtener"
                    , new
                    {
                        IdProveedores
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProveedoresEntity ObtenerDetalle(int? IdProveedores)
        {
            try
            {
                var result = sql.QueryFirst<ProveedoresEntity>("ProveedoresObtener", new
                {
                    IdProveedores
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProveedoresEntity> Obtenerddl(int? IdProveedores)
        {
            try
            {
                var result = sql.Query<ProveedoresEntity>("ProveedoresLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBEntity Insertar(ProveedoresEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProveedoresInsertar", new
                {
                    entity.NombreProveedores,
                    entity.TelefonoProveedores,
                    entity.CorreoProveedores,
                    entity.EstadoProveedores,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ProveedoresEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProveedoresActualizar", new
                {
                    entity.IdProveedores,
                    entity.NombreProveedores,
                    entity.TelefonoProveedores,
                    entity.CorreoProveedores,
                    entity.EstadoProveedores,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ProveedoresEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProveedoresEliminar", new
                {
                    entity.IdProveedores
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