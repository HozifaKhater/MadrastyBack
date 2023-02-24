using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class daily_absence_statController : ControllerBase
    {
        private readonly IDaily_absence_statService _service;
        public daily_absence_statController(IDaily_absence_statService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_daily_absence_stat(Daily_absence_stat dailystat)
        {
            var result = await _service.save_in_daily_absence_stat(dailystat);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_daily_absence_stat()
        {
            var result = await _service.get_daily_absence_stat();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_daily_absence_stat_with_id(int id)
        {
            var result = await _service.get_daily_absence_stat_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_daily_absence_stat(Daily_absence_stat dailystat)
        {
            var result = await _service.update_daily_absence_stat(dailystat);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_daily_absence_stat(int id)
        {


            var result = await _service.delete_from_daily_absence_stat(id);

            return Ok(result);
        }
    }
}
