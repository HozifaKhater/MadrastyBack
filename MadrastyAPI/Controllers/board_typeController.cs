using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class board_typeController : ControllerBase
    {
        private readonly Iboard_typeService _service;
        public board_typeController(Iboard_typeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_board_type()
        {
            var result = await _service.get_board_type();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_board_type_with_id(int id)
        {

            var result = await _service.get_board_type_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_board_type(board_type board_type)
        {
            var result = await _service.save_in_board_type(board_type);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_board_type(board_type board_type)
        {
            var result = await _service.update_board_type(board_type);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_board_type(int id)
        {


            var result = await _service.delete_from_board_type(id);

            return Ok(result);
        }
    }
}
