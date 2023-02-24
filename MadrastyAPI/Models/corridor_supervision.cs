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
    public class corridor_supervision
    {
        [Key]

        public int supervision_id { get; set; }
        [Required(ErrorMessage = "ادخل اسم الجناح")]
        public int corridor_id { get; set; }
        [Required(ErrorMessage = "ادخل اسم الموظف")]
        public int basic_emp_id { get; set; }
        public string basic_emp_name { get; set; } = string.Empty;
        public int spare_emp_id { get; set; }
        public string spare_emp_name { get; set; } = string.Empty;
        public string from_date { get; set; } = string.Empty;
        public string to_date { get; set; } = string.Empty;
        public string corridor_name { get; set; } = string.Empty;
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int emp_id { get; set; }
        public string emp_name { get; set; } = string.Empty;

        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public DataSet get_corridor_supervision()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_corridor_supervision]", con_db.myCN);
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
        public int save_in_corridor_supervision()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_corridor_supervision]  
         
         
'" + corridor_id + @"',
'" + basic_emp_id + @"',
'" + basic_emp_name + @"',
'" + spare_emp_id + @"',
'" + spare_emp_name + @"',
'" + from_date + @"',
'" + to_date + @"',
'" + corridor_name + @"',
'" + dep_id + @"',
'" + dep_name + @"',
'" + emp_id + @"',
'" + emp_name + @"'




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

        public DataSet get_corridor_supervision_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_corridor_supervision_with_id]'" + supervision_id + @"'", con_db.myCN);
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

        public int update_corridor_supervision()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_corridor_supervision] 
'" + supervision_id + @"',
'" + corridor_id + @"',
'" + basic_emp_id + @"',
'" + basic_emp_name + @"',
'" + spare_emp_id + @"',
'" + spare_emp_name + @"',
'" + from_date + @"',
'" + to_date + @"',
'" + corridor_name + @"',
'" + dep_id + @"',
'" + dep_name + @"',
'" + emp_id + @"',
'" + emp_name + @"'


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

        public int delete_from_corridor_supervision()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_corridor_supervision]  
            '" + supervision_id + @"'
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
