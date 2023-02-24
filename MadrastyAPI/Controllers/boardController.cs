using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{

    [Route("api/[controller]/[action]")]

    [ApiController]
    public class boardController : ControllerBase
    {
        private readonly Iboard_service _service;
        public boardController(Iboard_service service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> get_board()
        {
            var result = await _service.get_board();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_board_with_id(int id)
        {

            var result = await _service.get_board_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_board(board board)
        {
            var result = await _service.save_in_board(board);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> update_board(board board)
        {
            var result = await _service.update_board(board);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_board(int id)
        {


            var result = await _service.delete_from_board(id);

            return Ok(result);
        }
    }
}
