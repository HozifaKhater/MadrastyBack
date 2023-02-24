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
    public class mentality_inquiriesController : ControllerBase
    {
        mentality_inquiries con_act = new mentality_inquiries();

        public DataSet dataset1 { get; set; }
       
        // GET: api/<controller>
        [HttpGet]
        public List<mentality_inquiries> Get()
        {
            dataset1 = con_act.get_mentality_inquiries();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new mentality_inquiries()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     problem_type = Convert.ToString(rw["problem_type"]),
                                     answer = Convert.ToString(rw["answer"]),
                                     ntoes = Convert.ToString(rw["ntoes"])

                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public JsonResult Post(mentality_inquiries obj)
        {
           
            con_act.problem_type = obj.problem_type;
            con_act.answer = obj.answer;
            con_act.ntoes = obj.ntoes;
           
            con_act.save_in_mentality_inquiries();
            return new JsonResult("Saved Successfully");
        }
        [HttpGet("id")]
        public List<mentality_inquiries> Get(int id)
        {
            con_act.id = id;
            dataset1 = con_act.get_mentality_inquiries_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new mentality_inquiries()
                                 {

                                     id = Convert.ToInt32(rw["id"]),
                                     problem_type = Convert.ToString(rw["problem_type"]),
                                     answer = Convert.ToString(rw["answer"]),
                                     ntoes = Convert.ToString(rw["ntoes"])
                                 }).ToList();

            return convertedList;
        }


        [HttpPut]
        public JsonResult Put(mentality_inquiries obj)
        {
            con_act.id = obj.id;
            con_act.problem_type = obj.problem_type;
            con_act.answer = obj.answer;
            con_act.ntoes = obj.ntoes;

            con_act.update_mentality_inquiries();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_act.id = id;
            con_act.delete_from_mentality_inquiries();
            return new JsonResult("deleted Successfully");


        }
    }
}