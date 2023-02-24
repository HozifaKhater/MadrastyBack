using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Violation_recordController : ControllerBase
    {
        private readonly IViolation_recordService _service;
        public Violation_recordController(IViolation_recordService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_violation_record(violation_record viol)
        {
            var result = await _service.save_in_violation_record(viol);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_violation_record()
        {
            var result = await _service.get_violation_record();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_violation_record_with_id(int id)
        {
            var result = await _service.get_violation_record_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_violation_record(violation_record viol)
        {
            var result = await _service.update_violation_record(viol);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_violation_record(int id)
        {
            var result = await _service.delete_from_violation_record(id);

            return Ok(result);
        }
    }
}
