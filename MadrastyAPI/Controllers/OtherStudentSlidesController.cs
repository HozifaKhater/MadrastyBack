using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OtherStudentSlidesController : ControllerBase
    {
        private readonly IOtherStudentSlidesServices _otherStudentSlidesServices;

        public OtherStudentSlidesController(IOtherStudentSlidesServices otherStudentSlidesServices)
        {
            _otherStudentSlidesServices = otherStudentSlidesServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetOtherStudentSlides()
        {
            return Ok(await _otherStudentSlidesServices.GetOtherStudentSlides());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetOtherStudentSlidesById(int id)
        {
            return Ok(await _otherStudentSlidesServices.GetOtherStudentSlidesById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveOtherStudentSlides(OtherStudentSlides student)
        {
            return Ok(await _otherStudentSlidesServices.SaveOtherStudentSlides(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOtherStudentSlides(OtherStudentSlides student)
        {
            return Ok(await _otherStudentSlidesServices.UpdateOtherStudentSlides(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOtherStudentSlides(int id)
        {
            return Ok(await _otherStudentSlidesServices.DeleteOtherStudentSlides(id));
        }
    }
}
