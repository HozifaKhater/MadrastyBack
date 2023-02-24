using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json.Linq;
using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class student_parent_meetingController : ControllerBase
    {
        student_parent_meeting con_obj= new student_parent_meeting();

        public DataSet dataset1 { get; set; }
      
        // GET: api/<controller>
        [HttpGet]
        public List<student_parent_meeting> Get()
        {
            dataset1 = con_obj.get_student_parent_meeting();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_parent_meeting()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     date = Convert.ToString(rw["date"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     reason = Convert.ToString(rw["reason"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),

                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(student_parent_meeting obj)
        {
       
            con_obj.date = obj.date;
            con_obj.level_name = obj.level_name;
            con_obj.level_id = obj.level_id;
            con_obj.class_name = obj.class_name;
            con_obj.class_id = obj.class_id;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.reason = obj.reason;

            con_obj.save_in_student_parent_meeting();

        }
        [HttpGet("id")]
        public List<student_parent_meeting> Get(int id)
        {
            con_obj.id = id;
            dataset1 = con_obj.get_student_parent_meeting_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_parent_meeting()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     date = Convert.ToString(rw["date"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     reason = Convert.ToString(rw["reason"])
                                 }).ToList();

            return convertedList;
        }


        [HttpPut]
        public JsonResult Put(student_parent_meeting obj)
        {
            con_obj.id = obj.id;
            con_obj.date = obj.date;
            con_obj.level_name = obj.level_name;
            con_obj.level_id = obj.level_id;
            con_obj.class_name = obj.class_name;
            con_obj.class_id = obj.class_id;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.reason = obj.reason;

            //con_obj.save_in_activity_def();
            con_obj.update_student_parent_meeting();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.id = id;
            con_obj.delete_from_student_parent_meeting();
            return new JsonResult("deleted Successfully");


        }
    }
}