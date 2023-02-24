using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class work_planController : ControllerBase
    {
        private readonly Iwork_planService _service;
        public work_planController(Iwork_planService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_work_plan()
        {
            var result = await _service.get_work_plan();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_work_plan_with_id(int id)
        {

            var result = await _service.get_work_plan_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_work_plan(work_plan work_plan)
        {
            var result = await _service.save_in_work_plan(work_plan);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_work_plan(work_plan work_plan)
        {
            var result = await _service.update_work_plan(work_plan);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_work_plan(int id)
        {


            var result = await _service.delete_from_work_plan(id);

            return Ok(result);
        }
    }
}
