using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using MadrastyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class teacher_opinion_visitController : ControllerBase
    {
        private readonly Iteacher_opinion_visitService _service;
        public teacher_opinion_visitController(Iteacher_opinion_visitService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_teacher_opinion_visit()
        {
            var result = await _service.get_teacher_opinion_visit();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_teacher_opinion_visit_with_id(int id)
        {
            
            var result = await _service.get_teacher_opinion_visit_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit)
        {
            var result = await _service.save_in_teacher_opinion_visit(teacher_opinion_visit);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> update_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit)
        {
            var result = await _service.update_teacher_opinion_visit(teacher_opinion_visit);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_teacher_opinion_visit(int id)
        {


            var result = await _service.delete_from_teacher_opinion_visit(id);

            return Ok(result);
        }
    }
}
