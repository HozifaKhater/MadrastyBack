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
    public class good_bad_students_card
    {
        [Key]

        public int student_card_id { get; set; }
        public int good_card_id { get; set; }
        public int bad_card_id { get; set; }
        public int grade_id { get; set; }
        public string? garde_name { get; set; }
        public int class_id { get; set; }
        public string? class_name { get; set; }
        public int subject_id { get; set; }
        public string? subject_name { get; set; }
        public int student_id { get; set; }
        public string? student_name { get; set; }
        public string? good_ebda3 { get; set; }
        public string? good_tahfeez { get; set; }
        public string? good_result { get; set; }
        public string? bad_da3f { get; set; }
        public string? bad_da3f_reasons { get; set; }
        public string? bad_cure_ways { get; set; }
        public string? bad_result { get; set; }

        public int civil_id { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public DataSet get_good_bad_students_card()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_good_bad_students_card]", con_db.myCN);
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
        public int save_in_good_bad_students_card()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_good_bad_students_card]  
         
            '" + good_card_id + @"',
            '" + bad_card_id + @"',
            '" + grade_id + @"',
            '" + garde_name + @"',
            '" + class_id + @"',
            '" + class_name + @"',
            '" + subject_id + @"',
            '" + subject_name + @"',
            '" + student_id + @"',
            '" + student_name + @"',
            '" + good_ebda3 + @"',
            '" + good_tahfeez + @"',
            '" + good_result + @"',
            '" + bad_da3f + @"',
            '" + bad_da3f_reasons + @"',
            '" + bad_cure_ways + @"',
            '" + bad_result + @"'


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

        public DataSet get_good_bad_students_card_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_good_bad_students_card_with_id]'" + student_card_id + @"'", con_db.myCN);
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

        public int update_good_bad_students_card()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_good_bad_students_card] 
 '" + student_card_id + @"',
 '" + good_card_id + @"',
 '" + bad_card_id + @"',
 '" + grade_id + @"',
 '" + garde_name + @"',
 '" + class_id + @"',
 '" + class_name + @"',
 '" + subject_id + @"',
 '" + subject_name + @"',
 '" + student_id + @"',
 '" + student_name + @"',
 '" + good_ebda3 + @"',
 '" + good_tahfeez + @"',
 '" + good_result + @"',
 '" + bad_da3f + @"',
 '" + bad_da3f_reasons + @"',
 '" + bad_cure_ways + @"',
 '" + bad_result + @"'

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

        public int update_bad_students_card()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_bad_students_card] 
 '" + student_card_id + @"',
 '" + good_card_id + @"',
 '" + bad_card_id + @"',
 '" + grade_id + @"',
 '" + garde_name + @"',
 '" + class_id + @"',
 '" + class_name + @"',
 '" + subject_id + @"',
 '" + subject_name + @"',
 '" + student_id + @"',
 '" + student_name + @"',
 '" + good_ebda3 + @"',
 '" + good_tahfeez + @"',
 '" + good_result + @"',
 '" + bad_da3f + @"',
 '" + bad_da3f_reasons + @"',
 '" + bad_cure_ways + @"',
 '" + bad_result + @"'

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

        public int delete_from_good_bad_students_card()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_good_bad_students_card]  
            '" + student_card_id + @"'
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
