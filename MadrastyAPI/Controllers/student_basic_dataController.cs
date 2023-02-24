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
    public class student_basic_dataController : ControllerBase
    {
        student_basic_data con_obj = new student_basic_data();
        

        public DataSet dataset1 { get; set; }
      
        // GET: api/<controller>
        [HttpGet]
        public List<student_basic_data> Get()
        {
            dataset1 = con_obj.get_student_basic_data();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_basic_data()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     previous_school = Convert.ToString(rw["previous_school"]),
                                     address = Convert.ToString(rw["address"]),
                                     transition_between_schools = Convert.ToString(rw["transition_between_schools"]),
                                     foreign_schools = Convert.ToString(rw["foreign_schools"]),
                                     student_history_notes = Convert.ToString(rw["student_history_notes"]),
                                     health_status = Convert.ToString(rw["health_status"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),

                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(student_basic_data obj)
        {
           // con_obj.ser = obj.ser;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.previous_school = obj.previous_school;
            con_obj.address = obj.address;
            con_obj.transition_between_schools = obj.transition_between_schools;
            con_obj.foreign_schools = obj.foreign_schools;
            con_obj.student_history_notes = obj.student_history_notes;
            con_obj.health_status = obj.health_status;

            con_obj.save_in_student_basic_data();

        }
        [HttpGet("id")]
        public List<student_basic_data> Get(int id)
        {
            con_obj.ser = id;
            dataset1 = con_obj.get_student_basic_data_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_basic_data()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     previous_school = Convert.ToString(rw["previous_school"]),
                                     address = Convert.ToString(rw["address"]),
                                     transition_between_schools = Convert.ToString(rw["transition_between_schools"]),
                                     foreign_schools = Convert.ToString(rw["foreign_schools"]),
                                     student_history_notes = Convert.ToString(rw["student_history_notes"]),
                                     health_status = Convert.ToString(rw["health_status"])
                                 }).ToList();

            return convertedList;
        }


        [HttpPut]
        public JsonResult Put(student_basic_data obj)
        {
            con_obj.ser = obj.ser;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.previous_school = obj.previous_school;
            con_obj.address = obj.address;
            con_obj.transition_between_schools = obj.transition_between_schools;
            con_obj.foreign_schools = obj.foreign_schools;
            con_obj.student_history_notes = obj.student_history_notes;
            con_obj.health_status = obj.health_status;
            con_obj.update_student_basic_data();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.ser = id;
            con_obj.delete_from_student_basic_data();
            return new JsonResult("deleted Successfully");


        }

       
        // GET: api/<controller>
        [HttpGet("details")]
        public List<student_basic_data> Get_details()
        {
            dataset1 = con_obj.get_students_basic_data_details();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_basic_data()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     mr7la_name = Convert.ToString(rw["mr7la_name"]),
                                     mr7la_id = Convert.ToInt32(rw["mr7la_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     good_subject_id = Convert.ToInt32(rw["good_subject_id"]),
                                     good_subject_name = Convert.ToString(rw["good_subject_name"]),
                                     bad_subject_id = Convert.ToInt32(rw["bad_subject_id"]),
                                     bad_subject_name = Convert.ToString(rw["bad_subject_name"]),

                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost("details")]
        public void save_in_students_basic_data_details(student_basic_data obj)
        {
            con_obj.ser = obj.ser;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.mr7la_name = obj.mr7la_name;
            con_obj.mr7la_id = obj.mr7la_id;
            con_obj.level_id = obj.level_id;
            con_obj.level_name = obj.level_name;
            con_obj.good_subject_id = obj.good_subject_id;
            con_obj.good_subject_name = obj.good_subject_name;
            con_obj.bad_subject_id = obj.bad_subject_id;
            con_obj.bad_subject_name = obj.bad_subject_name;

            con_obj.save_in_students_basic_data_details();

        }
        [HttpGet("details_id")]
        public List<student_basic_data> Get_details_with_id(int details_id)
        {
            con_obj.ser = details_id;
            dataset1 = con_obj.get_students_basic_data_details_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student_basic_data()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     mr7la_name = Convert.ToString(rw["mr7la_name"]),
                                     mr7la_id = Convert.ToInt32(rw["mr7la_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     good_subject_id = Convert.ToInt32(rw["good_subject_id"]),
                                     good_subject_name = Convert.ToString(rw["good_subject_name"]),
                                     bad_subject_id = Convert.ToInt32(rw["bad_subject_id"]),
                                     bad_subject_name = Convert.ToString(rw["bad_subject_name"])
                                 }).ToList();

            return convertedList;
        }


        [HttpPut("details")]
        public JsonResult update_students_basic_data_details(student_basic_data obj)
        {
            con_obj.ser = obj.ser;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.mr7la_name = obj.mr7la_name;
            con_obj.mr7la_id = obj.mr7la_id;
            con_obj.level_id = obj.level_id;
            con_obj.level_name = obj.level_name;
            con_obj.good_subject_id = obj.good_subject_id;
            con_obj.good_subject_name = obj.good_subject_name;
            con_obj.bad_subject_id = obj.bad_subject_id;
            con_obj.bad_subject_name = obj.bad_subject_name;
            con_obj.update_students_basic_data_details();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("details_id")]
        public JsonResult delete_from_students_basic_data_details(int id)
        {
            con_obj.ser = id;
            con_obj.delete_from_students_basic_data_details();
            return new JsonResult("deleted Successfully");


        }
    }
}