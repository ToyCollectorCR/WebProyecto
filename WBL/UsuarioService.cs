using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace WBL
{

    public interface IUsuarioService : IDisposable
    {
        UsuarioEntity UsuarioLogin(UsuarioEntity entity);
        DBEntity Insertar(UsuarioEntity entity);
        DBEntity Actualizar(UsuarioEntity entity);

    }
    public class UsuarioService : IUsuarioService
    {

        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public UsuarioEntity UsuarioLogin(UsuarioEntity entity)
        {
            try
            {
                var Result = sql.QueryFirst<UsuarioEntity>("UsuarioLogin", Param: new
                {
                    entity.Usuario,
                    entity.Contrasena,
                });
                return Result;
            }
            catch (Exception ex)
            {
                return new UsuarioEntity() { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


        public DBEntity Insertar(UsuarioEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("UsuarioInsertar", new
                {
                    entity.Usuario,
                    entity.Nombre,
                    entity.Contrasena

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(UsuarioEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("UsuarioActualizar", new
                {
                    entity.IdUsuario,
                    entity.Nombre,
                    entity.Contrasena
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