using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class swotController : ControllerBase
    {
        private readonly IswotService _service;
        public swotController(IswotService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_swot()
        {
            var result = await _service.get_swot();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_swot_with_id(int id)
        {

            var result = await _service.get_swot_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_swot(swot swot)
        {
            var result = await _service.save_in_swot(swot);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> update_swot(swot swot)
        {
            var result = await _service.update_swot(swot);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_swot(int id)
        {


            var result = await _service.delete_from_swot(id);

            return Ok(result);
        }
    }
}
