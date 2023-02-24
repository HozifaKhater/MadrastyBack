using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{

    public class subject
    {
        [Key]

        public int subject_id { get; set; }
        public int emp_id { get; set; }
        [Required(ErrorMessage = "ادخل اسم الماده")]
        public string? subject_name { get; set; }
        public string? subject_desc { get; set; }

        public int emp_subject_id { get; set; }
        public string? emp_subject_name { get; set; }
        [Required(ErrorMessage = "ادخل اسم الفسم")]
        public int dep_id { get; set; }
        public int parent_id { get; set; } 
        public string? dep_name { get; set; }
        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public DataSet get_subject_def_with_class_id(int class_id, string date_day)
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_subject_def_with_class_id] '" + class_id + @"', '" +date_day+ @"'" , con_db.myCN);
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


        public DataSet get_subject_def()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_subject_def]", con_db.myCN);
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
        public DataSet get_subject_def_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_subject_def_with_id] '" + subject_id + @"'", con_db.myCN);
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
        public int save_in_subject_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_subject_def]  
         
            '" + subject_name + @"',
            '" + subject_desc + @"',
'" + dep_id + @"',
'" + dep_name + @"',
'" + parent_id + @"'

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
        public int update_subject_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_subject_def]  
           '" + subject_id + @"',
            '" + subject_name + @"',
            '" + subject_desc + @"',
'" + dep_id + @"',
'" + dep_name + @"',
'" + parent_id + @"'
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
        public int delete_from_subject_def()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_subject_def]  
            '" + subject_id + @"'
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
        public DataSet get_subject_with_emp_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_subject_with_emp_id] '" + emp_id + @"'", con_db.myCN);
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
        public DataSet get_subject_def_with_dep_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_subject_def_with_dep_id] '" + dep_id + @"'", con_db.myCN);
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
