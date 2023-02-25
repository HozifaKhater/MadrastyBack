using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  System.Data;
using  BusinessLogic.Abstractions;
using  Microsoft.AspNetCore.SignalR;
using  BusinessLogic.Hubs;
using BusinessLogic.Contexts;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ezonController : ControllerBase
    {

        private readonly IHubContext<AppNotificationHub> _hubContext;
        private readonly IDatabaseContext _db;

        public ezonController(IHubContext<AppNotificationHub> hubContext,IDatabaseContext db)
        {
            _hubContext = hubContext;
            _db = db;
        }

        ezon con_ezon = new ezon();
        employee con_employee = new employee();
        signalir_connections con_sig = new signalir_connections();

        public DataSet dataset1 { get; set; } = new DataSet();

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _db.ExecuteQuery("get_absent_premit_ezoon");
            return Ok(result.Data);
            //dataset1 = con_ezon.get_absent_premit_ezoon();
            //var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
            //                     select new ezon()
            //                     {
            //                         ezn_id = Convert.ToInt32(rw["ezn_id"]),
            //                         absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
            //                         premit_id = Convert.ToInt32(rw["premit_id"]),
            //                         emp_id = Convert.ToInt32(rw["emp_id"]),
            //                         ezn_date = Convert.ToString(rw["ezn_date"]),
            //                         ezn_reason = Convert.ToString(rw["ezn_reason"]),
            //                         time_from = Convert.ToString(rw["time_from"]),
            //                         time_to = Convert.ToString(rw["time_to"]),
            //                         ezn_state = Convert.ToInt32(rw["ezn_state"]),
            //                         emp_name = Convert.ToString(rw["emp_name"]),
            //                         civil_id = Convert.ToInt32(rw["civil_id"]),
            //                         emp_dep = Convert.ToString(rw["emp_dep"]),
            //                     }).ToList();

            //return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public async Task Post(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.emp_id = objaezon.emp_id;
            con_ezon.ezn_date = objaezon.ezn_date;
            con_ezon.ezn_reason = objaezon.ezn_reason;
            con_ezon.time_from = objaezon.time_from;
            con_ezon.time_to = objaezon.time_to;
          

         var ezn_id=   con_ezon.save_in_absent_premit_ezoon();

            // get connections from database
            // var result = _service.get_signalir_connections().Result;
            // get to person
            //if exist  send notification
            try
            {
                con_sig.from_emp_id = objaezon.emp_id;
                con_sig.route = objaezon.route;
                con_sig.to_emp_id = 0;
                con_sig.object_id = Convert.ToInt32(ezn_id);
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
                    object_id = Convert.ToInt32(ezn_id),
                    msg_date = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_date"],
                });
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
        }
        [HttpGet("id")]
        public List<ezon> Get(int id)
        {
            con_ezon.ezn_id = id;
            dataset1 = con_ezon.get_absent_premit_ezoon_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                 
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("emp_id")]
        public List<ezon> get_absent_premit_ezoon_with_emp_id(int emp_id)
        {
            con_ezon.emp_id = emp_id;
            dataset1 = con_ezon.get_absent_premit_ezoon_with_emp_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),
                                 }).ToList();

            return convertedList;
        }

        [HttpPut]
        public JsonResult Put(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.emp_id = objaezon.emp_id;
            con_ezon.ezn_date = objaezon.ezn_date;
            con_ezon.ezn_reason = objaezon.ezn_reason;
            con_ezon.time_from = objaezon.time_from;
            con_ezon.time_to = objaezon.time_to;

            //con_ezon.save_in_activity_def();
            con_ezon.update_absent_premit_ezoon();
            return new JsonResult("Updated Successfully");
        }
        //[HttpPut]
        //public JsonResult Put_state(ezon objaezon)
        //{
        //    con_ezon.ezn_id = objaezon.ezn_id;
        //    con_ezon.ezn_state = objaezon.ezn_state;
        //    //con_ezon.save_in_activity_def();
        //    con_ezon.update_absent_premit_ezoon_for_state();
        //    return new JsonResult("Updated Successfully");
        //}
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_ezon.ezn_id = id;
            con_ezon.delete_from_absent_premit_ezoon();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("get_absent_premit_ezoon_with_dep_id")]
        public List<ezon> get_absent_premit_ezoon_with_dep_id(int dep_id)
        {
            con_ezon.dep_id = dep_id;
            dataset1 = con_ezon.get_absent_premit_ezoon_with_dep_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                 }).ToList();

            return convertedList;
        }
    }
}
