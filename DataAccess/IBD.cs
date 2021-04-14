using Entity;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public interface IBD
    {
        IDbConnection Exec();
        List<dynamic> Query(string Sp, object Param = null, int? timeout = null);
        //List<T> Query<T, Q, S, R, E, A, G, B>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q, S, R, E, A, G>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q, S, R, E, A>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q, S, R, E>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q, S, R>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q, S>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T, Q>(string Sp, string split, object Param = null, int? timeout = null);
        List<T> Query<T>(string Sp, object Param = null, int? timeout = null);
        DBEntity QueryExecute(string Sp, object Param = null, int? timeout = null);
        dynamic QueryFirst(string Sp, object Param = null, int? timeout = null);
        T QueryFirst<T>(string Sp, object Param = null, int? timeout = null);
    }
}