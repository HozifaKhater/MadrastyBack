using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{
    public class trips
    {
        [Key]

        public int trip_id { get; set; }
        [Required(ErrorMessage = "ادخل القسم المسؤول")]
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل المشرف الاول")]
        public int emp_id { get; set; }
        public string emp_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل مكان الزياره")]
        public string trip_loc { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل تاريخ الزياره")]
        public string trip_date { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل وقت الزياره")]
        public string trip_time { get; set; } = string.Empty;
        public string trip_duration { get; set; } = string.Empty;
        public string trip_goals { get; set; } = string.Empty;
        public string trip_notes { get; set; } = string.Empty;
        public int ser { get; set; }
     
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public int student_number { get; set; }
        public int trip_type { get; set; }
        public int transportation_type { get; set; }
        public int level_id { get; set; }
        public int class_id { get; set; }

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public DataSet get_trips()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_trips]", con_db.myCN);
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
        public int save_in_trips()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_trips]  
           '" + dep_id + @"',
 '" + dep_name + @"',
 '" + emp_id + @"',
 '" + emp_name + @"',
 '" + trip_loc + @"',
 '" + trip_date + @"',
 '" + trip_time + @"',
 '" + trip_duration + @"',
 '" + trip_goals + @"',
 '" + trip_notes + @"',
 '" +	student_number	 + @"',
 '" +	trip_type	 + @"',
 '" +	transportation_type	 + @"',
 '" +	class_id	 + @"',
 '" +	level_id	 + @"'


            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_trips_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_trips_with_id]'" + trip_id + @"'", con_db.myCN);
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

        public int update_trips()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_trips] 
  '" + trip_id + @"',
 '" + dep_id + @"',
 '" + dep_name + @"',
 '" + emp_id + @"',
 '" + emp_name + @"',
 '" + trip_loc + @"',
 '" + trip_date + @"',
 '" + trip_time + @"',
 '" + trip_duration + @"',
 '" + trip_goals + @"',
 '" + trip_notes + @"',
 '" +	student_number	 + @"',
 '" +	trip_type	 + @"',
 '" +	transportation_type	 + @"',
 '" +	class_id	 + @"',
 '" +	level_id	 + @"'

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
        public int delete_from_trips()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_trips]  
            '" + trip_id + @"'
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
        public int save_in_trip_details()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_trip_details]  
       
 '" + trip_id + @"',
 '" + student_id + @"',
 '" + student_name + @"'


            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
           // success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public int delete_from_trip_details_with_trip_id()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_trip_details_with_trip_id]  
            '" + trip_id + @"'
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

        public DataSet get_trip_details_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_trip_details_with_id]'" + ser + @"'", con_db.myCN);
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
        public DataSet get_trip_details_with_trip_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_trip_details_with_trip_id]'" + trip_id + @"'", con_db.myCN);
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
