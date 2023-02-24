using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SonsOfMartyrsController : ControllerBase
    {
        private readonly ISonsOfMartyrsServices _sonsOfMartyrsServices;

        public SonsOfMartyrsController(ISonsOfMartyrsServices sonsOfMartyrsServices)
        {
            _sonsOfMartyrsServices = sonsOfMartyrsServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetSonsOfMartyrs()
        {
            return Ok(await _sonsOfMartyrsServices.GetSonsOfMartyrs());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSonOfMartyrsById(int id)
        {
            return Ok(await _sonsOfMartyrsServices.GetSonOfMartyrsById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveSonOfMartyrs(SonOfMartyrs student)
        {
            return Ok(await _sonsOfMartyrsServices.SaveSonOfMartyrs(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSonOfMartyrs(SonOfMartyrs student)
        {
            return Ok(await _sonsOfMartyrsServices.UpdateSonOfMartyrs(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSonOfMartyrs(int id)
        {
            return Ok(await _sonsOfMartyrsServices.DeleteSonOfMartyrs(id));
        }
    }
}
