using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProductosService : IDisposable
    {
        List<ProductosEntity> ObtenerLista(int? IdProductos);
        ProductosEntity ObtenerDetalle(int? IdProductos);
        DBEntity Insertar(ProductosEntity entity);
        DBEntity Actualizar(ProductosEntity entity);
        DBEntity Eliminar(ProductosEntity entity);
    }

    public class ProductosService : IProductosService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }

        public List<ProductosEntity> ObtenerLista(int? IdProductos)
        {
            try
            {
                var result = sql.Query<ProductosEntity, ProveedoresEntity>("ProductosObtener"
                    , "IdProveedores", new
                    {
                        IdProductos
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductosEntity ObtenerDetalle(int? IdProductos)
        {
            try
            {
                var result = sql.QueryFirst<ProductosEntity>("ProductosObtener", new
                {
                    IdProductos
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DBEntity Insertar(ProductosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProductosInsertar", new
                {
                    entity.IdProveedores,
                    entity.NombreProductos,
                    entity.SesionesRayosUVA,
                    entity.RenovacionCuota,
                    entity.ProductosConsumidos,
                    entity.EstadoProducto
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(ProductosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProductosActualizar", new
                {
                    entity.IdProductos,
                    entity.IdProveedores,
                    entity.NombreProductos,
                    entity.SesionesRayosUVA,
                    entity.RenovacionCuota,
                    entity.ProductosConsumidos,
                    entity.EstadoProducto
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(ProductosEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ProductosEliminar", new
                {
                    entity.IdProductos
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