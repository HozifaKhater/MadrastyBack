using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsServices _service;
        public NewsController(INewsServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetNews()
        {
            var result = await _service.GetNews();
            return Ok(result);
        }
    }
}
