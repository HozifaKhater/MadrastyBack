using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  System.Data;
using  Microsoft.Data.SqlClient;

namespace MadrastyAPI.Models
{
    public class Ta7dierJoinEmployee
    {
       // public ta7dier_master ta7dier { get; set; }
       // public employee employee { get; set; }

        public int ta7dier_week { get; set; }
        public int ta7dier_day { get; set; }
        public string ta7dier_date { get; set; }
        public string ta7dier_name { get; set; }
        public string ta7dier_notes { get; set; }
        public string className { get; set; }
        public string lev_name { get; set; }
        public string emp_name { get; set; }
        public string emp_dep { get; set; }
        public string subject_name { get; set; }

        public CLS_connection con_db = new CLS_connection();

        public DataSet get_t7deer_with_dept_and_subj()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_t7deer_with_dept_and_subj]'" 
                + subject_name + @"',
               '" + emp_dep + @"'

            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);

            con_db.myCN.Close();
            return myDS;

        }
    }
}
