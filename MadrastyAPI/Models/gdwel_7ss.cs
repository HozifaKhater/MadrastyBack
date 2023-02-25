using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;
namespace MadrastyAPI.Models
{
    public class gdwel_7ss
    {
        [Key]

        public int id { get; set; }
        public int ser { get; set; }
        public string? title { get; set; }
        public string? start { get; set; }
        public string? end { get; set; }
        public string? className { get; set; }
        public string? replacement { get; set; }
        public int replacement_id { get; set; }
        public int emp_id { get; set; }
        public int subject_id { get; set; }
        public string? emp_name { get; set; }

        public int class_id { get; set; }
        public int level_id { get; set; }
        public int dep_id { get; set; }
        public string? class_name { get; set; }
        public string? lev_name { get; set; }
        public int is_late { get; set; }
        public int is_block { get; set; }
        public int position { get; set; }
        public string teacher { get; set; } = string.Empty;
        public string @class { get; set; } = string.Empty;
        public string level { get; set; } = string.Empty;
        public string eventtime { get; set; } = string.Empty;
        public string day { get; set; } = string.Empty;

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public DataSet get_gdwel_7ss()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss]", con_db.myCN);
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
        public DataSet get_gdwel_7ss_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_with_id] '" + id + @"'", con_db.myCN);
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
        public int save_in_gdwel_7ss()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_gdwel_7ss]  
         
            '" + title + @"',
             '" + start + @"',
  '" + end + @"',
  '" + className + @"',
'" + emp_id + @"',
'" + emp_name + @"',
'" + subject_id + @"',
'" + level_id + @"',
'" + class_id + @"'

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
        public int update_gdwel_7ss()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_gdwel_7ss]  
             '" + id + @"',
                        '" + title + @"',
             '" + start + @"',
  '" + end + @"',
  '" + className + @"',
'" + emp_id + @"',
'" + emp_name + @"',
'" + subject_id + @"',
'" + level_id + @"',
'" + class_id + @"'
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
        public int delete_from_gdwel_7ss()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_gdwel_7ss]  
            '" + id + @"'
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

        public DataSet get_gdwel_replacements_with_gdwel_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_replacements_with_gdwel_id] '" + id + @"'", con_db.myCN);
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
        public int save_in_gdwel_replacements()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_gdwel_replacements]  
         
            '" + id + @"',
             '" + replacement + @"',
  '" + replacement_id + @"'

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
        public int delete_from_gdwel_replacements_with_gdwel_id()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_gdwel_replacements_with_gdwel_id]  
            '" + id + @"'
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
        public DataSet get_gdwel_7ss_with_subject_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_with_subject_id] '" + subject_id + @"'", con_db.myCN);
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
        public DataSet get_gdwel_7ss_with_emp_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_with_emp_id] '" + emp_id + @"'", con_db.myCN);
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
        public DataSet get_gdwel_7ss_with_class_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_with_class_id] '" + class_id + @"'", con_db.myCN);
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
        public DataSet get_gdwel_7ss_with_dep_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_with_dep_id] '" + dep_id + @"'", con_db.myCN);
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
        public int update_gdwel_7ss_is_late()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_gdwel_7ss_is_late]'" + id + @"'", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public int update_gdwel_7ss_is_block()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_gdwel_7ss_is_block]'" + id + @"'", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_gdwel_7ss_new()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_new]", con_db.myCN);
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

        public DataSet get_gdwel_7ss_all()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_gdwel_7ss_all]", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            con_db.myCN.Close();
            return myDS;

        }
    }
}
