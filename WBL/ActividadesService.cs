using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IActividadesService : IDisposable
    {
        List<ActividadesEntity> ObtenerLista(int? IdActividades);
        ActividadesEntity ObtenerDetalle(int? IdActividades);
        List<ActividadesEntity> Obtenerddl(int? IdActividades);
        DBEntity Insertar(ActividadesEntity entity);
        DBEntity Actualizar(ActividadesEntity entity);
        DBEntity Eliminar(ActividadesEntity entity);
    }

    public class ActividadesService : IActividadesService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<ActividadesEntity> ObtenerLista(int? IdActividades)
        {
            try
            {
                var result = sql.Query<ActividadesEntity>("ClienteObtener"
                    , new
                    {
                        IdActividades
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActividadesEntity ObtenerDetalle(int? IdActividades)
        {
            try
            {
                var result = sql.QueryFirst<ActividadesEntity>("ActividadesObtener", new
                {
                    IdActividades
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ActividadesEntity> Obtenerddl(int? IdActividades)
        {
            try
            {
                var result = sql.Query<ActividadesEntity>("ActividadesLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBEntity Insertar(ActividadesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ActividadesInsertar", new
                {
                    entity.NombreActividad,
                    entity.Descripcion,
                    entity.Salas,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ActividadesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ActividadesActualizar", new
                {
                    entity.IdActividades,
                    entity.NombreActividad,
                    entity.Descripcion,
                    entity.Salas,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ActividadesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ActividadesEliminar", new
                {
                    entity.IdActividades
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