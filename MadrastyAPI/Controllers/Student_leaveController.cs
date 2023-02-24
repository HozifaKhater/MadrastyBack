using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Student_leaveController : ControllerBase
    {
        private readonly IStudent_leaveService _service;
        public Student_leaveController(IStudent_leaveService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_student_leave(Student_leave studentleave)
        {
            var result = await _service.save_in_student_leave(studentleave);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_student_leave()
        {
            var result = await _service.get_student_leave();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_student_leave_with_id(int id)
        {
            var result = await _service.get_student_leave_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_student_leave(Student_leave studentleave)
        {
            var result = await _service.update_student_leave(studentleave);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_student_leave(int id)
        {
            var result = await _service.delete_from_student_leave(id);

            return Ok(result);
        }
    }
}
