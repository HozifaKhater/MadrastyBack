using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.SignalR;
using  BusinessLogic.Hubs;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ta7dier_master_stateController : Controller
    {
        private readonly IHubContext<AppNotificationHub> _hubContext;

        public ta7dier_master_stateController(IHubContext<AppNotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

      
        signalir_connections con_sig = new signalir_connections();
        ta7dier_master con_t7m = new ta7dier_master();
        public DataSet dataset1 { get; set; }
        [HttpPost]
        public async Task Post(ta7dier_master objta7dier_master)
        {
            con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
            con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
       
            con_t7m.update_ta7dier_master_for_state();
            try
            {
                con_sig.from_emp_id = objta7dier_master.emp_id;
                con_sig.route = objta7dier_master.route;
                con_sig.to_emp_id = objta7dier_master.to_emp_id;
                con_sig.object_id = Convert.ToInt32(objta7dier_master.ta7dier_id);
                DataSet list_of_cons = con_sig.send_notifications();
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
                    msg_date = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_date"],
                    object_id = Convert.ToInt32(objta7dier_master.ta7dier_id)
            });
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
            // return new JsonResult("Updated Successfully");
        }
    }
}
