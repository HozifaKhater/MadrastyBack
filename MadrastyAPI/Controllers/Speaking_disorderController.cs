using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Speaking_disorderController : ControllerBase
    {
        private readonly ISpeaking_disorderService _service;
        public Speaking_disorderController(ISpeaking_disorderService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_speaking_disorder(Speaking_disorder speaking_disorder)
        {
            var result = await _service.save_in_speaking_disorder(speaking_disorder);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_speaking_details_first(speaking_details_first speaking_disorder)
        {
            var result = await _service.save_in_speaking_details_first(speaking_disorder);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_speaking_details_second(speaking_details_second speaking_disorder)
        {
            var result = await _service.save_in_speaking_details_second(speaking_disorder);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_disorder()
        {
            var result = await _service.get_speaking_disorder();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_details_first()
        {
            var result = await _service.get_speaking_details_first();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_details_second()
        {
            var result = await _service.get_speaking_details_second();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_speaking_details_first_with_speech_dis_id(int id)
        {
            var result = await _service.get_speaking_details_first_with_speech_dis_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_details_second_with_speech_dis_id(int id)
        {
            var result = await _service.get_speaking_details_second_with_speech_dis_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_details_first_with_id(int id)
        {
            var result = await _service.get_speaking_details_first_with_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_details_second_with_id(int id)
        {
            var result = await _service.get_speaking_details_second_with_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_speaking_disorder_with_id(int id)
        {
            var result = await _service.get_speaking_disorder_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_speaking_disorder(Speaking_disorder speaking_disorder)
        {
            var result = await _service.update_speaking_disorder(speaking_disorder);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_speaking_details_first(speaking_details_first speaking_disorder)
        {
            var result = await _service.update_speaking_details_first(speaking_disorder);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_speaking_details_second(speaking_details_second speaking_disorder)
        {
            var result = await _service.update_speaking_details_second(speaking_disorder);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_speaking_disorder(int id)
        {
            var result = await _service.delete_from_speaking_disorder(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_speaking_details_first(int id)
        {
            var result = await _service.delete_from_speaking_details_first(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_speaking_details_second(int id)
        {
            var result = await _service.delete_from_speaking_details_second(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_speaking_details_first_with_speech_dis_id(int id)
        {
            var result = await _service.delete_from_speaking_details_first_with_speech_dis_id(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_speaking_details_second_with_speech_dis_id(int id)
        {
            var result = await _service.delete_from_speaking_details_second_with_speech_dis_id(id);

            return Ok(result);
        }
    }
}
