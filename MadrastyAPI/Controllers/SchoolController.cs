using  BusinessLogic.Abstractions;
using  BusinessLogic.Implementations;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolServices _schoolServices;

        public SchoolController(ISchoolServices schoolServices)
        {
            _schoolServices = schoolServices;
        }

        [HttpPost]
        public async Task<IActionResult> SaveSchool(School school)
        {
            return Ok(await _schoolServices.SaveSchool(school));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSchool(School school)
        {
            return Ok(await _schoolServices.UpdateSchool(school));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchool(int id)
        {
            return Ok(await _schoolServices.DeleteSchool(id));
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            return Ok(await _schoolServices.GetAllSchools());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            return Ok(await _schoolServices.GetSchoolById(id));
        }
    }
}
