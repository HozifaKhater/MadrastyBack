using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class student_status_behaviour_reportController : ControllerBase
    {
        private readonly Istudent_status_behaviour_reportService _service;
        public student_status_behaviour_reportController(Istudent_status_behaviour_reportService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_student_status_behaviour_report()
        {
            var result = await _service.get_student_status_behaviour_report();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_student_status_behaviour_report_with_id(int id)
        {

            var result = await _service.get_student_status_behaviour_report_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_student_status_behaviour_report(student_status_behaviour_report student_status_behaviour_report)
        {
            var result = await _service.save_in_student_status_behaviour_report(student_status_behaviour_report);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_student_status_behaviour_report(student_status_behaviour_report student_status_behaviour_report)
        {
            var result = await _service.update_student_status_behaviour_report(student_status_behaviour_report);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_student_status_behaviour_report(int id)
        {


            var result = await _service.delete_from_student_status_behaviour_report(id);

            return Ok(result);
        }
    }
}
