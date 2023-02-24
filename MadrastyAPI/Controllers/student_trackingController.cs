using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class student_trackingController : ControllerBase
    {
        private readonly Istudent_trackingService _service;
        public student_trackingController(Istudent_trackingService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_update_student_tracking(student_tracking student_tracking)
        {
            var result = await _service.save_update_student_tracking(student_tracking);
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> get_student_tracking(student_tracking student_tracking)
        {
            var result = await _service.get_student_tracking(student_tracking);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> get_student_tracking_with_date_and_classid(student_tracking student_tracking)
        {
            var result = await _service.get_student_tracking_with_date_and_classid(student_tracking);
            return Ok(result);
        }
    }
}
