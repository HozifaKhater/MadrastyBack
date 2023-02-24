using MadrastyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MadrastyAPI.Models
{
    public class employee
    {
        [Key]
        public int job_id { get; set; }
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int emp_id { get; set; }
        public string emp_civilian_id { get; set; } = string.Empty;
        public string emp_sex { get; set; } = string.Empty;
        public int emp_sex_id { get; set; } 
        public string emp_name { get; set; } = string.Empty;
        public string emp_nationality { get; set; } = string.Empty;
        public int emp_nationality_id { get; set; }
        public string emp_marital_status { get; set; } = string.Empty;
        public int emp_marital_status_id { get; set; }
        public int emp_file_ser { get; set; }
        public string emp_dob { get; set; } = string.Empty;
        public int emp_age_year { get; set; }

        public int emp_age_month { get; set; }
        public int emp_age_day { get; set; }
        public string emp_pos_type { get; set; } = string.Empty;
        public int emp_pos_type_id { get; set; }
        public string emp_pos { get; set; } = string.Empty;
        public int emp_pos_id { get; set; }
        public string emp_dep { get; set; } = string.Empty;
        public int emp_dep_id { get; set; }
        public string emp_subject { get; set; } = string.Empty;
        public int emp_subject_id { get; set; }
        public string emp_div { get; set; } = string.Empty;
        public int emp_div_id { get; set; }

        public string emp_contract { get; set; } = string.Empty;
        public int emp_contract_id { get; set; }
        public string emp_employment_date { get; set; } = string.Empty;
        public string emp_educationa_qualification { get; set; } = string.Empty;
        public int emp_educationa_qualification_id { get; set; }
        public string emp_educationa_qualification_date { get; set; } = string.Empty;
        public string emp_educationa_qualification_country { get; set; } = string.Empty;
        public int emp_educationa_qualification_country_id { get; set; }
        public int emp_exp_out_country { get; set; }
        public int emp_exp_in_country_same_grade { get; set; }
        public int emp_exp_in_country_another_grade { get; set; }
        public int emp_exp_in_country_same_school { get; set; }

        public string emp_address { get; set; } = string.Empty;
        public string emp_email { get; set; } = string.Empty;
        public string emp_mob { get; set; } = string.Empty;
        public string emp_mob1 { get; set; } = string.Empty;
        public string emp_tel { get; set; } = string.Empty;
        public string emp_username { get; set; } = string.Empty;
        public string emp_password { get; set; } = string.Empty;
        public int in_class_priv { get; set; }
        public int dep_work { get; set; }
        public int subject_id { get; set; }
        public string connection_id { get; set; } = string.Empty;
        public string start_date { get; set; } = string.Empty;

        public int relgion_id { get; set; }
        public string religion_name { get; set; } = string.Empty;

        public int emp_dep_parent { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        //public DataSet get_department_def()
        //{
        //    con_db.OpenDB_general();
        //    con_db.myDA = new SqlDataAdapter("Exec [get_master_departments]", con_db.myCN);
        //    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
        //    con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        //    DataSet myDS = new DataSet();
        //    con_db.myDA.Fill(myDS);
        //    //department dep = new department();
        //    //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
        //    //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
        //    //dep.listdepartment.Add(dep);
        //    con_db.myCN.Close();
        //    return myDS;

        //}


        public int save_in_emp_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_emp_def]  
         
            '" + emp_civilian_id + @"',
 '" + emp_sex + @"',
 '" + emp_sex_id + @"',
 '" + emp_name + @"',
 '" + emp_nationality + @"',
 '" + emp_nationality_id + @"',
 '" + emp_marital_status + @"',
 '" + emp_marital_status_id + @"',
 '" + emp_file_ser + @"',
 '" + emp_dob + @"',
 '" + emp_age_year + @"',
 '" + emp_age_month + @"',
 '" + emp_age_day + @"',
 '" + emp_pos_type + @"',
 '" + emp_pos_type_id + @"',
 '" + emp_pos + @"',
 '" + emp_pos_id + @"',
 '" + emp_dep + @"',
 '" + emp_dep_id + @"',
 '" + emp_subject + @"',
 '" + emp_subject_id + @"',
 '" + emp_div + @"',
 '" + emp_div_id + @"',
 '" + emp_contract + @"',
 '" + emp_contract_id + @"',
 '" + emp_employment_date + @"',
 '" + emp_educationa_qualification + @"',
 '" + emp_educationa_qualification_id + @"',
 '" + emp_educationa_qualification_date + @"',
 '" + emp_educationa_qualification_country + @"',
 '" + emp_educationa_qualification_country_id + @"',
 '" + emp_exp_out_country + @"',
 '" + emp_exp_in_country_same_grade + @"',
 '" + emp_exp_in_country_another_grade + @"',
 '" + emp_exp_in_country_same_school + @"',
 '" + emp_address + @"',
 '" + emp_email + @"',
 '" + emp_mob + @"',
 '" + emp_mob1 + @"',
 '" + emp_tel + @"',
 '" + emp_username + @"',
 '" + emp_password + @"',
 '" + in_class_priv + @"',
 '" + dep_work + @"',
 '" + relgion_id + @"',
 '" + religion_name + @"',
 '" + emp_dep_parent + @"'

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
        public int update_emp_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_emp_def]  
          '" + emp_id + @"',
            '" + emp_civilian_id + @"',
 '" + emp_sex + @"',
 '" + emp_sex_id + @"',
 '" + emp_name + @"',
 '" + emp_nationality + @"',
 '" + emp_nationality_id + @"',
 '" + emp_marital_status + @"',
 '" + emp_marital_status_id + @"',
 '" + emp_file_ser + @"',
 '" + emp_dob + @"',
 '" + emp_age_year + @"',
 '" + emp_age_month + @"',
 '" + emp_age_day + @"',
 '" + emp_pos_type + @"',
 '" + emp_pos_type_id + @"',
 '" + emp_pos + @"',
 '" + emp_pos_id + @"',
 '" + emp_dep + @"',
 '" + emp_dep_id + @"',
 '" + emp_subject + @"',
 '" + emp_subject_id + @"',
 '" + emp_div + @"',
 '" + emp_div_id + @"',
 '" + emp_contract + @"',
 '" + emp_contract_id + @"',
 '" + emp_employment_date + @"',
 '" + emp_educationa_qualification + @"',
 '" + emp_educationa_qualification_id + @"',
 '" + emp_educationa_qualification_date + @"',
 '" + emp_educationa_qualification_country + @"',
 '" + emp_educationa_qualification_country_id + @"',
 '" + emp_exp_out_country + @"',
 '" + emp_exp_in_country_same_grade + @"',
 '" + emp_exp_in_country_another_grade + @"',
 '" + emp_exp_in_country_same_school + @"',
 '" + emp_address + @"',
 '" + emp_email + @"',
 '" + emp_mob + @"',
 '" + emp_mob1 + @"',
 '" + emp_tel + @"',
 '" + emp_username + @"',
 '" + emp_password + @"',
 '" + in_class_priv + @"',
 '" + dep_work + @",
 '" + relgion_id + @"',
 '" + religion_name + @"',
 '" + emp_dep_parent + @"'
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
        public DataSet get_emp_def()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def] ", con_db.myCN);
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

        public DataSet get_emp_def_with_dep_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def_with_dep_id]'" + dep_id + @"'", con_db.myCN);
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

        public DataSet get_emp_def_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def_with_id]'" + emp_id + @"'", con_db.myCN);
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
        public int delete_from_emp_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_emp_def]  
            '" + emp_id + @"'
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
        public int update_emp_def_connection_id()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_emp_def_connection_id]  
         
            '" + emp_id + @"',
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
        public DataSet get_emp_def_with_job_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def_with_job_id]'" + job_id + @"'", con_db.myCN);
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
        public DataSet get_emp_def_with_subject_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def_with_subject_id]'" + subject_id + @"'", con_db.myCN);
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
        public DataSet get_emp_def_with_subject_id_with_validation()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_emp_def_with_subject_id_with_validation]'" + subject_id + @"','" + start_date + @"'", con_db.myCN);
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
