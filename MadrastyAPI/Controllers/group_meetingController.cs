using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;
using  System.Reflection.Metadata;
using  Microsoft.AspNetCore.SignalR;
using  BusinessLogic.Hubs;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class group_meetingController : ControllerBase
    {
        private readonly IHubContext<AppNotificationHub> _hubContext;

        public group_meetingController(IHubContext<AppNotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }


        signalir_connections con_sig = new signalir_connections();
        group_meeting con_group_meeting = new group_meeting();
        teams_and_groups con_teams_and_groups = new teams_and_groups();
        public DataSet dataset { get; set; }
        public DataSet teams_members_ds { get; set; }

        [HttpGet("id")]
        public List<group_meeting> Get(int id)
        {
            con_group_meeting.group_id = id;
            dataset = con_group_meeting.get_group_meeting_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new group_meeting()
                                 {
                                     group_id = Convert.ToInt32(rw["group_id"]),
                                     group_name = Convert.ToString(rw["group_name"]),
                                     meeting_no = Convert.ToInt32(rw["meeting_no"]),
                                     meeting_date = Convert.ToString(rw["meeting_date"]),
                                     meeting_mem_no = Convert.ToInt32(rw["meeting_mem_no"]),
                                     meeting_loc = Convert.ToString(rw["meeting_loc"]),
                                     impor_recomm = Convert.ToString(rw["impor_recomm"]),
                                     bus_table = Convert.ToString(rw["bus_table"]),
                                     meeting_type_id = Convert.ToInt32(rw["meeting_type_id"]),
                                     meeting_type_name = Convert.ToString(rw["meeting_type_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     course = Convert.ToString(rw["course"]),
                                     content = Convert.ToString(rw["content"]),


                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<group_meeting> Get()
        {
            dataset = con_group_meeting.get_group_meeting();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new group_meeting()
                                 {
                                     group_id = Convert.ToInt32(rw["group_id"]),
                                     group_name = Convert.ToString(rw["group_name"]),
                                     meeting_no = Convert.ToInt32(rw["meeting_no"]),
                                     meeting_date = Convert.ToString(rw["meeting_date"]),
                                     meeting_mem_no = Convert.ToInt32(rw["meeting_mem_no"]),
                                     meeting_loc = Convert.ToString(rw["meeting_loc"]),
                                     impor_recomm = Convert.ToString(rw["impor_recomm"]),
                                     bus_table = Convert.ToString(rw["bus_table"]),
                                     meeting_type_id = Convert.ToInt32(rw["meeting_type_id"]),
                                     meeting_type_name = Convert.ToString(rw["meeting_type_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     course = Convert.ToString(rw["course"]),
                                     content = Convert.ToString(rw["content"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public async Task Post(group_meeting objgroup_meeting)
        {
            con_group_meeting.group_name = objgroup_meeting.group_name;
            con_group_meeting.meeting_no = objgroup_meeting.meeting_no;
            con_group_meeting.meeting_date = objgroup_meeting.meeting_date;
            con_group_meeting.meeting_mem_no = objgroup_meeting.meeting_mem_no;
            con_group_meeting.meeting_loc = objgroup_meeting.meeting_loc;
            con_group_meeting.impor_recomm = objgroup_meeting.impor_recomm;
            con_group_meeting.bus_table = objgroup_meeting.bus_table;
            con_group_meeting.meeting_type_id = objgroup_meeting.meeting_type_id;
            con_group_meeting.meeting_type_name = objgroup_meeting.meeting_type_name;
            con_group_meeting.dep_id = objgroup_meeting.dep_id;
            con_group_meeting.dep_name = objgroup_meeting.dep_name;
            con_group_meeting.subject_id = objgroup_meeting.subject_id;
            con_group_meeting.subject_name = objgroup_meeting.subject_name;
            con_group_meeting.course = objgroup_meeting.course;
            con_group_meeting.content = objgroup_meeting.content;

            con_group_meeting.save_in_group_meeting();
            try
            {
                con_teams_and_groups.team_id = Convert.ToInt32(objgroup_meeting.group_name);
            teams_members_ds = con_teams_and_groups.get_teams_members_with_team_id();
            foreach (DataRow row in teams_members_ds.Tables[0].Rows)
            {
               // string value = row["connection_id"].ToString();
                con_sig.from_emp_id = 0;
                con_sig.route = objgroup_meeting.route;
                con_sig.to_emp_id = Convert.ToInt32(row["emp_id"]);
                DataSet list_of_cons = con_sig.send_notifications();
                List<string> data = new List<string>();
                foreach (DataRow row1 in list_of_cons.Tables[0].Rows)
                {
                    string value1 = row1["connection_id"].ToString();
                    data.Add(value1);
                }
                await _hubContext.Clients.Clients(data).SendAsync("GeneralNotification", new BusinessLogic.ViewModels.NotificationModel
                {
                    Body = (string)list_of_cons.Tables[1].Rows[0][columnName: "msg_body"],
                    Title = (string)list_of_cons.Tables[1].Rows[0][columnName: "title"],
                    IsRead = false
                });
            }
           
            
            }
            catch (InvalidCastException e)
            {
                // recover from exception
            }
            //return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(group_meeting objgroup_meeting)
        {
            con_group_meeting.group_id = objgroup_meeting.group_id;
            con_group_meeting.group_name = objgroup_meeting.group_name;
            con_group_meeting.meeting_no = objgroup_meeting.meeting_no;
            con_group_meeting.meeting_date = objgroup_meeting.meeting_date;
            con_group_meeting.meeting_mem_no = objgroup_meeting.meeting_mem_no;
            con_group_meeting.meeting_loc = objgroup_meeting.meeting_loc;
            con_group_meeting.impor_recomm = objgroup_meeting.impor_recomm;
            con_group_meeting.bus_table = objgroup_meeting.bus_table;
            con_group_meeting.meeting_type_id = objgroup_meeting.meeting_type_id;
            con_group_meeting.meeting_type_name = objgroup_meeting.meeting_type_name;
            con_group_meeting.dep_id = objgroup_meeting.dep_id;
            con_group_meeting.dep_name = objgroup_meeting.dep_name;
            con_group_meeting.subject_id = objgroup_meeting.subject_id;
            con_group_meeting.subject_name = objgroup_meeting.subject_name;
            con_group_meeting.course = objgroup_meeting.course;
            con_group_meeting.content = objgroup_meeting.content;

            con_group_meeting.update_group_meeting();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_group_meeting.group_id = id;
            con_group_meeting.delete_from_group_meeting();
            return new JsonResult("deleted Successfully");


        }
    }
}