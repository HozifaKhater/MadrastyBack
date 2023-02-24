using  BusinessLogic.Abstractions;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class _7sa_defController : ControllerBase
    {
        private readonly I7sa_defService _service;
        public _7sa_defController(I7sa_defService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_7sa_def()
        {
            var result = await _service.get_7sa_def();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_7sa_def_with_id(int id)
        {

            var result = await _service.get_7sa_def_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_7sa_def(_7sa_def _7sa_def)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.save_in_7sa_def(_7sa_def);
                return Ok(result);
            }
            return Ok(new ServiceResponse(ModelState.Values.SelectMany(x=>x.Errors).Select(x=>x.ErrorMessage).ToList()));
            
        }

        [HttpPost]
        public async Task<IActionResult> update_7sa_def(_7sa_def _7sa_def)
        {
            var result = await _service.update_7sa_def(_7sa_def);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_7sa_def(int id)
        {


            var result = await _service.delete_from_7sa_def(id);

            return Ok(result);
        }
        }
    }

