using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  System.Text.Json.Nodes;

namespace MadrastyAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class advertsController : ControllerBase
    {
        private readonly IadvertsService _service;
        public advertsController(IadvertsService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_adverts()
        {
            var result = await _service.get_adverts();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_adverts_with_id(int id)
        {

            var result = await _service.get_adverts_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_adverts(adverts adverts)
        {
            var result = await _service.save_in_adverts(adverts);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_adverts(adverts adverts)
        {
            var result = await _service.update_adverts(adverts);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_adverts(int id)
        {


            var result = await _service.delete_from_adverts(id);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> update_adverts_state(dynamic adverts)
        {
            var result = await _service.update_adverts_state(adverts.ser, adverts.state);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_adverts_for_dashboard(int is_public, int dep_id)
        {
            var result = await _service.get_adverts_for_dashboard(is_public, dep_id);
            return Ok(result);
        }
    }
}
