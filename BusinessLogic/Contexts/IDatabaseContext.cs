using  BusinessLogic.Responses;
using  System.Data;
using  System.Data.SqlClient;

namespace BusinessLogic.Contexts
{
    public interface IDatabaseContext
    {
        Task<DALResponse> ExecuteQuery(string storedProcedureName, Dictionary<string, string>? pars = null);
        DataTable CreateDataTable<T>(List<T> list);

        Task<DALResponse> ExecuteNonQuery(string storedProcedureName, List<SqlParameter> pars);
        List<SqlParameter> CreateListOfSqlParams<T>(T Model, string functionType, string id_name);
    }
}
