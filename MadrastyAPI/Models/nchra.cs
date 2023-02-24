using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace MadrastyAPI.Models
{
    public class nchra
    {
        [Key]


        public int nchra_id { get; set; }
        [Required(ErrorMessage = "ادخل  التاريخ")]
        public string nchra_date { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل المرسل")]
        public string nchra_sender { get; set; } = string.Empty;
        public string nchra_topic { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل محتوى النشره")]
        public string nchra_text { get; set; } = string.Empty;
        public int nchra_pages_num { get; set; }
        public string nchra_attach { get; set; } = string.Empty;
        public string? nachra_file_type { get; set; }
        public int is_file { get; set; }
        public int is_dep { get; set; }


        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();
        public DataSet get_nchra()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_nchra]", con_db.myCN);
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
        public int save_in_nchra()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_nchra]         
            '" + nchra_date + @"',
            '" + nchra_sender + @"',
            '" + nchra_topic + @"',
            '" + nchra_text + @"',
  '" + nchra_pages_num + @"',
            '" + nchra_attach + @"',
            '" + nachra_file_type + @"',
            '" + is_file + @"',
  '" + is_dep + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            success_flag = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_nchra_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_nchra_with_id]'" + nchra_id + @"'", con_db.myCN);
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

        public int update_nchra()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_nchra] 
             '" + nchra_id + @"',
            '" + nchra_date + @"',
            '" + nchra_sender + @"',
            '" + nchra_topic + @"',
            '" + nchra_text + @"' ,
  '" + nchra_pages_num + @"',
            '" + nchra_attach + @"',
            '" + nachra_file_type + @"',
            '" + is_file + @"',
 '" + is_dep + @"'
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
        public int delete_from_nchra()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_nchra]  
            '" + nchra_id + @"'
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
