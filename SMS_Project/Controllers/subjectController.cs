using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class subjectController : ControllerBase
    {
        subject con_sub = new subject();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<subject> Get(int id)
        {
            con_sub.subject_id = id;
            subject = con_sub.get_subject_def_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new subject()
                                 {
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     subject_desc = Convert.ToString(rw["subject_desc"]),
                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<subject> Get()
        {
            subject = con_sub.get_subject_def();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new subject()
                                 {
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     subject_desc = Convert.ToString(rw["subject_desc"]),
                                    
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(subject objsubject)
        {
           // con_sub.subject_id = objsubject.subject_id;
            con_sub.subject_name = objsubject.subject_name;
            con_sub.subject_desc = objsubject.subject_desc;

            con_sub.save_in_subject_def();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(subject objsubject)
        {
            con_sub.subject_id = objsubject.subject_id;
            con_sub.subject_name = objsubject.subject_name;
            con_sub.subject_desc = objsubject.subject_desc;

            con_sub.update_subject_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_sub.subject_id = id;
            con_sub.delete_from_subject_def();
            return new JsonResult("deleted Successfully");


        }

    }
}