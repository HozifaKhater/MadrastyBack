using  Microsoft.AspNetCore.Mvc;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Threading.Tasks;
using  System.IdentityModel.Tokens.Jwt;
using  System.Security.Claims;
using  System.Text;
using  Microsoft.AspNetCore.Authorization;

using  Microsoft.Extensions.Configuration;
using  Microsoft.IdentityModel.Tokens;
using  MadrastyAPI.Models;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        Login_Token login = new Login_Token();
        Userclass con_user = new Userclass();
  
        public DataSet dataset { get; set; }
        [HttpPost]
        public IActionResult Post(Userclass user)
        
        {
            con_user.username = user.username;
            con_user.password = user.password;

            if (login.post(user) > 0)
            { return Ok(user); }
            else
            { return BadRequest(new { message = "Not valid UserName" }); }
          

        }
        [HttpGet("get_emp_user_privliges_menus_route")]
        public List<Login_Token> Get(int id)
        {
            login.emp_id = id;
            dataset = login.get_emp_user_privliges_menus_route();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new Login_Token()
                                 {

                                     menu_route = Convert.ToString(rw["menu_route"]),
                                      read = Convert.ToInt32(rw["read"]),
                                       read_and_write = Convert.ToInt32(rw["read_and_write"]),
                                        write = Convert.ToInt32(rw["write"])


                                 }).ToList();

            return convertedList;
        }
        [HttpPost("get_emp_user_privliges_menus_route_with_route")]
        public List<Login_Token> get_emp_user_privliges_menus_route_with_route(Login_Token login)
        {
            login.emp_id = login.emp_id;
            login.menu_route = login.menu_route;
            dataset = login.get_emp_user_privliges_menus_route_with_route();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new Login_Token()
                                 {

                                  
                                     read = Convert.ToInt32(rw["read"]),
                                     read_and_write = Convert.ToInt32(rw["read_and_write"]),
                                     write = Convert.ToInt32(rw["write"])


                                 }).ToList();

            return convertedList;
        }


    }
}
