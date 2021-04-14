using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IEmpleadoInformacionAdministrativaService : IDisposable
    {
        List<EmpleadoInformacionAdministrativaEntity> ObtenerLista(int? IdInformacionAdministrativaEmpleado);
        EmpleadoInformacionAdministrativaEntity ObtenerDetalle(int? IdInformacionAdministrativaEmpleado);
        List<EmpleadoInformacionAdministrativaEntity> Obtenerddl(int? IdInformacionAdministrativaEmpleado);
        DBEntity Insertar(EmpleadoInformacionAdministrativaEntity entity);
        DBEntity Actualizar(EmpleadoInformacionAdministrativaEntity entity);
        DBEntity Eliminar(EmpleadoInformacionAdministrativaEntity entity);
    }

    public class EmpleadoInformacionAdministrativaService : IEmpleadoInformacionAdministrativaService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<EmpleadoInformacionAdministrativaEntity> ObtenerLista(int? IdCliente)
        {
            try
            {
                var result = sql.Query<EmpleadoInformacionAdministrativaEntity, EmpleadoEntity>("EmpleadoInformacionAdministrativaObtener",
                    split: "IdEmpleado");
                    
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmpleadoInformacionAdministrativaEntity ObtenerDetalle(int? IdInformacionAdministrativaEmpleado)
        {
            try
            {
                var result = sql.QueryFirst<EmpleadoInformacionAdministrativaEntity>("EmpleadoInformacionAdministrativaObtener", new
                {
                    IdInformacionAdministrativaEmpleado
                });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmpleadoInformacionAdministrativaEntity> Obtenerddl(int? IdInformacionAdministrativaEmpleado)
        {
            try
            {
                var result = sql.Query<EmpleadoInformacionAdministrativaEntity>("EmpleadoInformacionAdministrativaLista");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DBEntity Insertar(EmpleadoInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoInformacionAdministrativaInsertar", new
                {
                    entity.IdEmpleado,
                    entity.NumeroSeguroSocial,
                    entity.CuentaBanco,
                    entity.RetencionCCSS,
                    entity.GeneracionDePagos,
                    entity.CategoriaProfesional,
                    entity.AsignarActividades,
                    entity.AsignarGuarderias,
                });


                return result;
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(EmpleadoInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoInformacionAdministrativaActualizar", new
                {
                    entity.IdInformacionAdministrativaEmpleado,
                    entity.IdEmpleado,
                    entity.NumeroSeguroSocial,
                    entity.CuentaBanco,
                    entity.RetencionCCSS,
                    entity.GeneracionDePagos,
                    entity.CategoriaProfesional,
                    entity.AsignarActividades,
                    entity.AsignarGuarderias,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(EmpleadoInformacionAdministrativaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("ClienteInformacionAdministrativaEliminar", new
                {
                    entity.IdInformacionAdministrativaEmpleado
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