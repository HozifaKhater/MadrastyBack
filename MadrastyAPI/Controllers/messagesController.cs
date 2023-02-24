using  BusinessLogic.Abstractions;
using  BusinessLogic.Hubs;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Microsoft.AspNetCore.SignalR;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class messagesController : ControllerBase
    {
       
        private readonly ImessagesService _service;
        private readonly IHubContext<AppNotificationHub> _hubContext;
        public messagesController(ImessagesService service, IHubContext<AppNotificationHub> hubContext)
        {
            _service = service;
            _hubContext = hubContext;
        }
        MadrastyAPI.Models.signalir_connections con_sig = new MadrastyAPI.Models.signalir_connections();
        [HttpGet]
        public async Task<IActionResult> get_inbox(int id)
        {

            var result = await _service.get_inbox(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_message_with_id(int id)
        {

            var result = await _service.get_message_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_messages(messages messages)
        {
            var result = await _service.save_in_messages(messages);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_messages_to_emp_id(messages messages)
        {
            var result = await _service.save_in_messages_to_emp_id(messages);
            try
            {
                con_sig.from_emp_id = messages.from_emp_id;
                con_sig.route = messages.route;
                con_sig.to_emp_id = messages.to_emp_id;
                con_sig.object_id = Convert.ToInt32(messages.msg_id);
                DataSet list_of_cons = con_sig.send_notifications_emails();
                List<string> data = new List<string>();
                foreach (DataRow row in list_of_cons.Tables[0].Rows)
                {
                    string value = row["connection_id"].ToString();
                    data.Add(value);
                }
                await _hubContext.Clients.Clients(data).SendAsync("GeneralNotification", new BusinessLogic.ViewModels.NotificationModel
                {
                    Body = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_body"],
                    Title = (string)list_of_cons.Tables[1].Rows[0][columnName: "title"],
                    IsRead = false,
                    object_id = Convert.ToInt32(messages.msg_id),
                    msg_date = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_date"],
                });
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> save_in_messages_files(messages messages)
        {
            var result = await _service.save_in_messages_files(messages);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_message_with_to_id(int id)
        {

            var result = await _service.get_message_with_to_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_messages_emails_to_emp_id_with_msg_id(int id)
        {

            var result = await _service.get_messages_emails_to_emp_id_with_msg_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_message_with_to_id_emails(int id)
        {

            var result = await _service.get_message_with_to_id_emails(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_message_with_to_id_noti(int id)
        {

            var result = await _service.get_message_with_to_id_noti(id);
            return Ok(result);
        }
    }
}
