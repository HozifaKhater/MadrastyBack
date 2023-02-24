using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_Project.Models
{
 
    public class activity
    {
        [Key]

        public int activity_id { get; set; }
        public string activity_name { get; set; }
        public string activity_dep { get; set; }
        public string activity_school_year { get; set; }
        public int activity_school_year_id { get; set; }
        public string activity_level { get; set; }
        public string activity_date { get; set; }
        public string activity_school_term { get; set; }
        public string activity_notes { get; set; }


        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public DataSet get_activity_def()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_activity_def]", con_db.myCN);
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
        public int save_in_activity_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_activity_def]  
            
            '" + activity_name + @"',
            '" + activity_dep + @"',
            '" + activity_school_year + @"',
  '" + activity_school_year_id + @"',
            '" + activity_level + @"',
            '" + activity_date + @"',
            '" + activity_school_term + @"',
            '" + activity_notes + @"'
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
        public DataSet get_activity_def_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_activity_def_with_id]'" + activity_id + @"'", con_db.myCN);
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

        public int update_activity_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_activity_def] 
  '" + activity_id + @"',
            '" + activity_name + @"',
            '" + activity_dep + @"',
            '" + activity_school_year + @"',
  '" + activity_school_year_id + @"',
            '" + activity_level + @"',
            '" + activity_date + @"',
            '" + activity_school_term + @"',
            '" + activity_notes + @"'
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
        public int delete_from_activity_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_activity_def]  
            '" + activity_id + @"'
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
