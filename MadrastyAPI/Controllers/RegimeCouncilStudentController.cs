using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegimeCouncilStudentController : ControllerBase
    {
        private readonly IRegimeCouncilStudentServices _regimeCouncilStudentServices;

        public RegimeCouncilStudentController(IRegimeCouncilStudentServices regimeCouncilStudentServices)
        {
            _regimeCouncilStudentServices = regimeCouncilStudentServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegimeCouncilStudents()
        {
            return Ok(await _regimeCouncilStudentServices.GetRegimeCouncilStudents());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetRegimeCouncilStudentById(int id)
        {
            return Ok(await _regimeCouncilStudentServices.GetRegimeCouncilStudentById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveRegimeCouncilStudent(RegimeCouncilStudent student)
        {
            return Ok(await _regimeCouncilStudentServices.SaveRegimeCouncilStudent(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRegimeCouncilStudent(RegimeCouncilStudent student)
        {
            return Ok(await _regimeCouncilStudentServices.UpdateRegimeCouncilStudent(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegimeCouncilStudent(int id)
        {
            return Ok(await _regimeCouncilStudentServices.DeleteRegimeCouncilStudent(id));
        }
    }
}
