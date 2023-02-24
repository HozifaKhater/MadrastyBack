using  BusinessLogic.Abstractions;
using  BusinessLogic.Implementations;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  Microsoft.AspNetCore.SignalR;
using  System.Threading.Tasks;

namespace MadrastyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class notificationController : ControllerBase
    {
        private readonly IHubContext<notification> _hubContext;

        public notificationController(IHubContext<notification> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post( string message)
        {
            // Call stored to get clients that will receive the notification
            await _hubContext.Clients.All.SendAsync("GeneralNotification", message);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            // code to retrieve messages from a data store
                var messages = "";
                return Ok(messages);
        }
    }
}
