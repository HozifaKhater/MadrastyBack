using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Student_transferController : ControllerBase
    {
        private readonly IStudent_transferService _service;
        public Student_transferController(IStudent_transferService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_student_transfer(Student_transfer studentrans)
        {
            var result = await _service.save_in_student_transfer(studentrans);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_student_transfer()
        {
            var result = await _service.get_student_transfer();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_student_transfer_with_id(int id)
        {
            var result = await _service.get_student_transfer_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_student_transfer(Student_transfer studentrans)
        {
            var result = await _service.update_student_transfer(studentrans);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_student_transfer(int id)
        {
            var result = await _service.delete_from_student_transfer(id);

            return Ok(result);
        }
    }
}
