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
    public class failure_cases
    {
        [Key]

        public int fail_id { get; set; }
        public string fail_lev { get; set; } = string.Empty;
        public string fail_class { get; set; } = string.Empty;
        public string fail_student { get; set; } = string.Empty;
        public string fail_nation { get; set; } = string.Empty;
        public int fail_mob { get; set; }
        public string fail_birth { get; set; } = string.Empty;
        public string fail_date { get; set; } = string.Empty;
        public string fail_desc { get; set; } = string.Empty;
        public string fail_reason { get; set; } = string.Empty;
        public string fail_sub { get; set; } = string.Empty;
        public int fail_1 { get; set; }
        public int fail_2 { get; set; }
        public int fail_3 { get; set; }
        public int fail_4 { get; set; }
        public int fail_end_year { get; set; }
        public string fail_sit { get; set; } = string.Empty;
        public string fail_eff_date { get; set; } = string.Empty;
        public string fail_eff_results { get; set; } = string.Empty;
        public string fail_recomm { get; set; } = string.Empty;
        public string student_name { get; set; } = string.Empty;
        
        public int civil_id { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_failure_cases()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_failure_cases]  

 '" + fail_lev + @"',
 '" + fail_class + @"',
 '" + fail_student + @"',
 '" + fail_nation + @"',
 '" + fail_mob + @"',
 '" + fail_birth + @"',
 '" + fail_date + @"',
 '" + fail_desc + @"',
 '" + fail_reason + @"',
 '" + fail_sub + @"',
 '" + fail_1 + @"',
 '" + fail_2 + @"',
 '" + fail_3 + @"',
 '" + fail_4 + @"',
 '" + fail_end_year + @"',
 '" + fail_sit + @"',
 '" + fail_eff_date + @"',
 '" + fail_eff_results + @"',
 '" + fail_recomm + @"'


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
        public DataSet get_failure_cases_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_failure_cases_with_id] '" + fail_id + @"'", con_db.myCN);
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

        public DataSet get_failure_cases()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_failure_cases] ", con_db.myCN);
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
        public int update_failure_cases()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_failure_cases]  
           '" + fail_id + @"',
 '" + fail_lev + @"',
 '" + fail_class + @"',
 '" + fail_student + @"',
 '" + fail_nation + @"',
 '" + fail_mob + @"',
 '" + fail_birth + @"',
 '" + fail_date + @"',
 '" + fail_desc + @"',
 '" + fail_reason + @"',
 '" + fail_sub + @"',
 '" + fail_1 + @"',
 '" + fail_2 + @"',
 '" + fail_3 + @"',
 '" + fail_4 + @"',
 '" + fail_end_year + @"',
 '" + fail_sit + @"',
 '" + fail_eff_date + @"',
 '" + fail_eff_results + @"',
 '" + fail_recomm + @"'

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
        public int delete_from_failure_cases()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_failure_cases]  
            '" + fail_id + @"'
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
