using  BusinessLogic.Abstractions;
using  BusinessLogic.Hubs;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.SignalR;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly IHubContext<AppNotificationHub> _notifier;

        public NotificationService(IHubContext<AppNotificationHub> notifier)
        {
            _notifier = notifier;
        }
        public async Task SendMessageToAll(NotificationModel model)
        {
            await _notifier.Clients.All.SendAsync("GeneralNotification", model);
        }
    }
}
