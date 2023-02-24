using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SpecialStudentController : ControllerBase
    {
        private readonly ISpecialStudentServices _specilStudentServices;

        public SpecialStudentController(ISpecialStudentServices specilStudentServices)
        {
            _specilStudentServices = specilStudentServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpecialStudents()
        {
            return Ok(await _specilStudentServices.GetSpecialStudents());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSpecialStudentById(int id)
        {
            return Ok(await _specilStudentServices.GetSpecialStudentById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveSpecialStudent(SpecialStudent student)
        {
            return Ok(await _specilStudentServices.SaveSpecialStudent(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSpecialStudent(SpecialStudent student)
        {
            return Ok(await _specilStudentServices.UpdateSpecialStudent(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialStudent(int id)
        {
            return Ok(await _specilStudentServices.DeleteSpecialStudent(id));
        }
    }
}
