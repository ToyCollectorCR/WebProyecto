using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClasesService : IDisposable
    {
        List<ClasesEntity> ObtenerLista(int? IdClases);
        ClasesEntity ObtenerDetalle(int? IdClases);
        List<ClasesEntity> Obtenerddl(int? IdClases);
        DBEntity Insertar(ClasesEntity entity);
        DBEntity Actualizar(ClasesEntity entity);
        DBEntity Eliminar(ClasesEntity entity);
    }

    public class ClasesService : IClasesService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<ClasesEntity> ObtenerLista(int? IdClases)
        {
            try
            {
                var result = sql.Query<ClasesEntity>("ClasesObtener"
                    , new
                    {
                        IdClases
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClasesEntity ObtenerDetalle(int? IdClases)
        {
            try
            {
                var result = sql.QueryFirst<ClasesEntity>("ClasesObtener", new
                {
                    IdClases
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClasesEntity> Obtenerddl(int? IdClases)
        {
            try
            {
                var result = sql.Query<ClasesEntity>("ClasesLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBEntity Insertar(ClasesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClasesInsertar", new
                {
                    entity.SalaImpartidaClases,
                    entity.DiaDeLaSemanaClases,
                    entity.HoraDeComienzoClases,
                    entity.ActividadImpartidaClases,
                    entity.ProfesorResponsableClases,
                    entity.EstadoClases,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ClasesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClasesActualizar", new
                {
                    entity.IdClases,
                    entity.SalaImpartidaClases,
                    entity.DiaDeLaSemanaClases,
                    entity.HoraDeComienzoClases,
                    entity.ActividadImpartidaClases,
                    entity.ProfesorResponsableClases,
                    entity.EstadoClases,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ClasesEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClasesEliminar", new
                {
                    entity.IdClases
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