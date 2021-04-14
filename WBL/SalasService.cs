using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ISalasService : IDisposable
    {
        List<SalasEntity> ObtenerLista(int? IdSalas);
        SalasEntity ObtenerDetalle(int? IdSalas);
        List<SalasEntity> Obtenerddl(int? IdSalas);
        DBEntity Insertar(SalasEntity entity);
        DBEntity Actualizar(SalasEntity entity);
        DBEntity Eliminar(SalasEntity entity);
    }
    public class SalasService : ISalasService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<SalasEntity> ObtenerLista(int? IdSalas)
        {
            try
            {
                var result = sql.Query<SalasEntity>("SalasObtener"
                    , new
                    {
                        IdSalas
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SalasEntity ObtenerDetalle(int? IdSalas)
        {
            try
            {
                var result = sql.QueryFirst<SalasEntity>("SalasObtener", new
                {
                    IdSalas
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SalasEntity> Obtenerddl(int? IdSalas)
        {
            try
            {
                var result = sql.Query<SalasEntity>("SalasLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBEntity Insertar(SalasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("SalasInsertar", new
                {
                    entity.NombreSalas,
                    entity.CantidadSalas,
                    entity.EstadoSalas,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(SalasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("SalasActualizar", new
                {
                    entity.IdSalas,
                    entity.NombreSalas,
                    entity.CantidadSalas,
                    entity.EstadoSalas,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(SalasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("SalasEliminar", new
                {
                    entity.IdSalas
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