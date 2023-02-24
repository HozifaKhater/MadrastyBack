using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventsController : ControllerBase 
    {
        private readonly IEventsService _service;
        public EventsController(IEventsService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_events(Events events)
        {
            var result = await _service.save_in_events(events);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_events()
        {
            var result = await _service.get_events();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_events_with_id(int id)
        {
            var result = await _service.get_events_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_events(Events events)
        {
            var result = await _service.update_events(events);
            return Ok(result);
        }
   

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_events(int id)
        {


            var result = await _service.delete_from_events(id);

            return Ok(result);
        }
    }
}
