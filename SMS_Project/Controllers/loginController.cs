using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMS_Project.Models;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        Login_Token login = new Login_Token();
        Userclass con_user = new Userclass();
        [HttpPost]
        public IActionResult Post(Userclass user)
        
        {
            con_user.username = user.username;
            con_user.password = user.password;
          
            if (login.post(user))
                return Ok(user);

            return BadRequest(new { message = "Not valid UserName" });

        }

    

}
}
