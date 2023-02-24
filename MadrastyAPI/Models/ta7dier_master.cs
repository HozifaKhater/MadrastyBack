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
    public class ta7dier_master
    {
        [Key]
        public int civil_id { get; set; }
        public string? emp_dep { get; set; }
        public int ta7dier_id { get; set; }
        public int emp_id { get; set; }
        public string? emp_name { get; set; }
        public int subject_id { get; set; }
        public string? subject_name { get; set; }
        public int grade_id { get; set; }
        public string? grade_name { get; set; }
        public string? ta7dier_date { get; set; }
        public int ta7dier_week { get; set; }
        public int ta7dier_day { get; set; }
        public int ta7dier_state_id { get; set; }
        public string? state_name { get; set; }
        public string? ta7dier_name { get; set; }
        public string? ta7dier_body { get; set; }
        public string? ta7dier_notes { get; set; }
        public int ta7dier_supervision_state_id { get; set; }
        public string? ta7dier_supervision_state_name { get; set; }
        public string? ta7dier_state_name { get; set; }
        public string? ta7dier_file { get; set; }

        public string? ta7dier_file_type { get; set; }
        public int is_file { get; set; }
        public int dep_id { get; set; }
        public string? route { get; set; }
        public int to_emp_id { get; set; }
        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_ta7dier_master()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_ta7dier_master]  
         
            '" + emp_id + @"',
            '" + emp_name + @"',
            '" + subject_id + @"',
            '" + subject_name + @"',
            '" + grade_id + @"',
            '" + grade_name + @"',
            '" + ta7dier_date + @"',
            '" + ta7dier_week + @"',
            '" + ta7dier_day + @"',
            '" + ta7dier_state_id + @"',
            '" + state_name + @"',
            '" + ta7dier_name + @"',
            '" + ta7dier_body + @"',
            '" + ta7dier_notes + @"',
            '" + ta7dier_supervision_state_id + @"',
            '" + ta7dier_supervision_state_name + @"',
            '" + ta7dier_state_name + @"',
   '" + ta7dier_file + @"',
 '" + ta7dier_file_type + @"',
   '" + is_file + @"'

            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            con_db.myCN.Close();
            return success_flag;
        }

        public DataSet get_ta7dier_master()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_ta7dier_master]", con_db.myCN);
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
        public DataSet get_ta7dier_master_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_ta7dier_master_with_id]'" + ta7dier_id + @"'", con_db.myCN);
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
        public DataSet get_ta7dier_master_with_subject_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_ta7dier_master_with_subject_id]'" + subject_id + @"'", con_db.myCN);
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

        public int update_ta7dier_master()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_ta7dier_master] 
'" + ta7dier_id + @"',
    '" + emp_id + @"',
            '" + emp_name + @"',
            '" + subject_id + @"',
            '" + subject_name + @"',
            '" + grade_id + @"',
            '" + grade_name + @"',
            '" + ta7dier_date + @"',
            '" + ta7dier_week + @"',
            '" + ta7dier_day + @"',
            '" + ta7dier_state_id + @"',
            '" + state_name + @"',
            '" + ta7dier_name + @"',
            '" + ta7dier_body + @"',
            '" + ta7dier_notes + @"',
            '" + ta7dier_supervision_state_id + @"',
            '" + ta7dier_supervision_state_name + @"',
            '" + ta7dier_state_name + @"',
   '" + ta7dier_file + @"',
 '" + ta7dier_file_type + @"',
   '" + is_file + @"'


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
        public int update_ta7dier_master_for_state()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_ta7dier_master_for_state] 
            '" + ta7dier_id + @"',
            '" + ta7dier_state_id + @"'   
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
        public int delete_from_ta7dier_master()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_ta7dier_master]  
            '" + ta7dier_id + @"'
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
        public DataSet get_ta7dier_master_with_dep_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_ta7dier_master_with_dep_id]'" + dep_id + @"'", con_db.myCN);
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
        public DataSet get_ta7dier_master_for_dashboard()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_ta7dier_master_for_dashboard]'" + emp_id + @"'", con_db.myCN);
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
    }
}
