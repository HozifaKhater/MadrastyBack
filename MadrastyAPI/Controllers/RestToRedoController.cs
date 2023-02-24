using  BusinessLogic.Abstractions;
using  BusinessLogic.Implementations;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestToRedoController : ControllerBase
    {
        private readonly IRestToRedoService _restToRedoService;

        public RestToRedoController(IRestToRedoService restToRedoService)
        {
            _restToRedoService = restToRedoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRestToRedo()
        {
            return Ok(await _restToRedoService.GetRestToRedo());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetRestToRedoById(int id)
        {
            return Ok(await _restToRedoService.GetRestToRedoById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveRestToRedo(rest_to_redo student)
        {
            return Ok(await _restToRedoService.SaveRestToRedo(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRestToRedo(rest_to_redo student)
        {
            return Ok(await _restToRedoService.UpdateRestToRedo(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestToRedo(int id)
        {
            return Ok(await _restToRedoService.DeleteRestToRedo(id));
        }


    }
}
