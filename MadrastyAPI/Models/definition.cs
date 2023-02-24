using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{
    public class definition
    {
        [Key]
        public int def_id { get; set; }
        public string def_name { get; set; }
        public string s_code { get; set; }
        public string s_code_arabic { get; set; }

        public CLS_connection con_db = new CLS_connection();

        public void save_in_definition()
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_definition] 
                '" + def_name + @"','" + s_code + @"','" + s_code_arabic + @"'", con_db.myCN);

            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            con_db.myDA.Fill(new DataSet());

            con_db.myCN.Close();

        }


        public void update_definition()
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"EXEC [update_definition]
                '" + def_id + @"','" + def_name + @"','" +  s_code + @"','" + s_code_arabic + @"'",con_db.myCN);
           
            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            con_db.myDA.Fill(new DataSet());

            con_db.myCN.Close();
        }
      

        public void delete_definition()
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"EXEC [delete_from_definition]
                '" + def_id + @"'", con_db.myCN );

            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            con_db.myDA.Fill(new DataSet());

            con_db.myCN.Close();
        }

        public DataSet getDefinitions()
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"EXEC [get_definitions]", con_db.myCN);
            
            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet definitions = new DataSet();

            con_db.myDA.Fill(definitions);

            con_db.myCN.Close();

            return definitions;

        }

        public DataSet getDistinctScodes()
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"EXEC [get_s_code_arabic_from_definitions]", con_db.myCN);

            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet definitions = new DataSet();

            con_db.myDA.Fill(definitions);

            con_db.myCN.Close();

            return definitions;

        }

        public DataSet getDefinitionsWithID(int id)
        {
            con_db.OpenDB_general();

            con_db.myDA = new SqlDataAdapter(@"EXEC [get_definitions_with_id]'" + id + @"'", con_db.myCN);

            new SqlCommandBuilder(con_db.myDA);

            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet definitions = new DataSet();

            con_db.myDA.Fill(definitions);

            con_db.myCN.Close();

            return definitions;

        }

    }
}
