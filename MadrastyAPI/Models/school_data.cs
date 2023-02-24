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
    public class school_data
    {

        [Key]

        public int school_id { get; set; }
        [Required(ErrorMessage = "ادخل اسم المدير")]
        public string school_man { get; set; } = string.Empty;
        public string school_assis1 { get; set; } = string.Empty;
        public string school_assis2 { get; set; } = string.Empty;
        public string school_assis3 { get; set; } = string.Empty;
        public string school_assis4 { get; set; } = string.Empty;
        public string school_bdala { get; set; } = string.Empty;
        public string school_faks { get; set; } = string.Empty;
        public string school_addr { get; set; } = string.Empty;
        public string school_dir { get; set; } = string.Empty;
        public string school_logo { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل اسم المدرسه")]
        public string school_name { get; set; } = string.Empty;

        public int school_assis1_id { get; set; }
        public int school_assis2_id { get; set; }
        public int school_assis3_id { get; set; }
        public int school_assis4_id { get; set; }
        public int school_man_id { get; set; }


        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_school_data()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_school_data]  
         

 '" + school_man + @"',
 '" + school_assis1 + @"',
 '" + school_assis2 + @"',
 '" + school_assis3 + @"',
 '" + school_assis4 + @"',
 '" + school_bdala + @"',
 '" + school_faks + @"',
 '" + school_addr + @"',
 '" + school_dir + @"',
 '" + school_logo + @"',
 '" + school_name + @"',
 '" +	school_assis1_id	 + @"',
 '" +	school_assis2_id	 + @"',
 '" +	school_assis3_id	 + @"',
 '" +	school_assis4_id	 + @"',
 '" +	school_man_id	 + @"'


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
        public DataSet get_school_data_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_school_data_with_id] '" + school_id + @"'", con_db.myCN);
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
        public DataSet get_school_data()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_school_data] ", con_db.myCN);
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
        public int update_school_data()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_school_data]  
           '" + school_id + @"',
 '" + school_man + @"',
 '" + school_assis1 + @"',
 '" + school_assis2 + @"',
 '" + school_assis3 + @"',
 '" + school_assis4 + @"',
 '" + school_bdala + @"',
 '" + school_faks + @"',
 '" + school_addr + @"',
 '" + school_dir + @"',
 '" + school_logo + @"',
 '" + school_name + @"',
 '" +	school_assis1_id	 + @"',
 '" +	school_assis2_id	 + @"',
 '" +	school_assis3_id	 + @"',
 '" +	school_assis4_id	 + @"',
 '" +	school_man_id	 + @"'
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
        public int delete_from_school_data()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_school_data]  
            '" + school_id + @"'
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
