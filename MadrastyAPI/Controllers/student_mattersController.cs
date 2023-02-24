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
    public class student_mattersController : ControllerBase
    {
        student_matters con_sub = new student_matters();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<student_matters> Get(int id)
        {
            con_sub.id = id;
            subject = con_sub.get_student_matters_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new student_matters()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     note_date = Convert.ToString(rw["note_date"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     ntoes = Convert.ToString(rw["ntoes"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<student_matters> Get()
        {
            subject = con_sub.get_student_matters();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new student_matters()
                                 {
                                     
                                     id = Convert.ToInt32(rw["id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     note_date = Convert.ToString(rw["note_date"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     ntoes = Convert.ToString(rw["ntoes"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),


                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(student_matters objsubject)
        {
           // con_sub.id = objsubject.id;
            con_sub.level_id = objsubject.level_id;
            con_sub.level_name = objsubject.level_name;
            con_sub.class_id = objsubject.class_id;
            con_sub.class_name = objsubject.class_name;
            con_sub.note_date = objsubject.note_date;
            con_sub.topic = objsubject.topic;
            con_sub.ntoes = objsubject.ntoes;
            con_sub.student_id = objsubject.student_id;
            con_sub.student_name = objsubject.student_name;


            con_sub.save_in_student_matters();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(student_matters objsubject)
        {
            con_sub.id = objsubject.id;
            con_sub.level_id = objsubject.level_id;
            con_sub.level_name = objsubject.level_name;
            con_sub.class_id = objsubject.class_id;
            con_sub.class_name = objsubject.class_name;
            con_sub.note_date = objsubject.note_date;
            con_sub.topic = objsubject.topic;
            con_sub.ntoes = objsubject.ntoes;
            con_sub.student_id = objsubject.student_id;
            con_sub.student_name = objsubject.student_name;

            con_sub.update_student_matters();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_sub.id = id;
            con_sub.delete_from_student_matters();
            return new JsonResult("deleted Successfully");


        }
    }
}