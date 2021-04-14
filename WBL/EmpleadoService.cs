using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IEmpleadoService : IDisposable
    {
        List<EmpleadoEntity> ObtenerLista(int? IdEmpleado);
        EmpleadoEntity ObtenerDetalle(int? IdEmpleado);
        List<EmpleadoEntity> Obtenerddl(int? IdEmpleado);
        DBEntity Insertar(EmpleadoEntity entity);
        DBEntity Actualizar(EmpleadoEntity entity);
        DBEntity Eliminar(EmpleadoEntity entity);
    }
    public class EmpleadoService : IEmpleadoService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<EmpleadoEntity> ObtenerLista(int? IdEmpleado)
        {
            try
            {
                var result = sql.Query<EmpleadoEntity>("EmpleadoObtener"
                    , new
                    {
                        IdEmpleado
                    });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmpleadoEntity ObtenerDetalle(int? IdEmpleado)
        {
            try
            {
                var result = sql.QueryFirst<EmpleadoEntity>("EmpleadoObtener", new
                {
                    IdEmpleado
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmpleadoEntity> Obtenerddl(int? IdEmpleado)
        {
            try
            {
                var result = sql.Query<EmpleadoEntity>("EmpleadoLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DBEntity Insertar(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoInsertar", new
                {
                    entity.TipoEmpleado,
                    entity.NombreEmpleado,
                    entity.Apellido1Empleado,
                    entity.Apellido2Empleado,
                    entity.DireccionEmpleado,
                    entity.TelefonoEmpleado,
                    entity.DNIEmpleado,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoActualizar", new
                {
                    entity.IdEmpleado,
                    entity.TipoEmpleado,
                    entity.NombreEmpleado,
                    entity.Apellido1Empleado,
                    entity.Apellido2Empleado,
                    entity.DireccionEmpleado,
                    entity.TelefonoEmpleado,
                    entity.DNIEmpleado,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoEliminar", new
                {
                    entity.IdEmpleado
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