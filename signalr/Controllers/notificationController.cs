using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signalr.HubConfig;

namespace signalr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class notificationController : ControllerBase
    {
        private readonly IHubContext<notificationHub> _hub;
        //private readonly TimerManager _timer;

        //public ChartController(IHubContext<ChartHub> hub, TimerManager timer)
        //{
        //    _hub = hub;
        //    _timer = timer;
        //}

        public notificationController( IHubContext<notificationHub> hub)
        {
            _hub = hub;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string message) 
        { 
            await _hub.Clients.All.SendAsync(message);
            return Ok();
        }
    }
}
