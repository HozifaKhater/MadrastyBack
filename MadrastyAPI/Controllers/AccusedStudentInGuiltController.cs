using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccusedStudentInGuiltController : Controller
    {
        private readonly IAccusedStudentsInGuiltService _accusedStudentInGuiltService;

        public AccusedStudentInGuiltController(IAccusedStudentsInGuiltService accusedStudentInGuiltService)
        {
            _accusedStudentInGuiltService = accusedStudentInGuiltService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccusedStudentsInGuilt()
        {
            return Ok(await _accusedStudentInGuiltService.GetAccusedStudentsInGuilt());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetAccusedStudentInGuiltById(int id)
        {
            return Ok(await _accusedStudentInGuiltService.GetAccusedStudentInGuiltById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveAccusedStudentInGuilt(accused_student_in_guilt student)
        {
            return Ok(await _accusedStudentInGuiltService.SaveAccusedStudentInGuilt(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccusedStudentInGuilt(accused_student_in_guilt student)
        {
            return Ok(await _accusedStudentInGuiltService.UpdateAccusedStudentInGuilt(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccusedStudentInGuilt(int id)
        {
            return Ok(await _accusedStudentInGuiltService.DeleteAccusedStudentInGuilt(id));
        }
    }
}
