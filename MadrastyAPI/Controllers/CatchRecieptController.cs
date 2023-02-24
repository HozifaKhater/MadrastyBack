using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatchRecieptController : ControllerBase
    {
        private readonly ICatchRecieptService _catchRecieptService;

        public CatchRecieptController(ICatchRecieptService catchRecieptService)
        {
            _catchRecieptService = catchRecieptService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCatchReciept()
        {
            return Ok(await _catchRecieptService.GetCatchReciept());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetCatchRecieptById(int id)
        {
            return Ok(await _catchRecieptService.GetCatchRecieptById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCatchReciept(catch_reciept reciept)
        {
            return Ok(await _catchRecieptService.SaveCatchReciept(reciept));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCatchReciept(catch_reciept reciept)
        {
            return Ok(await _catchRecieptService.UpdateCatchReciept(reciept));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatchReciept(int id)
        {
            return Ok(await _catchRecieptService.DeleteCatchReciept(id));
        }
    }
}
