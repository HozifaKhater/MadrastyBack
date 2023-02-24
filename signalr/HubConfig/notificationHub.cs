using Microsoft.AspNetCore.SignalR;


namespace signalr.HubConfig
{
    public class notificationHub : Hub
    {
        public async Task BroadcastChartData(string message, string connectionId) => 
            await Clients.Client(connectionId).SendAsync("broadcastchartdata", message);

        public string GetConnectionId() => Context.ConnectionId;
    }
}
