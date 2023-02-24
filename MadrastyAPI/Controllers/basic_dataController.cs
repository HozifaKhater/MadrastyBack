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
    public class basic_dataController : ControllerBase
    {

        basic_data con_obj = new basic_data();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<basic_data> Get(int id)
        {
            con_obj.id = id;
            dataset = con_obj.get_basic_data_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new basic_data()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     name = Convert.ToString(rw["name"]),
                                     file_number = Convert.ToInt32(rw["file_number"]),
                                     identity_number = Convert.ToInt32(rw["identity_number"]),
                                     qualification = Convert.ToInt32(rw["qualification"]),
                                     register_date = Convert.ToString(rw["register_date"]),
                                     civil_number = Convert.ToInt32(rw["civil_number"]),
                                     exp_years = Convert.ToInt32(rw["exp_years"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<basic_data> Get()
        {
            dataset = con_obj.get_basic_data();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new basic_data()
                                 {

                                     id = Convert.ToInt32(rw["id"]),
                                     name = Convert.ToString(rw["name"]),
                                     file_number = Convert.ToInt32(rw["file_number"]),
                                     identity_number = Convert.ToInt32(rw["identity_number"]),
                                     qualification = Convert.ToInt32(rw["qualification"]),
                                     register_date = Convert.ToString(rw["register_date"]),
                                     civil_number = Convert.ToInt32(rw["civil_number"]),
                                     exp_years = Convert.ToInt32(rw["exp_years"]),
                                      emp_id = Convert.ToInt32(rw["emp_id"])
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(basic_data obj)
        {
          //  con_obj.id = obj.id;
            con_obj.name = obj.name;
            con_obj.file_number = obj.file_number;
            con_obj.identity_number = obj.identity_number;
            con_obj.qualification = obj.qualification;
            con_obj.register_date = obj.register_date;
            con_obj.civil_number = obj.civil_number;
            con_obj.exp_years = obj.exp_years;
            con_obj.emp_id = obj.emp_id;

            con_obj.save_in_basic_data();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(basic_data obj)
        {
             con_obj.id = obj.id;
            con_obj.name = obj.name;
            con_obj.file_number = obj.file_number;
            con_obj.identity_number = obj.identity_number;
            con_obj.qualification = obj.qualification;
            con_obj.register_date = obj.register_date;
            con_obj.civil_number = obj.civil_number;
            con_obj.exp_years = obj.exp_years;
            con_obj.emp_id = obj.emp_id;
            con_obj.update_basic_data();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.id = id;
            con_obj.delete_from_basic_data();
            return new JsonResult("deleted Successfully");


        }

        [HttpGet("div")]
        public List<divisions> get_divisions_with_emp_id(int id)
        {
            con_obj.emp_id = id;
            dataset = con_obj.get_divisions_with_emp_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new divisions()
                                 {
                                     div_name = Convert.ToString(rw["div_name"]),
                                     div_id = Convert.ToInt32(rw["div_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     mob = Convert.ToString(rw["mob"])

                                 }).ToList();

            return convertedList;
        }

        [HttpGet("training")]
        public List<training_courses> get_training_courses_with_emp_id(int id)
        {
            con_obj.id = id;
            dataset = con_obj.get_training_courses_with_emp_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new training_courses()
                                 {
                                     trainig_id = Convert.ToInt32(rw["trainig_id"]),
                                     trainig_name = Convert.ToString(rw["trainig_name"]),
                                     trainig_from = Convert.ToString(rw["trainig_from"]),
                                     trainig_to = Convert.ToString(rw["trainig_to"]),
                                     traing_desc = Convert.ToString(rw["traing_desc"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"])


                                 }).ToList();

            return convertedList;
        }
    }
}