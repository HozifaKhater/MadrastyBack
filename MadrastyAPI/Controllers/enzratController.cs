using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class enzratController : ControllerBase
    {
        private readonly IenzratService _service;
        public enzratController(IenzratService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_enzrat()
        {
            var result = await _service.get_enzrat();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_enzrat_with_id(int id)
        {

            var result = await _service.get_enzrat_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_enzrat(enzrat enzrat)
        {
            var result = await _service.save_in_enzrat(enzrat);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_enzrat(enzrat enzrat)
        {
            var result = await _service.update_enzrat(enzrat);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_enzrat(int id)
        {


            var result = await _service.delete_from_enzrat(id);

            return Ok(result);
        }
      
       
    }
}
