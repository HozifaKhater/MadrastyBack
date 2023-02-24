using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.SignalR;
using  BusinessLogic.Hubs;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ezon_stateController : ControllerBase
    {
        private readonly IHubContext<AppNotificationHub> _hubContext;

        public ezon_stateController(IHubContext<AppNotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

   
        signalir_connections con_sig = new signalir_connections();
        ezon con_ezon = new ezon();
        public DataSet dataset1 { get; set; }
        [HttpPost]
        public async Task post(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.ezn_state = objaezon.ezn_state;
            //con_ezon.save_in_activity_def();
            con_ezon.update_absent_premit_ezoon_for_state();
            try
            {
                con_sig.from_emp_id = objaezon.emp_id;
                con_sig.route = objaezon.route;
                con_sig.to_emp_id = objaezon.to_emp_id;
                con_sig.object_id = Convert.ToInt32(objaezon.ezn_id);   
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
                    object_id = Convert.ToInt32(objaezon.ezn_id),
                msg_date = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_date"],
                });
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
          //  return new JsonResult("Updated Successfully");

        }
    }
}
