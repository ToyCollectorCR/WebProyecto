using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IGuarderiaService : IDisposable
    {
        List<GuarderiaEntity> ObtenerLista(int? IdGuarderia);
        List<GuarderiaEntity> Obtenerddl();
        DBEntity Insertar(GuarderiaEntity entity);
        DBEntity Actualizar(GuarderiaEntity entity);
        DBEntity Eliminar(GuarderiaEntity entity);
    }
    public class GuarderiaService : IGuarderiaService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<GuarderiaEntity> ObtenerLista(int? IdGuarderia)
        {
            try
            {
                var result = sql.Query<GuarderiaEntity>("GuarderiaObtener", new
                {
                    IdGuarderia
                });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<GuarderiaEntity> Obtenerddl()
        {
            try
            {
                var result = sql.Query<GuarderiaEntity>("GuarderiaLista");
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DBEntity Insertar(GuarderiaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("GuarderiaInsertar", new
                {
                    entity.NombreGuarderia,
                    entity.DiaDeLaSemanaGuarderia,
                    entity.HoraDeComienzoGuarderia,
                    entity.ProfesorResponsableGuarderia,
                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(GuarderiaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("GuarderiaActualizar", new
                {
                    entity.IdGuarderia,
                    entity.NombreGuarderia,
                    entity.DiaDeLaSemanaGuarderia,
                    entity.HoraDeComienzoGuarderia,
                    entity.ProfesorResponsableGuarderia,

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }



        public DBEntity Eliminar(GuarderiaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("GuarderiaEliminar", new
                {
                    entity.IdGuarderia

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
