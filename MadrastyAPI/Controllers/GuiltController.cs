using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GuiltController : ControllerBase
    {
        private readonly IGuiltServices _guiltServices;

        public GuiltController(IGuiltServices guiltServices)
        {
            _guiltServices = guiltServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetGuilts()
        {
            return Ok(await _guiltServices.GetGuilts());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetGuiltById(int id)
        {
            return Ok(await _guiltServices.GetGuiltById(id));
        }

        [HttpGet("student_id")]
        public async Task<IActionResult> GetGuiltByStudentId(int student_id)
        {
            return Ok(await _guiltServices.GetGuiltByStudentId(student_id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveGuilt(Guilt student)
        {
            return Ok(await _guiltServices.SaveGuilt(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGuilt(Guilt student)
        {
            return Ok(await _guiltServices.UpdateGuilt(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuilt(int id)
        {
            return Ok(await _guiltServices.DeleteGuilt(id));
        }
    }
}
