using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class meeting_typeController : ControllerBase
    {
        private readonly Imeeting_typeService _service;
        public meeting_typeController(Imeeting_typeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_meeting_type()
        {
            var result = await _service.get_meeting_type();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_meeting_type_with_id(int id)
        {

            var result = await _service.get_meeting_type_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_meeting_type(meeting_type meeting_type)
        {
            var result = await _service.save_in_meeting_type(meeting_type);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> update_meeting_type(meeting_type meeting_type)
        {
            var result = await _service.update_meeting_type(meeting_type);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_meeting_type(int id)
        {


            var result = await _service.delete_from_meeting_type(id);

            return Ok(result);
        }
    }
}
