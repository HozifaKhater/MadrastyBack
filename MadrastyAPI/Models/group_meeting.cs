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
    public class group_meeting
    {
        [Key]

        public int group_id { get; set; }
        public string group_name { get; set; } = string.Empty;
        public int meeting_no { get; set; }
        public string meeting_date { get; set; } = string.Empty;
        public int meeting_mem_no { get; set; }
        public string meeting_loc { get; set; } = string.Empty;
        public string impor_recomm { get; set; } = string.Empty;
        public string bus_table { get; set; } = string.Empty;

        public int meeting_type_id { get; set; }
        public string meeting_type_name { get; set; } = string.Empty;
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int subject_id { get; set; }
        public string subject_name { get; set; } = string.Empty;
        public string course { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;
        public string route { get; set; } = string.Empty;



        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_group_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_group_meeting]  
         
            '" + group_name + @"',
            '" + meeting_no + @"',
            '" + meeting_date + @"',
           '" + meeting_mem_no + @"',
           '" + meeting_loc + @"',
         '" + impor_recomm + @"',
         '" + bus_table + @"',
       '" + meeting_type_id + @"',
            '" + meeting_type_name + @"',
            '" + dep_id + @"',
           '" + dep_name + @"',
           '" + subject_id + @"',
         '" + subject_name + @"',
         '" + course + @"',
   '" + content + @"'


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
        public DataSet get_group_meeting_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_group_meeting_with_id] '" + group_id + @"'", con_db.myCN);
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
        public DataSet get_group_meeting()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_group_meeting] ", con_db.myCN);
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
        public int update_group_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_group_meeting]  
           '" + group_id + @"',
            '" + group_name + @"',
            '" + meeting_no + @"',
            '" + meeting_date + @"',
   '" + meeting_mem_no + @"',
   '" + meeting_loc + @"',
 '" + impor_recomm + @"',
 '" + bus_table + @"',
 '" + meeting_type_id + @"',
            '" + meeting_type_name + @"',
            '" + dep_id + @"',
           '" + dep_name + @"',
           '" + subject_id + @"',
         '" + subject_name + @"',
         '" + course + @"',
 '" + content + @"'

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
        public int delete_from_group_meeting()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_group_meeting]  
            '" + group_id + @"'
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
