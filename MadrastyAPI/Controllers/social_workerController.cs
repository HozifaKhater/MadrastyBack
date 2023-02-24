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
    public class social_workerController : ControllerBase
    {

        social_worker con_social_worker = new social_worker();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<social_worker> Get(int id)
        {
            con_social_worker.social_id = id;
            dataset = con_social_worker.get_social_worker_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new social_worker()
                                 {
                                     social_id = Convert.ToInt32(rw["social_id"]),
                                     social_level = Convert.ToString(rw["social_level"]),
                                     social_class = Convert.ToString(rw["social_class"]),
                                     social_dep = Convert.ToString(rw["social_dep"]),
                                     social_students = Convert.ToString(rw["social_students"]),
                                     social_date = Convert.ToString(rw["social_date"]),
                                     social_report = Convert.ToString(rw["social_report"]),
                                     social_man_dep = Convert.ToString(rw["social_man_dep"]),
                                     social_super = Convert.ToString(rw["social_super"]),
                                     social_worker_opin = Convert.ToString(rw["social_worker_opin"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<social_worker> Get()
        {
            dataset = con_social_worker.get_social_worker();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new social_worker()
                                 {
                                     social_id = Convert.ToInt32(rw["social_id"]),
                                     social_level = Convert.ToString(rw["social_level"]),
                                     social_class = Convert.ToString(rw["social_class"]),
                                     social_dep = Convert.ToString(rw["social_dep"]),
                                     social_students = Convert.ToString(rw["social_students"]),
                                     social_date = Convert.ToString(rw["social_date"]),
                                     social_report = Convert.ToString(rw["social_report"]),
                                     social_man_dep = Convert.ToString(rw["social_man_dep"]),
                                     social_super = Convert.ToString(rw["social_super"]),
                                     social_worker_opin = Convert.ToString(rw["social_worker_opin"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(social_worker objsocial_worker)
        {
            con_social_worker.social_level = objsocial_worker.social_level;
            con_social_worker.social_class = objsocial_worker.social_class;
            con_social_worker.social_dep = objsocial_worker.social_dep;
            con_social_worker.social_students = objsocial_worker.social_students;
            con_social_worker.social_date = objsocial_worker.social_date;
            con_social_worker.social_report = objsocial_worker.social_report;
            con_social_worker.social_man_dep = objsocial_worker.social_man_dep;
            con_social_worker.social_super = objsocial_worker.social_super;
            con_social_worker.social_worker_opin = objsocial_worker.social_worker_opin;

            con_social_worker.save_in_social_worker();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(social_worker objsocial_worker)
        {
            con_social_worker.social_id = objsocial_worker.social_id;
            con_social_worker.social_level = objsocial_worker.social_level;
            con_social_worker.social_class = objsocial_worker.social_class;
            con_social_worker.social_dep = objsocial_worker.social_dep;
            con_social_worker.social_students = objsocial_worker.social_students;
            con_social_worker.social_date = objsocial_worker.social_date;
            con_social_worker.social_report = objsocial_worker.social_report;
            con_social_worker.social_man_dep = objsocial_worker.social_man_dep;
            con_social_worker.social_super = objsocial_worker.social_super;
            con_social_worker.social_worker_opin = objsocial_worker.social_worker_opin;

            con_social_worker.update_social_worker();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_social_worker.social_id = id;
            con_social_worker.delete_from_social_worker();
            return new JsonResult("deleted Successfully");


        }


    }
}