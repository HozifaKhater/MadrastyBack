using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json.Linq;
using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  System.Diagnostics.Contracts;


namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tripsController : ControllerBase
    {
        trips con_obj = new trips();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<trips> Get(int id)
        {
            con_obj.trip_id = id;
            subject = con_obj.get_trips_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new trips()
                                 {
                                     trip_id = Convert.ToInt32(rw["trip_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     trip_loc = Convert.ToString(rw["trip_loc"]),
                                     trip_date = Convert.ToString(rw["trip_date"]),
                                     trip_time = Convert.ToString(rw["trip_time"]),
                                     trip_duration = Convert.ToString(rw["trip_duration"]),
                                     trip_goals = Convert.ToString(rw["trip_goals"]),
                                     trip_notes = Convert.ToString(rw["trip_notes"]),
                                     student_number = Convert.ToInt32(rw["student_number"]),
                                     trip_type = Convert.ToInt32(rw["trip_type"]),
                                     transportation_type = Convert.ToInt32(rw["transportation_type"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),


                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<trips> Get()
        {
            subject = con_obj.get_trips();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new trips()
                                 {

                                     trip_id = Convert.ToInt32(rw["trip_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     trip_loc = Convert.ToString(rw["trip_loc"]),
                                     trip_date = Convert.ToString(rw["trip_date"]),
                                     trip_time = Convert.ToString(rw["trip_time"]),
                                     trip_duration = Convert.ToString(rw["trip_duration"]),
                                     trip_goals = Convert.ToString(rw["trip_goals"]),
                                     trip_notes = Convert.ToString(rw["trip_notes"]),
                                     student_number = Convert.ToInt32(rw["student_number"]),
                                     trip_type = Convert.ToInt32(rw["trip_type"]),
                                     transportation_type = Convert.ToInt32(rw["transportation_type"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(trips obj)
        {

            con_obj.trip_id = obj.trip_id;
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.emp_name = obj.emp_name;
            con_obj.trip_loc = obj.trip_loc;
            con_obj.trip_date = obj.trip_date;
            con_obj.trip_time = obj.trip_time;
            con_obj.trip_duration = obj.trip_duration;
            con_obj.trip_goals = obj.trip_goals;
            con_obj.trip_notes = obj.trip_notes;
            con_obj.student_number = obj.student_number;
            con_obj.trip_type = obj.trip_type;
            con_obj.transportation_type = obj.transportation_type;
            con_obj.class_id = obj.class_id;
            con_obj.level_id = obj.level_id;

            var trip_id =   con_obj.save_in_trips();
            return new JsonResult(trip_id);
        }
        [HttpPut]
        public JsonResult Put(trips obj)
        {
            con_obj.trip_id = obj.trip_id;
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.emp_name = obj.emp_name;
            con_obj.trip_loc = obj.trip_loc;
            con_obj.trip_date = obj.trip_date;
            con_obj.trip_time = obj.trip_time;
            con_obj.trip_duration = obj.trip_duration;
            con_obj.trip_goals = obj.trip_goals;
            con_obj.trip_notes = obj.trip_notes;
            con_obj.student_number = obj.student_number;
            con_obj.trip_type = obj.trip_type;
            con_obj.transportation_type = obj.transportation_type;
            con_obj.class_id = obj.class_id;
            con_obj.level_id = obj.level_id;
            con_obj.update_trips();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.trip_id = id;
            con_obj.delete_from_trips();
            return new JsonResult("deleted Successfully");


        }
        [HttpPost("details")]
        public JsonResult save_in_deails(trips obj)
        {

            
            con_obj.trip_id = obj.trip_id;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;


             con_obj.save_in_trip_details();
            return new JsonResult("");
        }
        [HttpPost("delete_details_with_trip_id")]
        public JsonResult Delete_from_details(trips obj)
        {
            con_obj.trip_id = obj.trip_id;
            con_obj.delete_from_trip_details_with_trip_id();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("details_id")]
        public List<trips> get_trip_details_with_id(int id)
        {
            con_obj.ser = id;
            subject = con_obj.get_trip_details_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new trips()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     trip_id = Convert.ToInt32(rw["trip_id"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"])


                                 }).ToList();

            return convertedList;
        }
        [HttpGet("details_with_trip_id")]
        public List<trips> get_trip_details_with_trip_id(int id)
        {
            con_obj.trip_id = id;
            subject = con_obj.get_trip_details_with_trip_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new trips()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     trip_id = Convert.ToInt32(rw["trip_id"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"])


                                 }).ToList();

            return convertedList;
        }
    }
}