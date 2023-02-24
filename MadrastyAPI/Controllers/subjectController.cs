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
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
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
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(subject objsubject)
        {
           // con_sub.subject_id = objsubject.subject_id;
            con_sub.subject_name = objsubject.subject_name;
            con_sub.subject_desc = objsubject.subject_desc;
            con_sub.dep_id = objsubject.dep_id;
            con_sub.dep_name = objsubject.dep_name;
            con_sub.parent_id = objsubject.parent_id;
            con_sub.save_in_subject_def();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(subject objsubject)
        {
            con_sub.subject_id = objsubject.subject_id;
            con_sub.subject_name = objsubject.subject_name;
            con_sub.subject_desc = objsubject.subject_desc;
            con_sub.dep_id = objsubject.dep_id;
            con_sub.dep_name = objsubject.dep_name;
            con_sub.parent_id = objsubject.parent_id;
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
        [HttpGet("emp_id")]
        public List<subject> get_subject_with_emp_id(int id)
        {
            con_sub.emp_id = id;
            subject = con_sub.get_subject_with_emp_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new subject()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_subject_id = Convert.ToInt32(rw["emp_subject_id"]),
                                     emp_subject_name = Convert.ToString(rw["emp_subject"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_subject_def_with_dep_id")]
        public List<subject> get_subject_def_with_dep_id(int id)
        {
            con_sub.dep_id = id;
            subject = con_sub.get_subject_def_with_dep_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new subject()
                                 {
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     subject_desc = Convert.ToString(rw["subject_desc"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;
        }

        [HttpGet("get_subject_def_with_class_id")]
        public List<subject> get_subject_def_with_class_id(int id,string date)
        {
            con_sub.dep_id = id;
            subject = con_sub.get_subject_def_with_class_id(id, date);

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new subject()
                                 {
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     subject_desc = Convert.ToString(rw["subject_desc"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;
        }
    }
}