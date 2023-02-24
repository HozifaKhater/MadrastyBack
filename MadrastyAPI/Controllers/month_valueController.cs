using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class month_valueController : ControllerBase
    {
        private readonly Imonth_valueService _service;
        public month_valueController(Imonth_valueService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_month_value()
        {
            var result = await _service.get_month_value();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_month_value_with_id(int id)
        {

            var result = await _service.get_month_value_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_month_value(month_value month_value)
        {
            var result = await _service.save_in_month_value(month_value);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_month_value(month_value month_value)
        {
            var result = await _service.update_month_value(month_value);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_month_value(int id)
        {


            var result = await _service.delete_from_month_value(id);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> update_month_value_state(dynamic month_value)
        {
            var result = await _service.update_month_value_state(month_value.ser, month_value.state);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_month_value_for_dashboard()
        {
            var result = await _service.get_month_value_for_dashboard();
            return Ok(result);
        }
    }
}
