using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMS_Project.Models
{
    public class Login_Token 
    {
        public CLS_connection con_db = new CLS_connection();
     
 

        public bool post(Userclass user)
            {
            //user.username = "momen";
            //user.password = "password";
            int user_logged_id;
       
                    con_db.OpenDB_general();
            //'" + user.username + @"', '" + user.password + @"'
            con_db.myDA = new SqlDataAdapter("Exec [get_user_login_info] '" + user.username + @"', '" + user.password + @"','" + user.username + @"'", con_db.myCN);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
                    con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                    DataSet myDS = new DataSet();
                    con_db.myDA.Fill(myDS);
                  
             
                    con_db.myCN.Close();
                if (myDS.Tables[0].Rows.Count > 0)
                {
                    //  user_logged_id = Convert.ToInt32(myDS.Tables[0].Rows[0].ItemArray[0]);
                    user_logged_id =1;
                     var tokenhandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                    var keys = System.Text.Encoding.ASCII.GetBytes(con_db.get_token());
                    var tokendescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
                    {
                        Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name,"momen"),
                    new Claim(ClaimTypes.Role,"Admin"),
                    new Claim(ClaimTypes.Version,"v2.1")
                    }),
                        Expires = DateTime.UtcNow.AddHours(3),
                        SigningCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keys), Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokens = tokenhandler.CreateToken(tokendescriptor);

                    user.Token = tokenhandler.WriteToken(tokens);
                    user.password = null;
                    return user_logged_id == 1;

                }
                return false;

            }

        }
        
    
}

