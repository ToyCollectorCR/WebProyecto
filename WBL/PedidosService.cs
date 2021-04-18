using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IPedidosService : IDisposable
    {
        List<TarifasEntity> ObtenerLista(int? IdTarifa);
        List<TarifasEntity> Obtenerddl();
        DBEntity Insertar(TarifasEntity entity);
        DBEntity Actualizar(TarifasEntity entity);
        DBEntity Eliminar(TarifasEntity entity);
    }
    public class PedidosService : IPedidosService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<PedidosEntity> ObtenerLista(int? IdPedidos)
        {
            try
            {
                var result = sql.Query<PedidosEntity>("PedidosObtener", new
                {
                    IdPedidos
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PedidosEntity> Obtenerddl()
        {
            try
            {
                var result = sql.Query<PedidosEntity>("PedidosLista");
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DBEntity Insertar(PedidosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("PedidosInsertar", new
                {
                    entity.Pedidos,
                    entity.EstadoPedidos
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(PedidosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("PedidosActualizar", new
                {
                    entity.IdPedidos,
                    entity.Pedidos,
                    entity.EstadoPedidos
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }



        public DBEntity Eliminar(PedidosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("PedidosEliminar", new
                {
                    entity.IdPedidos

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
