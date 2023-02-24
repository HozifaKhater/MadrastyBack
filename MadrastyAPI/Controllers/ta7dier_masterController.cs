using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  BusinessLogic.Abstractions;
using  Microsoft.AspNetCore.SignalR;
using  BusinessLogic.Hubs;
using BusinessLogic.ViewModels;
using employee = MadrastyAPI.Models.employee;
using ta7dier_master = MadrastyAPI.Models.ta7dier_master;
using signalir_connections = MadrastyAPI.Models.signalir_connections;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ta7dier_masterController : ControllerBase
    {

        /*
         private readonly ITa7dierService _ta7dierService;

         public ta7dier_masterController(ITa7dierService ta7dierService)
         {
             _ta7dierService = ta7dierService;
         }

         [HttpGet]
         public async Task<IActionResult> GetTa7diers()
         {
             // not done
             return Ok(await _ta7dierService.GetTa7diers());
         }

         [HttpGet("id")]
         public async Task<IActionResult> GetTa7dierById(int id)
         {
             return Ok(await _ta7dierService.GetTa7dierById(id));
         }

         [HttpPost]
         public async Task<IActionResult> SaveTa7dier(ta7dier_master ta7dier)
         {
             return Ok(await _ta7dierService.SaveTa7dier(ta7dier));
         }

         [HttpPut]
         public async Task<IActionResult> UpdateTa7dier(ta7dier_master ta7dier)
         {
             return Ok(await _ta7dierService.UpdateTa7dier(ta7dier));
         }

         [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteTa7dier(int id)
         {
             return Ok(await _ta7dierService.DeleteTa7dier(id));
         }

         [HttpGet("subject_id")]
         public async Task<IActionResult> GetTa7dierBySubjectId(int subject_id)
         {
             return Ok(await _ta7dierService.GetTa7dierBySubjectId(subject_id));
         }
        */
        private readonly IHubContext<AppNotificationHub> _hubContext;

        public ta7dier_masterController(IHubContext<AppNotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        ezon con_ezon = new ezon();
        employee con_employee = new employee();
        signalir_connections con_sig = new signalir_connections();

        ta7dier_master con_t7m = new ta7dier_master();
           public DataSet dataset1 { get; set; }
        [HttpPost]
        public async Task Post(ta7dier_master objta7dier_master)
        {
            con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
            con_t7m.emp_id = objta7dier_master.emp_id;
            con_t7m.emp_name = objta7dier_master.emp_name;
            con_t7m.subject_id = objta7dier_master.subject_id;
            con_t7m.subject_name = objta7dier_master.subject_name;
            con_t7m.grade_id = objta7dier_master.grade_id;
            con_t7m.grade_name = objta7dier_master.grade_name;
            con_t7m.ta7dier_date = objta7dier_master.ta7dier_date;
            con_t7m.ta7dier_week = objta7dier_master.ta7dier_week;
            con_t7m.ta7dier_day = objta7dier_master.ta7dier_day;
            con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
            con_t7m.state_name = objta7dier_master.state_name;
            con_t7m.ta7dier_name = objta7dier_master.ta7dier_name;
            con_t7m.ta7dier_body = objta7dier_master.ta7dier_body;
            con_t7m.ta7dier_notes = objta7dier_master.ta7dier_notes;
            con_t7m.ta7dier_supervision_state_id = objta7dier_master.ta7dier_supervision_state_id;
            con_t7m.ta7dier_supervision_state_name = objta7dier_master.ta7dier_supervision_state_name;
            con_t7m.ta7dier_state_name = objta7dier_master.ta7dier_state_name;
            con_t7m.ta7dier_file = objta7dier_master.ta7dier_file;
            con_t7m.ta7dier_file_type = objta7dier_master.ta7dier_file_type;
            con_t7m.is_file = objta7dier_master.is_file;

          var id=  con_t7m.save_in_ta7dier_master();
            try
            {
                con_sig.from_emp_id = objta7dier_master.emp_id;
                con_sig.route = objta7dier_master.route;
                con_sig.to_emp_id =0;
                con_sig.object_id = Convert.ToInt32(id);
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
                    object_id = Convert.ToInt32(id),
                    msg_date = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_date"],
                });
                var tst = 0;
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
        }
        //con_sig.from_emp_id = objta7dier_master.emp_id;
        //con_sig.body = "تم طلب تحضير";
        //con_sig.title = "تحضيرات";
        //con_sig.connection_id = "";
        //con_sig.job_id = 38;
        //DataSet list_of_cons = con_sig.send_notifications();
        //List<string> data = new List<string>();


        //foreach (DataRow row in list_of_cons.Tables[0].Rows)
        //{
        //    string value = row["connection_id"].ToString();
        //    data.Add(value);
        //}
        //await _hubContext.Clients.Clients(data).SendAsync("GeneralNotification", new BusinessLogic.ViewModels.NotificationModel
        //{
        //    Body = "تم طلب تحضير",
        //    Title = "تحضيرات",
        //    IsRead = false
        //});

        // var result = _service.get_signalir_connections().Result;
        // get to person

        // if exist  send notification
        //con_sig.from_emp_id = objta7dier_master.emp_id;
        //con_sig.body = "تم طلب تحضير";
        //con_sig.title = "تحضيرات";
        //con_sig.connection_id = "";
        //DataSet list_of_cons = con_sig.send_notifications();
        //List<string> data = new List<string>();


        //foreach (DataRow row in list_of_cons.Tables[0].Rows)
        //{
        //    string value = row["connection_id"].ToString();
        //    data.Add(value);
        //}

        //_service.SendMessageToAll(new BusinessLogic.ViewModels.NotificationModel
        //{
        //    Body = "Ta7deer",
        //    Title = "Ta7deer",
        //    IsRead = false
        //});
        //  return new JsonResult("Added Successfully");

        [HttpPut]
           public JsonResult Put(ta7dier_master objta7dier_master)
           {
               con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
               con_t7m.emp_id = objta7dier_master.emp_id;
               con_t7m.emp_name = objta7dier_master.emp_name;
               con_t7m.subject_id = objta7dier_master.subject_id;
               con_t7m.subject_name = objta7dier_master.subject_name;
               con_t7m.grade_id = objta7dier_master.grade_id;
               con_t7m.grade_name = objta7dier_master.grade_name;
               con_t7m.ta7dier_date = objta7dier_master.ta7dier_date;
               con_t7m.ta7dier_week = objta7dier_master.ta7dier_week;
               con_t7m.ta7dier_day = objta7dier_master.ta7dier_day;
               con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
               con_t7m.state_name = objta7dier_master.state_name;
               con_t7m.ta7dier_name = objta7dier_master.ta7dier_name;
               con_t7m.ta7dier_body = objta7dier_master.ta7dier_body;
               con_t7m.ta7dier_notes = objta7dier_master.ta7dier_notes;
               con_t7m.ta7dier_supervision_state_id = objta7dier_master.ta7dier_supervision_state_id;
               con_t7m.ta7dier_supervision_state_name = objta7dier_master.ta7dier_supervision_state_name;
               con_t7m.ta7dier_state_name = objta7dier_master.ta7dier_state_name;
               con_t7m.ta7dier_file = objta7dier_master.ta7dier_file;
            con_t7m.ta7dier_file_type = objta7dier_master.ta7dier_file_type;
            con_t7m.is_file = objta7dier_master.is_file;
            con_t7m.update_ta7dier_master();
               return new JsonResult("Updated Successfully");
           }
           [HttpDelete("{id}")]
           public JsonResult Delete(int id)
           {
               con_t7m.ta7dier_id = id;
               con_t7m.delete_from_ta7dier_master();
               return new JsonResult("deleted Successfully");


           }
           [HttpGet]
           public List<ta7dier_master> Get()
           {
               dataset1 = con_t7m.get_ta7dier_master();
               var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                    select new ta7dier_master()
                                    {
                                        ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                        emp_id = Convert.ToInt32(rw["emp_id"]),
                                        emp_name = Convert.ToString(rw["emp_name"]),
                                        subject_id = Convert.ToInt32(rw["subject_id"]),
                                        subject_name = Convert.ToString(rw["subject_name"]),
                                        grade_id = Convert.ToInt32(rw["grade_id"]),
                                        grade_name = Convert.ToString(rw["grade_name"]),
                                        ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                        ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                        ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                        ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                        state_name = Convert.ToString(rw["state_name"]),
                                        ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                        ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                        ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                        ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                        ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                        ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                        ta7dier_file = Convert.ToString(rw["ta7dier_file"]),
                                        ta7dier_file_type = Convert.ToString(rw["ta7dier_file_type"]),
                                        is_file = Convert.ToInt32(rw["is_file"]),
                                        civil_id = Convert.ToInt32(rw["civil_id"]),
                                        emp_dep = Convert.ToString(rw["emp_dep"]),

                                    }).ToList();

               return convertedList;

           }
           [HttpGet("id")]
           public List<ta7dier_master> Get(int id)
           {
               con_t7m.ta7dier_id = id;
               dataset1 = con_t7m.get_ta7dier_master_with_id();

               var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                    select new ta7dier_master()
                                    {
                                        ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                        emp_id = Convert.ToInt32(rw["emp_id"]),
                                        emp_name = Convert.ToString(rw["emp_name"]),
                                        subject_id = Convert.ToInt32(rw["subject_id"]),
                                        subject_name = Convert.ToString(rw["subject_name"]),
                                        grade_id = Convert.ToInt32(rw["grade_id"]),
                                        grade_name = Convert.ToString(rw["grade_name"]),
                                        ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                        ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                        ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                        ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                        state_name = Convert.ToString(rw["state_name"]),
                                        ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                        ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                        ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                        ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                        ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                        ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                        ta7dier_file = Convert.ToString(rw["ta7dier_file"]),
                                        ta7dier_file_type = Convert.ToString(rw["ta7dier_file_type"]),
                                        is_file = Convert.ToInt32(rw["is_file"])
                                    }).ToList();

               return convertedList;
           }
           [HttpGet("subject_id")]
           public List<ta7dier_master> get_ta7dier_master_with_subject_id(int subject_id)
           {
               con_t7m.subject_id = subject_id;
               dataset1 = con_t7m.get_ta7dier_master_with_subject_id();

               var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                    select new ta7dier_master()
                                    {
                                        ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                        emp_id = Convert.ToInt32(rw["emp_id"]),
                                        emp_name = Convert.ToString(rw["emp_name"]),
                                        subject_id = Convert.ToInt32(rw["subject_id"]),
                                        subject_name = Convert.ToString(rw["subject_name"]),
                                        grade_id = Convert.ToInt32(rw["grade_id"]),
                                        grade_name = Convert.ToString(rw["grade_name"]),
                                        ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                        ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                        ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                        ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                        state_name = Convert.ToString(rw["state_name"]),
                                        ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                        ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                        ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                        ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                        ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                        ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                        ta7dier_file = Convert.ToString(rw["ta7dier_file"]),
                                        ta7dier_file_type = Convert.ToString(rw["ta7dier_file_type"]),
                                        is_file = Convert.ToInt32(rw["is_file"])
                                    }).ToList();

               return convertedList;
           }
        [HttpGet("get_ta7dier_master_with_dep_id")]
        public List<ta7dier_master> get_ta7dier_master_with_dep_id(int dep_id)
        {
            con_t7m.dep_id = dep_id;
            dataset1 = con_t7m.get_ta7dier_master_with_dep_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                     state_name = Convert.ToString(rw["state_name"]),
                                     ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                     ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                     ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                     ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                     ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                     ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                     ta7dier_file = Convert.ToString(rw["ta7dier_file"]),
                                     ta7dier_file_type = Convert.ToString(rw["ta7dier_file_type"]),
                                     is_file = Convert.ToInt32(rw["is_file"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_ta7dier_master_for_dashboard_t1")]
        public List<ta7dier_master> get_ta7dier_master_for_dashboard(int emp_id)
        {
            con_t7m.emp_id = emp_id;
            dataset1 = con_t7m.get_ta7dier_master_for_dashboard();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),


                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_ta7dier_master_for_dashboard_t2")]
        public List<ta7dier_master> get_ta7dier_master_for_dashboard_t2(int emp_id)
        {
            con_t7m.emp_id = emp_id;
            dataset1 = con_t7m.get_ta7dier_master_for_dashboard();

            var convertedList = (from rw in dataset1.Tables[1].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),

                                 }).ToList();

            return convertedList;
        }

    }
}