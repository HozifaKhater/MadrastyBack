using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Absence_casesController : ControllerBase
    {
        private readonly IAbsence_casesService _service;
        public Absence_casesController(IAbsence_casesService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_absence_cases(Absence_cases absence_cases)
        {
            var result = await _service.save_in_absence_cases(absence_cases);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_absence_cases_details(absence_cases_details absence_cases)
        {
            var result = await _service.save_in_absence_cases_details(absence_cases);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_absence_cases()
        {
            var result = await _service.get_absence_cases();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_absence_cases_details()
        {
            var result = await _service.get_absence_cases_details();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_absence_cases_details_with_absence_cases_id(int id)
        {
            var result = await _service.get_absence_cases_details_with_absence_cases_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_absence_cases_details_with_id(int id)
        {
            var result = await _service.get_absence_cases_details_with_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_absence_cases_with_id(int id)
        {
            var result = await _service.get_absence_cases_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_absence_cases(Absence_cases absence_cases)
        {
            var result = await _service.update_absence_cases(absence_cases);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_absence_cases_details(absence_cases_details absence_cases)
        {
            var result = await _service.update_absence_cases_details(absence_cases);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_absence_cases(int id)
        {
            var result = await _service.delete_from_absence_cases(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_absence_cases_details(int id)
        {
            var result = await _service.delete_from_absence_cases_details(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_absence_cases_details_with_absence_cases_id(int id)
        {
            var result = await _service.delete_from_absence_cases_details_with_absence_cases_id(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_gdwel_7ss_with_emp_id_current_7sa(int id)
        {
            var result = await _service.get_gdwel_7ss_with_emp_id_current_7sa(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_absence_student(absence_student absence_student)
        {
            var result = await _service.save_in_absence_student(absence_student);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_statistics_absenec_for_dashboard_all_abs()
        {
            var result = await _service.get_statistics_absenec_for_dashboard_all_abs();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_statistics_absenec_for_dashboard_abs(int id)
        {
            var result = await _service.get_statistics_absenec_for_dashboard_abs(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_statistics_absenec_for_dashboard_all_att()
        {
            var result = await _service.get_statistics_absenec_for_dashboard_all_att();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_statistics_absenec_for_dashboard_att(int id)
        {
            var result = await _service.get_statistics_absenec_for_dashboard_att(id);
            return Ok(result);
        }
    }
}
