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
        List<PedidosEntity> ObtenerLista(int? IdPedidos);
        List<PedidosEntity> Obtenerddl();
        DBEntity Insertar(PedidosEntity entity);
        DBEntity Actualizar(PedidosEntity entity);
        DBEntity Eliminar(PedidosEntity entity);
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
                var result = sql.Query<PedidosEntity>("PedidoObtener", new
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
                var result = sql.Query<PedidosEntity>("PedidoLista");
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
                var result = sql.QueryExecute("PedidoInsertar", new
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
                var result = sql.QueryExecute("PedidoActualizar", new
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
                var result = sql.QueryExecute("PedidoEliminar", new
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
