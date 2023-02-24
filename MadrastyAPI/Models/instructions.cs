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
    public class instructions
    {
        [Key]
        public int ser { get; set; }
        public string level_name { get; set; } = string.Empty;
        public int level_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل الفصل ")]
        public int class_id { get; set; }
        public string topic { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل عدد افراد المجموعه ")]
        public int group_number { get; set; }
        [Required(ErrorMessage = "ادخل عدد الجلسات ")]
        public int sessions_number { get; set; }
        public string notes { get; set; } = string.Empty;
        public int type_id { get; set; }
        public string type_name { get; set; } = string.Empty;
        public CLS_connection con_db = new CLS_connection();
      

        public int save_in_instructions()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_instructions]  
         
 '" + level_name + @"',
 '" + level_id + @"',
 '" + class_name + @"',
 '" + class_id + @"',
 '" + topic + @"',
 '" + group_number + @"',
 '" + sessions_number + @"',
 '" + notes + @"',
 '" + type_name + @"',
 '" + type_id + @"'


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
        public DataSet get_instructions_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_instructions_with_id] '" + ser + @"'", con_db.myCN);
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
        public DataSet get_instructions()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_instructions] ", con_db.myCN);
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
        public int update_instructions()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_instructions]  
          '" + ser + @"',
 '" + level_name + @"',
 '" + level_id + @"',
 '" + class_name + @"',
 '" + class_id + @"',
 '" + topic + @"',
 '" + group_number + @"',
 '" + sessions_number + @"',
 '" + notes + @"',
 '" + type_name + @"',
 '" + type_id + @"'


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
        public int delete_from_instructions()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_instructions]  
            '" + ser + @"'
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
