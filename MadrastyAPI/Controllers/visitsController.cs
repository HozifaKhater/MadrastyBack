using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class visitsController :ControllerBase
    {

        visits con_yeardata = new visits();


        public DataSet dataset1 { get; set; }

        [HttpGet]
        public List<visits> Get()
        {
            dataset1 = con_yeardata.get_visits();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new visits()
                                 {
                                     visit_id = Convert.ToInt32(rw["visit_id"]),
                                     visit_type_name = Convert.ToString(rw["visit_type_name"]),
                                     visit_type_id = Convert.ToInt32(rw["visit_type_id"]),
                                     visit_date = Convert.ToString(rw["visit_date"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     start_time = Convert.ToString(rw["start_time"]),
                                     end_time = Convert.ToString(rw["end_time"]),
                                     name = Convert.ToString(rw["name"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     instructions = Convert.ToString(rw["instructions"]),
                                     job = Convert.ToString(rw["job"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     vnote = Convert.ToString(rw["vnote"]),
                                     emp_from_id = Convert.ToInt32(rw["emp_from_id"]),
                                     emp_to_id = Convert.ToInt32(rw["emp_to_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),


                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(visits objyeardata)
        {
            con_yeardata.visit_id = objyeardata.visit_id;
            con_yeardata.visit_type_name = objyeardata.visit_type_name;
            con_yeardata.visit_type_id = objyeardata.visit_type_id;
            con_yeardata.visit_date = objyeardata.visit_date;
            con_yeardata.phone = objyeardata.phone;
            con_yeardata.start_time = objyeardata.start_time;
            con_yeardata.end_time = objyeardata.end_time;
            con_yeardata.name = objyeardata.name;
            con_yeardata.topic = objyeardata.topic;
            con_yeardata.instructions = objyeardata.instructions;
            con_yeardata.job = objyeardata.job;
            con_yeardata.notes = objyeardata.notes;
            con_yeardata.dep_name = objyeardata.dep_name;
            con_yeardata.dep_id = objyeardata.dep_id;
            con_yeardata.vnote = objyeardata.vnote;
            con_yeardata.emp_from_id = objyeardata.emp_from_id;
            con_yeardata.emp_to_id = objyeardata.emp_to_id;
            con_yeardata.takeem_id = objyeardata.takeem_id;

            con_yeardata.update_visits();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_yeardata.visit_id = id;
            con_yeardata.delete_from_visits ();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<visits> Get(int id)
        {
            con_yeardata.visit_id = id;
            dataset1 = con_yeardata.get_visits_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new visits()
                                 {
                                     visit_id = Convert.ToInt32(rw["visit_id"]),
                                     visit_type_name = Convert.ToString(rw["visit_type_name"]),
                                     visit_type_id = Convert.ToInt32(rw["visit_type_id"]),
                                     visit_date = Convert.ToString(rw["visit_date"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     start_time = Convert.ToString(rw["start_time"]),
                                     end_time = Convert.ToString(rw["end_time"]),
                                     name = Convert.ToString(rw["name"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     instructions = Convert.ToString(rw["instructions"]),
                                     job = Convert.ToString(rw["job"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     vnote = Convert.ToString(rw["vnote"]),
                                     emp_from_id = Convert.ToInt32(rw["emp_from_id"]),
                                     emp_to_id = Convert.ToInt32(rw["emp_to_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),


                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(visits objyeardata)
        {


 
            con_yeardata.visit_type_name = objyeardata.visit_type_name;
            con_yeardata.visit_type_id = objyeardata.visit_type_id;
            con_yeardata.visit_date = objyeardata.visit_date;
            con_yeardata.phone = objyeardata.phone;
            con_yeardata.start_time = objyeardata.start_time;
            con_yeardata.end_time = objyeardata.end_time;
            con_yeardata.name = objyeardata.name;
            con_yeardata.topic = objyeardata.topic;
            con_yeardata.instructions = objyeardata.instructions;
            con_yeardata.job = objyeardata.job;
            con_yeardata.notes = objyeardata.notes;
            con_yeardata.dep_name = objyeardata.dep_name;
            con_yeardata.dep_id = objyeardata.dep_id;
            con_yeardata.vnote = objyeardata.vnote;
            con_yeardata.emp_from_id = objyeardata.emp_from_id;
            con_yeardata.emp_to_id = objyeardata.emp_to_id;
            con_yeardata.takeem_id = objyeardata.takeem_id;


            var year_data_id = con_yeardata.save_in_visits();
            return new JsonResult(year_data_id);
        }
        [HttpPost("student_attendance_precent")]
        public JsonResult save_in_student_attendance_precent(visits objyeardata)
        {
            con_yeardata.attendance_precent = objyeardata.attendance_precent;
            var year_data_id = con_yeardata.save_in_student_attendance_precent();
            return new JsonResult(year_data_id);
        }
    }
}