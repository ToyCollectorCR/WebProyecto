using Dapper;
using Dapper.Mapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BD : IBD
    {
        public string Conn { get; set; }

        public BD(string conn)
        {
            Conn = new SqlConnectionStringBuilder(ConfigurationManager.AppSettings[conn])
            {
                MultipleActiveResultSets = true,
                AsynchronousProcessing = true
            }.ConnectionString;
        }

        public IDbConnection Exec()
        {
            IDbConnection sql = new SqlConnection();
            try
            {
                sql = new SqlConnection(Conn);
                return sql;
            }
            catch (Exception ex)
            {
                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }
        }

        public List<dynamic> Query(string Sp, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<dynamic>();

                result = sql.Query(sql: Sp, param: new DynamicParameters(Param),
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public List<T> Query<T>(string Sp, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T>(sql: Sp, param: new DynamicParameters(Param),
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public List<T> Query<T, Q>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public List<T> Query<T, Q, S>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public List<T> Query<T, Q, S, R>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S, R>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }

        public List<T> Query<T, Q, S, R, E>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S, R, E>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public List<T> Query<T, Q, S, R, E, A>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S, R, E, A>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }

        public List<T> Query<T, Q, S, R, E, A, G>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S, R, E, A, G>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }

        /*public List<T> Query<T, Q, S, R, E, A, G, B>(string Sp, string split, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {
                var result = new List<T>();

                result = sql.Query<T, Q, S, R, E, A, G, B>(sql: Sp, param: new DynamicParameters(Param), splitOn: split,
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout).AsList();

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }*/


        public dynamic QueryFirst(string Sp, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {

                var result = sql.QueryFirstOrDefault(sql: Sp, param: new DynamicParameters(Param),
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout);

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }


        public T QueryFirst<T>(string Sp, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {

                var result = sql.QueryFirstOrDefault<T>(sql: Sp, param: new DynamicParameters(Param),
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout);

                if (sql.State == ConnectionState.Open) sql.Close();

                return result;

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }



        public DBEntity QueryExecute(string Sp, object Param = null, int? timeout = null)
        {
            IDbConnection sql = Exec();
            try
            {

                var result = (IDictionary<string, object>)sql.QueryFirstOrDefault(sql: Sp, param: new DynamicParameters(Param),
                    commandType: CommandType.StoredProcedure, commandTimeout: timeout);

                if (sql.State == ConnectionState.Open) sql.Close();

                int code = int.Parse(result.ElementAt(0).Value.ToString());
                string msg = result.ElementAt(1).Value.ToString();

                return new DBEntity { CodeError = code, MsgError = msg };

            }
            catch (Exception ex)
            {

                if (sql.State == ConnectionState.Open) sql.Close();
                throw ex;
            }

        }

    }
}