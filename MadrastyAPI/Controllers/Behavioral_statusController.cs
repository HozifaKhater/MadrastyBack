using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Behavioral_statusController : ControllerBase
    {
        private readonly IBehavioral_statusService _service;
        public Behavioral_statusController(IBehavioral_statusService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_behavioral_status(Behavioral_status behave)
        {
            var result = await _service.save_in_behavioral_status(behave);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_behavioral_status()
        {
            var result = await _service.get_behavioral_status();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_behavioral_status_with_id(int id)
        {
            var result = await _service.get_behavioral_status_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_behavioral_status(Behavioral_status behave)
        {
            var result = await _service.update_behavioral_status(behave);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_behavioral_status(int id)
        {
            var result = await _service.delete_from_behavioral_status(id);

            return Ok(result);
        }
    }
}
