using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IBebeService : IDisposable
    {
        List<BebeEntity> ObtenerLista(int? IdBebe);
        BebeEntity ObtenerDetalle(int? IdBebe);
        List<BebeEntity> Obtenerddl(int? IdBebe);
        DBEntity Insertar(BebeEntity entity);
        DBEntity Actualizar(BebeEntity entity);
        DBEntity Eliminar(BebeEntity entity);
    }

    public class BebeService : IBebeService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }

        public List<BebeEntity> ObtenerLista(int? IdBebe)
        {
            try
            {
                var result = sql.Query<BebeEntity>("BebeObtener"
                    , new
                    {
                        IdBebe
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BebeEntity ObtenerDetalle(int? IdBebe)
        {
            try
            {
                var result = sql.QueryFirst<BebeEntity>("BebeObtener", new
                {
                    IdBebe
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BebeEntity> Obtenerddl(int? IdBebe)
        {
            try
            {
                var result = sql.Query<BebeEntity>("BebeLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBEntity Insertar(BebeEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("BebeInsertar", new
                {
                    entity.NombreBebe,
                    entity.Apellido1Bebe,
                    entity.Apellido2Bebe,
                    entity.NombrePadreMadreBebe,
                    entity.FechaNaciminetoBebe,
                    entity.InscripcionClasesBebe,
                    entity.AforoDisponibleBebe,
                    entity.EstadoBebe,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(BebeEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("BebeActualizar", new
                {
                    entity.IdBebe,
                    entity.NombreBebe,
                    entity.Apellido1Bebe,
                    entity.Apellido2Bebe,
                    entity.NombrePadreMadreBebe,
                    entity.FechaNaciminetoBebe,
                    entity.InscripcionClasesBebe,
                    entity.AforoDisponibleBebe,
                    entity.EstadoBebe,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(BebeEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("BebeEliminar", new
                {
                    entity.IdBebe
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
