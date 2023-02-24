using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class calling_parentsController : ControllerBase
    {
        private readonly Icalling_parentsService _service;
        public calling_parentsController(Icalling_parentsService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_calling_parents()
        {
            var result = await _service.get_calling_parents();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_calling_parents_with_id(int id)
        {

            var result = await _service.get_calling_parents_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_calling_parents(calling_parents calling_parents)
        {
            var result = await _service.save_in_calling_parents(calling_parents);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_calling_parents(calling_parents calling_parents)
        {
            var result = await _service.update_calling_parents(calling_parents);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_calling_parents(int id)
        {


            var result = await _service.delete_from_calling_parents(id);

            return Ok(result);
        }
    }
}
