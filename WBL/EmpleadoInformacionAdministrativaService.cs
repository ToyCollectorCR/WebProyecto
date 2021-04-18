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
        List<EmpleadoInformacionAdministrativaEntity> ObtenerLista(int? IdEmpleadoInformacionAdministrativa);
        List<EmpleadoInformacionAdministrativaEntity> Obtenerddl();
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

        public List<EmpleadoInformacionAdministrativaEntity> ObtenerLista(int? IdEmpleadoInformacionAdministrativa)
        {
            try
            {
                var result = sql.Query<EmpleadoInformacionAdministrativaEntity>("EmpleadoInformacionAdministrativaObtener", new
                {
                    IdEmpleadoInformacionAdministrativa
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EmpleadoInformacionAdministrativaEntity> Obtenerddl()
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
                    entity.IdEmpleadoInformacionAdministrativa,
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
                var result = sql.QueryExecute("EmpleadoInformacionAdministrativaEliminar", new
                {
                    entity.IdEmpleadoInformacionAdministrativa

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
