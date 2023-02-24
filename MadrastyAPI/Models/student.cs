using  System;
using  System.Collections.Generic;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Models
{
    public class student 
    {
        public string start_year_date { get; set; } = String.Empty;
        public int student_id { get; set; }
        public int student_file_ser { get; set; }
        public string student_civilian_id { get; set; } = String.Empty;
        public string student_sex { get; set; } = String.Empty;
        public int student_sex_id { get; set; }
        public string student_name { get; set; } = String.Empty;
        public string student_nationality { get; set; } = String.Empty;
        public int student_nationality_id { get; set; }
        public string student_dob { get; set; } = String.Empty;
        public int student_age_year { get; set; }

        public int student_age_month { get; set; }
        public int student_age_day { get; set; }
        public int student_acceptance_reason_id { get; set; }
        public string student_acceptance_reason { get; set; } = String.Empty;
        public string student_religion { get; set; } = String.Empty;
        public int student_religion_id { get; set; }
        public string student_district { get; set; } = String.Empty;
        public int student_district_id { get; set; }
        public string student_school { get; set; } = String.Empty;
        public string student_stage { get; set; } = String.Empty;

        public int student_stage_id { get; set; }
        public string student_state { get; set; } = String.Empty;
        public int student_state_id { get; set; }
        public string student_study_state { get; set; } = String.Empty;
        public int student_study_state_id { get; set; }
        public string student_grade { get; set; } = String.Empty;

        public int student_grade_id { get; set; }
        public string student_div { get; set; } = String.Empty;
        public int student_div_id { get; set; }
        public int student_failure_years { get; set; }

        public int student_class_id { get; set; }
        public string student_class_name { get; set; } = String.Empty;

        public string student_branch { get; set; } = String.Empty;
        public int id { get; set; }

        public string level11 { get; set; } = String.Empty;

        public string level12 { get; set; } = String.Empty;

        public string student_branch_stat { get; set; } = String.Empty;

        public string  total_students { get; set; } = String.Empty;

        public string birth_cert_no { get; set; } = String.Empty;
        public int birth_cert_source_id { get; set; } 
        public string birth_cert_source { get; set; } = String.Empty;
        public string birth_cert_date { get; set; } = String.Empty;
        public int birth_location_id { get; set; }
        public string birth_location { get; set; } = String.Empty;
        public int gov_id { get; set; }
        public string gov_name { get; set; } = String.Empty;
        public int city_id { get; set; } 
        public string city_name { get; set; } = String.Empty;
        public int elkt3a { get; set; }
        public string street { get; set; } = String.Empty;
        public int elgada { get; set; } 
        public int building { get; set; } 
        public int build_level { get; set; } 
        public int apart_no { get; set; } 
        public string phone { get; set; } = String.Empty;
        public string name_in_english { get; set; } = String.Empty;
        public int guardian_relation_id { get; set; } 
        public string guardian_relation { get; set; } = String.Empty;
        public string guardian_civilian_id { get; set; } = String.Empty;
        public string guard_mobile { get; set; } = String.Empty;
        public string guardian_name { get; set; } = String.Empty;
        public string work_phone { get; set; } = String.Empty;
        public string work_name { get; set; } = String.Empty;
        public string job_name { get; set; } = String.Empty;
        public string email { get; set; } = String.Empty;
        public int guard_gov_id { get; set; } 
        public string guard_gov_name { get; set; } = String.Empty;
        public int guard_city_id { get; set; }
        public string guard_city_name { get; set; } = String.Empty;
        public int guard_kt3a { get; set; } 
        public string guard_street { get; set; } = String.Empty;
        public int guard_build { get; set; } 
        public int guard_build_level { get; set; } 
        public string guard_phone { get; set; } = String.Empty;
        public string mother_name { get; set; } = String.Empty;
        public string mother_civilian_id { get; set; } = String.Empty;
        public int mother_nat_id { get; set; }
        public string mother_nationality { get; set; } = String.Empty;
        public string mother_phone { get; set; } = String.Empty;
        public string mother_mobile { get; set; } = String.Empty;




        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public DataSet get_student_def()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_student_def]", con_db.myCN);
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

        public DataSet get_student_def_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_student_def_with_id]'" + student_id + @"'", con_db.myCN);
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

        public DataSet get_students_with_class_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_students_with_class_id]'" + student_class_id + @"'", con_db.myCN);
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
        public DataSet get_students_with_grade_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_students_with_grade_id]'" + student_grade_id + @"'", con_db.myCN);
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
        public int update_student_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_student_def] 
 '" + student_id + @"'	,
 '" + student_file_ser + @"'	,
 '" + student_civilian_id + @"'	,
 '" + student_sex + @"'	,
 '" + student_sex_id + @"'	,
 '" + student_name + @"'	,
 '" + student_nationality + @"'	,
 '" + student_nationality_id + @"'	,
 '" + student_dob + @"'	,
 '" + student_age_year + @"'	,
 '" + student_age_month + @"'	,
 '" + student_age_day + @"'	,
 '" + student_acceptance_reason_id + @"'	,
 '" + student_acceptance_reason + @"'	,
 '" + student_religion + @"'	,
 '" + student_religion_id + @"'	,
 '" + student_district + @"'	,
 '" + student_district_id + @"'	,
 '" + student_school + @"'	,
 '" + student_stage + @"'	,
 '" + student_stage_id + @"'	,
 '" + student_state + @"'	,
 '" + student_state_id + @"'	,
 '" + student_study_state + @"'	,
 '" + student_study_state_id + @"'	,
 '" + student_grade + @"'	,
 '" + student_grade_id + @"'	,
 '" + student_div + @"'	,
 '" + student_div_id + @"'	,
 '" + student_failure_years + @"',
 '" + student_class_id + @"',
 '" + student_class_name + @"',
'" +	birth_cert_no	+ @"'	,
'" +	birth_cert_source_id	+ @"'	,
'" +	birth_cert_source	+ @"'	,
'" +	birth_cert_date	+ @"'	,
'" +	birth_location_id	+ @"'	,
'" +	birth_location	+ @"'	,
'" +	gov_id	+ @"'	,
'" +	gov_name	+ @"'	,
'" +	city_id	+ @"'	,
'" +	city_name	+ @"'	,
'" +	elkt3a	+ @"'	,
'" +	street	+ @"'	,
'" +	elgada	+ @"'	,
'" +	building	+ @"'	,
'" +	build_level	+ @"'	,
'" +	apart_no	+ @"'	,
'" +	phone	+ @"'	,
'" +	name_in_english	+ @"'	,
'" +	guardian_relation_id	+ @"'	,
'" +	guardian_relation	+ @"'	,
'" +	guardian_civilian_id	+ @"'	,
'" +	guard_mobile	+ @"'	,
'" +	guardian_name	+ @"'	,
'" +	work_phone	+ @"'	,
'" +	work_name	+ @"'	,
'" +	job_name	+ @"'	,
'" +	email	+ @"'	,
'" +	guard_gov_id	+ @"'	,
'" +	guard_gov_name	+ @"'	,
'" +	guard_city_id	+ @"'	,
'" +	guard_city_name	+ @"'	,
'" +	guard_kt3a	+ @"'	,
'" +	guard_street	+ @"'	,
'" +	guard_build	+ @"'	,
'" +	guard_build_level	+ @"'	,
'" +	guard_phone	+ @"'	,
'" +	mother_name	+ @"'	,
'" +	mother_civilian_id	+ @"'	,
'" +	mother_nat_id	+ @"'	,
'" +	mother_nationality	+ @"'	,
'" +	mother_phone	+ @"'	,
'" +	mother_mobile	+ @"'	



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

        public int update_student_branch()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_student_branch] 
'" + student_id + @"',
 '" + student_branch + @"'	

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


        public int update_class_in_student()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_class_in_student] 
 '" + student_id + @"'	,

 '" + student_class_id + @"',	
 '" + student_class_name + @"'

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
        public int delete_from_student_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_student_def]  
            '" + student_id + @"'
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

        public int save_in_student_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_student_def]  
         
            '" + student_file_ser + @"',
            '" + student_civilian_id + @"',
            '" + student_sex + @"',
            '" + student_sex_id + @"',
            '" + student_name + @"',
            '" + student_nationality + @"',
            '" + student_nationality_id + @"',
            '" + student_dob + @"',
            '" + student_age_year + @"',
            '" + student_age_month + @"',
            '" + student_age_day + @"',
            '" + student_acceptance_reason_id + @"',
            '" + student_acceptance_reason + @"',
            '" + student_religion + @"',
            '" + student_religion_id + @"',
            '" + student_district + @"',
            '" + student_district_id + @"',
            '" + student_school + @"',
            '" + student_stage + @"',
            '" + student_stage_id + @"',
            '" + student_state + @"',
            '" + student_state_id + @"',
            '" + student_study_state + @"',
            '" + student_study_state_id + @"',
            '" + student_grade + @"',
            '" + student_grade_id + @"',
            '" + student_div + @"',
            '" + student_div_id + @"',
  '" + student_failure_years + @"',
 '" + student_class_id + @"',
 '" + student_class_name + @"',
'" +	birth_cert_no	+ @"'	,
'" +	birth_cert_source_id	+ @"'	,
'" +	birth_cert_source	+ @"'	,
'" +	birth_cert_date	+ @"'	,
'" +	birth_location_id	+ @"'	,
'" +	birth_location	+ @"'	,
'" +	gov_id	+ @"'	,
'" +	gov_name	+ @"'	,
'" +	city_id	+ @"'	,
'" +	city_name	+ @"'	,
'" +	elkt3a	+ @"'	,
'" +	street	+ @"'	,
'" +	elgada	+ @"'	,
'" +	building	+ @"'	,
'" +	build_level	+ @"'	,
'" +	apart_no	+ @"'	,
'" +	phone	+ @"'	,
'" +	name_in_english	+ @"'	,
'" +	guardian_relation_id	+ @"'	,
'" +	guardian_relation	+ @"'	,
'" +	guardian_civilian_id	+ @"'	,
'" +	guard_mobile	+ @"'	,
'" +	guardian_name	+ @"'	,
'" +	work_phone	+ @"'	,
'" +	work_name	+ @"'	,
'" +	job_name	+ @"'	,
'" +	email	+ @"'	,
'" +	guard_gov_id	+ @"'	,
'" +	guard_gov_name	+ @"'	,
'" +	guard_city_id	+ @"'	,
'" +	guard_city_name	+ @"'	,
'" +	guard_kt3a	+ @"'	,
'" +	guard_street	+ @"'	,
'" +	guard_build	+ @"'	,
'" +	guard_build_level	+ @"'	,
'" +	guard_phone	+ @"'	,
'" +	mother_name	+ @"'	,
'" +	mother_civilian_id	+ @"'	,
'" +	mother_nat_id	+ @"'	,
'" +	mother_nationality	+ @"'	,
'" +	mother_phone	+ @"'	,
'" +	mother_mobile	+ @"'

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
        public DataSet get_start_date_from_school_year_config()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_start_date_from_school_year_config]", con_db.myCN);
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
        public DataSet get_branch_stistics()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_branch_stistics]", con_db.myCN);
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
