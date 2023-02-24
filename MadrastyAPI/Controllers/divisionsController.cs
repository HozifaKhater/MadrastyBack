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
    public class divisionsController : ControllerBase
    {
        divisions con_obj = new divisions();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<divisions> Get(int id)
        {
            con_obj.div_id = id;
            subject = con_obj.get_divisions_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new divisions()
                                 {
                                     div_id = Convert.ToInt32(rw["div_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     mob = Convert.ToString(rw["mob"]),




                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<divisions> Get()
        {
            subject = con_obj.get_divisions();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new divisions()
                                 {

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
        [HttpPost]
        public JsonResult Post(divisions obj)
        {

          
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;
            con_obj.job_id = obj.job_id;
            con_obj.job_name = obj.job_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.emp_name = obj.emp_name;
            con_obj.phone = obj.phone;
            con_obj.mob = obj.mob;


            con_obj.save_in_divisions();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(divisions obj)
        {
            con_obj.div_id = obj.div_id;
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;
            con_obj.job_id = obj.job_id;
            con_obj.job_name = obj.job_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.emp_name = obj.emp_name;
            con_obj.phone = obj.phone;
            con_obj.mob = obj.mob;



            con_obj.update_divisions();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.div_id = id;
            con_obj.delete_from_divisions();
            return new JsonResult("deleted Successfully");


        }
    }
}