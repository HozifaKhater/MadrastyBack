using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Supervisor_opinionController : ControllerBase
    {
        private readonly ISupervisor_opinionService _service;
        public Supervisor_opinionController(ISupervisor_opinionService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_supervisor_opinion(Supervisor_opinion supervisoropin)
        {
            var result = await _service.save_in_supervisor_opinion(supervisoropin);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_supervisor_opinion()
        {
            var result = await _service.get_supervisor_opinion();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_supervisor_opinion_with_id(int id)
        {
            var result = await _service.get_supervisor_opinion_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_supervisor_opinion(Supervisor_opinion supervisoropin)
        {
            var result = await _service.update_supervisor_opinion(supervisoropin);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_supervisor_opinion(int id)
        {
            var result = await _service.delete_from_supervisor_opinion(id);

            return Ok(result);
        }
    }
}
