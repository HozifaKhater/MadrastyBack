using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class statusController : ControllerBase
    {
        status status = new status();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<status> Get(int id)
        {
            status.id = id;
            dataset = status.get_status_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new status()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     status_name = Convert.ToString(rw["status_name"]),
                                     status_id = Convert.ToInt32(rw["status_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     dob = Convert.ToString(rw["dob"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     status_concerns = Convert.ToString(rw["status_concerns"])
                                    
                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<status> Get()
        {
            dataset = status.get_status();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new status()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     status_name = Convert.ToString(rw["status_name"]),
                                     status_id = Convert.ToInt32(rw["status_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     dob = Convert.ToString(rw["dob"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     status_concerns = Convert.ToString(rw["status_concerns"])
                                            
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(status obj)
        {
           // status.id = obj.id;
            status.status_name = obj.status_name;
            status.status_id = obj.status_id;
            status.level_id = obj.level_id;
            status.level_name = obj.level_name;
            status.class_id = obj.class_id;
            status.class_name = obj.class_name;
            status.student_name = obj.student_name;
            status.student_id = obj.student_id;
            status.dob = obj.dob;
            status.notes = obj.notes;
            status.status_concerns = obj.status_concerns;
          
            status.save_in_status();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(status obj)
        {
            status.id = obj.id;
            status.status_name = obj.status_name;
            status.status_id = obj.status_id;
            status.level_id = obj.level_id;
            status.level_name = obj.level_name;
            status.class_id = obj.class_id;
            status.class_name = obj.class_name;
            status.student_name = obj.student_name;
            status.student_id = obj.student_id;
            status.dob = obj.dob;
            status.notes = obj.notes;
            status.status_concerns = obj.status_concerns;
           
            status.update_status();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            status.id = id;
            status.delete_from_status();
            return new JsonResult("deleted Successfully");


        }
    }
}