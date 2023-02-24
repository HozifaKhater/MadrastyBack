using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS_project.Models;

namespace SMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class group_meetingController : ControllerBase
    {
        group_meeting con_group_meeting = new group_meeting();
        public DataSet dataset { get; set; }

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
                                     bus_table = Convert.ToString(rw["bus_table"])

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
                                     bus_table = Convert.ToString(rw["bus_table"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(group_meeting objgroup_meeting)
        {
            con_group_meeting.group_name = objgroup_meeting.group_name;
            con_group_meeting.meeting_no = objgroup_meeting.meeting_no;
            con_group_meeting.meeting_date = objgroup_meeting.meeting_date;
            con_group_meeting.meeting_mem_no = objgroup_meeting.meeting_mem_no;
            con_group_meeting.meeting_loc = objgroup_meeting.meeting_loc;
            con_group_meeting.impor_recomm = objgroup_meeting.impor_recomm;
            con_group_meeting.bus_table = objgroup_meeting.bus_table;

            con_group_meeting.save_in_group_meeting();
            return new JsonResult("Added Successfully");
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