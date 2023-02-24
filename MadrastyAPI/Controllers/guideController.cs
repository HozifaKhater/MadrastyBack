using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using MadrastyAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class guideController : ControllerBase
    {

        guide con_obj = new guide();

        public DataSet dataset1 { get; set; }
    
        // GET: api/<controller>
        [HttpGet]
        public List<guide> Get()
        {
            dataset1 = con_obj.get_guide();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new guide()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     type_id = Convert.ToInt32(rw["type_id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     services = Convert.ToString(rw["services"]),
                                     ntoes = Convert.ToString(rw["ntoes"]),
                                     
                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(guide obj)
        {
        
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;
            con_obj.level_id = obj.level_id;
            con_obj.level_name = obj.level_name;
            con_obj.class_id = obj.class_id;
            con_obj.class_name = obj.class_name;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.services = obj.services;
            con_obj.ntoes = obj.ntoes;

            con_obj.save_in_guide();

        }
        [HttpGet("id")]
        public List<guide> Get(int id)
        {
            con_obj.id = id;
            dataset1 = con_obj.get_guide_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new guide()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     type_id = Convert.ToInt32(rw["type_id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     services = Convert.ToString(rw["services"]),
                                     ntoes = Convert.ToString(rw["ntoes"]),
                                   
                                 }).ToList();

            return convertedList;
        }


        [HttpPut]
        public JsonResult Put(guide obj)
        {
            con_obj.id = obj.id;
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;
            con_obj.level_id = obj.level_id;
            con_obj.level_name = obj.level_name;
            con_obj.class_id = obj.class_id;
            con_obj.class_name = obj.class_name;
            con_obj.student_id = obj.student_id;
            con_obj.student_name = obj.student_name;
            con_obj.services = obj.services;
            con_obj.ntoes = obj.ntoes;

            con_obj.update_guide();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.id = id;
            con_obj.delete_from_guide();
            return new JsonResult("deleted Successfully");


        }

    }
}