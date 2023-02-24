using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  Microsoft.Extensions.Configuration;
using  System;
using  System.Collections;
using  System.Collections.Generic;
using  System.Data;
using  System.Data.SqlClient;
using  System.Reflection;

namespace BusinessLogic.Contexts
{
    public class DatabaseContext : IDatabaseContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
       
        public List<SqlParameter> CreateListOfSqlParams<T>(T Model, string functionType, string id_name)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                var data = new SqlParameter { ParameterName = info.Name, Value = info.GetValue(Model, null) };

                if (data.ParameterName.Equals(id_name) && functionType.Equals("add"))
                {
                    continue;
                }
                else
                {
                    list.Add(data);
                }
            }

            return list;
        }
        public DataTable CreateDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }

            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    row[info.Name] = info.GetValue(t, null);
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        public async Task<DALResponse> ExecuteQuery(string storedProcedureName, Dictionary<string, string>? pars = null)
        {
            SqlConnection cnn;
            string connetionString = _configuration.GetConnectionString("madrasty_context");

            cnn = new SqlConnection(connetionString);
            SqlDataReader reader;
            var data = new DataTable();
           // string userConnectionString = "";

            try
            {
                // todo get user connection string from database



                //using  var getConnectionCommand = new SqlCommand("GetUserConnection", cnn)
                //{
                //    CommandType = CommandType.StoredProcedure
                //};

                //cnn.Open();
                //reader = await getConnectionCommand.ExecuteReaderAsync();
                //data.Load(reader);
                //cnn.Close();

                //if (data.Rows.Count > 0 && data.Rows[0][0] != null)
                //{
                //    userConnectionString = data.Rows[0][0]!.ToString();
                //}
                //else
                //{
                //    return new DALResponse(data.Rows[0]["MSG_D_Txt1"]!.ToString());
                //}

                //if (string.IsNullOrEmpty(userConnectionString))
                //    return new DALResponse("No Connection String");


                //cnn = new SqlConnection(userConnectionString);
                //reader = null;
                //data = new DataTable();

                using  var command = new SqlCommand(storedProcedureName, cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pars != null)
                {
                    pars.ToList().ForEach(par =>
                    {
                        command.Parameters.Add(par.Key, SqlDbType.VarChar).Value = par.Value;
                    });
                }

                cnn.Open();
                reader = await command.ExecuteReaderAsync();
                data.Load(reader);
                cnn.Close();

                if(data.Rows.Count > 0)
                {
                    DataColumnCollection columns = data.Columns;
                    if (columns.Contains("IsError") && columns["IsError"]?.ToString() == "1")
                    {
                        return new DALResponse(data.Rows[0]["MSG_D_Txt1"]!.ToString());
                    }
                }
                
                return new DALResponse(data);
            }
            catch (Exception ex)
            {
                // todo localize connection exception
                return new DALResponse(ex.Message);
            }
        }

        public async Task<DALResponse> ExecuteNonQuery(string storedProcedureName, List<SqlParameter> pars)
        {
            SqlConnection cnn;

            string connetionString = _configuration.GetConnectionString("madrasty_context");

            cnn = new SqlConnection(connetionString);
            SqlDataReader reader;
            var data = new DataTable();

            try
            {
                // todo get user connection string from database

                using  var command = new SqlCommand(storedProcedureName, cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pars != null)
                {
                    pars.ForEach(par =>
                    {
                        command.Parameters.Add(par);
                    });
                }

                //command.Parameters.Add(pars);

                cnn.Open();
                reader = await command.ExecuteReaderAsync();
                data.Load(reader);
                cnn.Close();

                if (data.Rows.Count > 0)
                {
                    DataColumnCollection columns = data.Columns;
                    if (columns.Contains("IsError") && columns["IsError"]?.ToString() == "1")
                    {
                        return new DALResponse(data.Rows[0]["MSG_D_Txt1"]!.ToString());
                    }
                }

                return new DALResponse(data);
            }
            catch (Exception ex)
            {
                // todo localize connection exception
                return new DALResponse(ex.Message);
            }
        }
    }
}
