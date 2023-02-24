using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  BusinessLogic.Implementations;
using  System.Diagnostics.Metrics;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class userpriviliegesController : ControllerBase
    {
        private readonly IUserprivilegesService _service;

        public userpriviliegesController(IUserprivilegesService service)
        {
            _service = service;
        }
       

     

        public DataSet dataset { get; set; }


        [HttpPost]
        public async Task<IActionResult> save_in_emp_user_privliges(BusinessLogic.ViewModels.Userprivileges Userprivileges)
        {
            var result = await _service.save_in_emp_user_privliges(Userprivileges);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_users_with_menus(BusinessLogic.ViewModels.Userprivileges Userprivileges)
        {
            var result = await _service.save_in_users_with_menus(Userprivileges);
            return Ok(result);
        }



        [HttpGet]
        public async Task<IActionResult> get_emp_user_privliges()
        {
            var result = await _service.get_emp_user_privliges();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_users_with_menus()
        {
            var result = await _service.get_users_with_menus();
            return Ok(result);
        }

 

        [HttpGet]
        public async Task<IActionResult> get_emp_user_privliges_with_id(int id)
        {
            var result = await _service.get_emp_user_privliges_with_id(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_users_with_menus_with_id(int id)
        {
            var result = await _service.get_users_with_menus_with_id(id);
            return Ok(result);
        }

  

        [HttpGet]
        public async Task<IActionResult> get_emp_user_privliges_with_emp_id(int id)
        {
            var result = await _service.get_emp_user_privliges_with_emp_id(id);
            return Ok(result);
        }



        [HttpPut]
        public async Task<IActionResult> update_emp_user_privliges(BusinessLogic.ViewModels.Userprivileges Userprivileges)
        {
            var result = await _service.update_emp_user_privliges(Userprivileges);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_users_with_menus(BusinessLogic.ViewModels.Userprivileges Userprivileges)
        {
            var result = await _service.update_users_with_menus(Userprivileges);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> delete_from_emp_user_privliges(int id)
        {
            var result = await _service.delete_from_emp_user_privliges(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> delete_from_emp_user_privliges_one_priv(int id)
        {
            var result = await _service.delete_from_emp_user_privliges_one_priv(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> delete_from_users_with_menus(int id)
        {
            var result = await _service.delete_from_users_with_menus(id);
            return Ok(result);
        }





    }
}
