using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Health_casesController : ControllerBase
    {
        private readonly IHealth_casesService _service;
        public Health_casesController(IHealth_casesService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_health_cases(Health_cases health_cases)
        {
            var result = await _service.save_in_health_cases(health_cases);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_health_cases_details(health_cases_details health_cases)
        {
            var result = await _service.save_in_health_cases_details(health_cases);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_health_cases()
        {
            var result = await _service.get_health_cases();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_health_cases_details()
        {
            var result = await _service.get_health_cases_details();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_health_cases_details_with_health_id(int id)
        {
            var result = await _service.get_health_cases_details_with_health_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_health_cases_details_with_id(int id)
        {
            var result = await _service.get_health_cases_details_with_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_health_cases_with_id(int id)
        {
            var result = await _service.get_health_cases_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_health_cases(Health_cases health_cases)
        {
            var result = await _service.update_health_cases(health_cases);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_health_cases_details(health_cases_details health_cases)
        {
            var result = await _service.update_health_cases_details(health_cases);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_health_cases(int id)
        {
            var result = await _service.delete_from_health_cases(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_health_cases_details(int id)
        {
            var result = await _service.delete_from_health_cases_details(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_health_cases_details_with_health_id(int id)
        {
            var result = await _service.delete_from_health_cases_details_with_health_id(id);

            return Ok(result);
        }
    }
}
