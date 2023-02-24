using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;
namespace MadrastyAPI.Models
{
    public class signalir_connections
    {
        [Key]

        public int ser { get; set; }
        public string connection_id { get; set; } =string.Empty;
        public string title { get; set; } = string.Empty;
        public string body { get; set; } = string.Empty;
        public int from_emp_id { get; set; }
        public int to_emp_id { get; set; }
        public int job_id { get; set; }
        public int is_email { get; set; }
        public int object_id { get; set; }
        public string route { get; set; } = string.Empty;
        public CLS_connection con_db = new CLS_connection();
        public DataSet send_notifications()
        {
            is_email = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [send_notifications]  
            '" + from_emp_id + @"',
             '" + route + @"',
             '" + to_emp_id + @"',
             '" + is_email + @"',
 '" + object_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public DataSet send_notifications_emails()
        {
            is_email = 1;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [send_notifications]  
            '" + from_emp_id + @"',
             '" + route + @"',
             '" + to_emp_id + @"',
             '" + is_email + @"',
 '" + object_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public int save_in_signalir_connections()
        {
            try
            {
                int success_flag = 0;
                con_db.OpenDB_general();
                con_db.myDA = new SqlDataAdapter(@"Exec [save_in_signalir_connections]  
            '" + connection_id + @"'
            ", con_db.myCN);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
                con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                // con_obj.myDT = New DataTable()
                DataSet myDS = new DataSet();
                con_db.myDA.Fill(myDS);
                // con_obj.myDS.Tables.Add(con_obj.myDT)
                con_db.myCN.Close();
                return success_flag;
            }
            catch(Exception ex)
            {
                return 0;
            }
            
        }
        public DataSet get_signalir_connections()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_signalir_connections] ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public int delete_from_signalir_connections()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_signalir_connections]  
            '" + connection_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;

        }
    }
}
