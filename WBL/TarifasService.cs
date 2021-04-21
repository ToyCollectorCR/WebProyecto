using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ITarifasService : IDisposable
    {
        List<TarifasEntity> ObtenerLista(int? IdTarifa);
        List<TarifasEntity> Obtenerddl();
        DBEntity Insertar(TarifasEntity entity);
        DBEntity Actualizar(TarifasEntity entity);
        DBEntity Eliminar(TarifasEntity entity);
    }

    public class TarifasService : ITarifasService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<TarifasEntity> ObtenerLista(int? IdTarifa)
        {
            try
            {
                var result = sql.Query<TarifasEntity>("TarifasObtener", new
                {
                    IdTarifa
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<TarifasEntity> Obtenerddl()
        {
            try
            {
                var result = sql.Query<TarifasEntity>("TarifasLista");
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DBEntity Insertar(TarifasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TarifasInsertar", new
                {
                    entity.Tarifas,
                    entity.Ofertas,
                    entity.MesesDuracion,
                    entity.InclusionBebes,
                    entity.PrecioTarifa,
                    entity.DescripcionOfertas,
                    entity.EstadoOfertas
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(TarifasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TarifasActualizar", new
                {
                    entity.IdTarifa,
                    entity.Tarifas,
                    entity.Ofertas,
                    entity.MesesDuracion,
                    entity.InclusionBebes,
                    entity.PrecioTarifa,
                    entity.DescripcionOfertas,
                    entity.EstadoOfertas
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }



        public DBEntity Eliminar(TarifasEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TarifasEliminar", new
                {
                    entity.IdTarifa

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
