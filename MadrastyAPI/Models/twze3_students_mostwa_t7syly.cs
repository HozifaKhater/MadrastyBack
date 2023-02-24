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
    public class twze3_students_mostwa_t7syly
    {
        [Key]
        public int id { get; set; }
        public int level_id { get; set; }
        public string level_name { get; set; }
        public int first_term_fails { get; set; }
        public int second_term_fails { get; set; }
        public int academic_failure { get; set; }
        public int academic_excellence { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_twze3_students_mostwa_t7syly()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_twze3_students_mostwa_t7syly]  
         
          
 '" + level_id + @"',
 '" + level_name + @"',
 '" + first_term_fails + @"',
 '" + second_term_fails + @"',
 '" + academic_failure + @"',
 '" + academic_excellence + @"'


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
        //public DataSet get_delays_with_id()
        //{
        //    con_db.OpenDB_general();
        //    con_db.myDA = new SqlDataAdapter("Exec [get_delays_with_id] '" + delay_id + @"'", con_db.myCN);
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
        public DataSet get_levels_with_stistics()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_levels_with_stistics] ", con_db.myCN);
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
//        public int update_delays()
//        {
//            int success_flag = 0;
//            con_db.OpenDB_general();
//            con_db.myDA = new SqlDataAdapter(@"Exec [update_delays]  
//           '" + delay_id + @"',
//            '" + delay_date + @"',
//            '" + delay_emp_name + @"',
//            '" + time_attend + @"',
//            '" + delay_state + @"',
//'" + delay_emp_id + @"'

//            ", con_db.myCN);
//            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
//            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
//            // con_obj.myDT = New DataTable()
//            DataSet myDS = new DataSet();
//            con_db.myDA.Fill(myDS);
//            // con_obj.myDS.Tables.Add(con_obj.myDT)
//            con_db.myCN.Close();
//            return success_flag;
//        }
//        public int delete_from_delays()
//        {
//            int success_flag = 0;
//            con_db.OpenDB_general();
//            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_delays]  
//            '" + delay_id + @"'
//            ", con_db.myCN);
//            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
//            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
//            // con_obj.myDT = New DataTable()
//            DataSet myDS = new DataSet();
//            con_db.myDA.Fill(myDS);
//            // con_obj.myDS.Tables.Add(con_obj.myDT)
//            con_db.myCN.Close();
//            return success_flag;

//        }
    }
}
