using  Microsoft.Extensions.Configuration;
using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.IO;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{
    public class CLS_connection 
    {
        [Key]
        public string scode { get; set; }
        public int def_id { get; set; }
        public string def_name { get; set; }
        public int country_id { get; set; }
        public string country_name { get; set; }
        public SqlDataAdapter myDA;
        public SqlConnection myCN;
        public String Conn_strSQL;
        public IConfiguration _configuration;
        public string token_value;
        //public CLS_connection(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        public CLS_connection()
        {
            
        }

        public void OpenDB_general()
        {
            // IConfiguration configuration = new IConfiguration();
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory()) 
                              .AddJsonFile("appsettings.json") 
                              .AddEnvironmentVariables(); 
            _configuration = builder.Build();
            Conn_strSQL = _configuration.GetConnectionString("madrasty_context");
             myCN = new SqlConnection(Conn_strSQL);
            myCN.Open();
        }
        public string get_token()
        {
            // IConfiguration configuration = new IConfiguration();
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json")
                              .AddEnvironmentVariables();
            _configuration = builder.Build();
            return token_value = _configuration.GetValue<string>("Jwt:Key");

        }
        public DataSet get_defination_with_scode()
        {
            OpenDB_general();
            myDA = new SqlDataAdapter("Exec [get_defination_with_scode] '" + scode + @"'", myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(myDA);
            myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
           myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            myCN.Close();
            return myDS;

        }
        public DataSet get_countries()
        {
            OpenDB_general();
            myDA = new SqlDataAdapter("Exec [get_countries]", myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(myDA);
            myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            myCN.Close();
            return myDS;

        }
        //public DataSet get_department_def()
        //{
        //    OpenDB_general();
        //    myDA = new SqlDataAdapter("Exec [get_department_def]", myCN);
        //    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(myDA);
        //    myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //    DataSet myDS = new DataSet();
        //    myDA.Fill(myDS);
        //    myCN.Close();
        //    return myDS;
        //}
    }
}
