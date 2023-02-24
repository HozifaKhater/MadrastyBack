using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace SMS_Project.Models
{
    public class visits
    {
        [Key]
        public string attendance_precent { get; set; }
        public int visit_id { get; set; }
        public string visit_type_name { get; set; }
        public int visit_type_id { get; set; }
        public string visit_date { get; set; }
        public string phone { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string name { get; set; }
        public string topic { get; set; }
        public string instructions { get; set; }
        public string job { get; set; }
        public string notes { get; set; }
        public string dep_name { get; set; }
        public int dep_id { get; set; }
        public string vnote { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_visits()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_visits]  
         
   '" + visit_id + @"',
   '" + visit_type_name + @"',
   '" + visit_type_id + @"',
   '" + visit_date + @"',
   '" + phone + @"',
   '" + start_time + @"',
   '" + end_time + @"',
   '" + name + @"',
   '" + topic + @"',
   '" + instructions + @"',
   '" + job + @"',
   '" + notes + @"',
   '" + dep_name + @"',
   '" + dep_id + @"',
   '" + vnote + @"'


            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_visits_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_visits_with_id] '" + visit_id + @"'", con_db.myCN);
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

        public DataSet get_visits()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_visits] ", con_db.myCN);
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
        public int update_visits()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_visits]  
            '" + visit_id + @"',
   '" + visit_type_name + @"',
   '" + visit_type_id + @"',
   '" + visit_date + @"',
   '" + phone + @"',
   '" + start_time + @"',
   '" + end_time + @"',
   '" + name + @"',
   '" + topic + @"',
   '" + instructions + @"',
   '" + job + @"',
   '" + notes + @"',
   '" + dep_name + @"',
   '" + dep_id + @"',
   '" + vnote + @"'
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

        public int delete_from_visits()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_visits]  
            '" + visit_type_id + @"'
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
        public int save_in_student_attendance_precent()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_student_attendance_precent]  
         
   '" + attendance_precent + @"'
  


            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
    }
}
