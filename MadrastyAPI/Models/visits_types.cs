using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{

    public class visits_types
    {
        [Key]

        public int visit_type_id { get; set; }
        public string visit_type_name { get; set; } = string.Empty;
        public int is_visit_date { get; set; }
        public string visit_date { get; set; } = string.Empty;
        public int is_phone { get; set; }
        public string phone_label { get; set; } = string.Empty;
        public int is_start_time { get; set; }
        public string start_time_label { get; set; } = string.Empty;
        public int is_end_time { get; set; }
        public string end_time_label { get; set; } = string.Empty;
        public int is_name { get; set; }
        public string name_label { get; set; } = string.Empty;
        public int is_topic { get; set; }
        public string topic_label { get; set; } = string.Empty;
        public int is_instructions { get; set; }
        public string instructions_label { get; set; } = string.Empty;
        public int is_job { get; set; }
        public string job_label { get; set; } = string.Empty;
        public int is_notes { get; set; }
        public string notes_label { get; set; } = string.Empty;
        public int is_dep { get; set; }
        public string dep_label { get; set; } = string.Empty;
        public int is_vnote { get; set; }
        public string vnote_label { get; set; } = string.Empty;
        public int is_vpic { get; set; }
        public string vpic_label { get; set; } = string.Empty;
        public int is_emp_from { get; set; }
        public string emp_from_label { get; set; } = string.Empty;
        public int is_emp_to { get; set; }
        public string emp_to_label { get; set; } = string.Empty;
        public int is_takeem { get; set; }
        public string takeem_label { get; set; } = string.Empty;




        public CLS_connection con_db = new CLS_connection();
    
     
        public DataSet get_visits_types()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_visits_types]", con_db.myCN);
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
        public DataSet get_visits_types_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_visits_types_with_id] '" + visit_type_id + @"'", con_db.myCN);
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
        public int save_in_visits_types()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_visits_types]  
         
                           '" + visit_type_name + @"',
                    '" + is_visit_date + @"',
                    '" + visit_date + @"',
                    '" + is_phone + @"',
                    '" + phone_label + @"',
                    '" + is_start_time + @"',
                    '" + start_time_label + @"',
                    '" + is_end_time + @"',
                    '" + end_time_label + @"',
                    '" + is_name + @"',
                    '" + name_label + @"',
                    '" + is_topic + @"',
                    '" + topic_label + @"',
                    '" + is_instructions + @"',
                    '" + instructions_label + @"',
                    '" + is_job + @"',
                    '" + job_label + @"',
                    '" + is_notes + @"',
                    '" + notes_label + @"',
                    '" + is_dep + @"',
                    '" + dep_label + @"',
                    '" + is_vnote + @"',
                    '" + vnote_label + @"',
                    '" + is_vpic + @"',
                    '" + vpic_label + @"',
                    '" + is_emp_from + @"',
                    '" + emp_from_label + @"',
                    '" + is_emp_to + @"',
                    '" + emp_to_label + @"',
                    '" + is_takeem + @"',
                    '" + takeem_label + @"'


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
        public int update_visits_types()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_visits_types]  
'" + visit_type_id + @"',
              '" + visit_type_name + @"',
                    '" + is_visit_date + @"',
                    '" + visit_date + @"',
                    '" + is_phone + @"',
                    '" + phone_label + @"',
                    '" + is_start_time + @"',
                    '" + start_time_label + @"',
                    '" + is_end_time + @"',
                    '" + end_time_label + @"',
                    '" + is_name + @"',
                    '" + name_label + @"',
                    '" + is_topic + @"',
                    '" + topic_label + @"',
                    '" + is_instructions + @"',
                    '" + instructions_label + @"',
                    '" + is_job + @"',
                    '" + job_label + @"',
                    '" + is_notes + @"',
                    '" + notes_label + @"',
                    '" + is_dep + @"',
                    '" + dep_label + @"',
                    '" + is_vnote + @"',
                    '" + vnote_label + @"',
                    '" + is_vpic + @"',
                    '" + vpic_label + @"',
                    '" + is_emp_from + @"',
                    '" + emp_from_label + @"',
                    '" + is_emp_to + @"',
                    '" + emp_to_label + @"',
                    '" + is_takeem + @"',
                    '" + takeem_label + @"'

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
        public int delete_from_visits_types()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_visits_types]  
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
        //public int update_department_def()
        //{
        //    int success_flag = 0;
        //    con_db.OpenDB_general();
        //    con_db.myDA = new SqlDataAdapter("Exec [update_department_def] '" + dep_id + @"','" + dep_name + @"'", con_db.myCN);
        //    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
        //    con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        //    DataSet myDS = new DataSet();
        //    //con_db.myDA.Fill(myDS);
        //    //department dep = new department();
        //    //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
        //    //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
        //    //dep.listdepartment.Add(dep);
        //    con_db.myCN.Close();

        //    return success_flag;

        //}
        //public int delete_from_department_def()
        //{
        //    int success_flag = 0;
        //    con_db.OpenDB_general();
        //    con_db.myDA = new SqlDataAdapter("Exec [delete_from_department_def] '" + dep_id + @"'", con_db.myCN);
        //    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
        //    con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        //    DataSet myDS = new DataSet();
        //    //con_db.myDA.Fill(myDS);
        //    //department dep = new department();
        //    //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
        //    //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
        //    //dep.listdepartment.Add(dep);
        //    con_db.myCN.Close();

        //    return success_flag;

        //}
    }
}
