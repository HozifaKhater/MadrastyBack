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
    public class visit_typesController : ControllerBase
    {
        visits_types con_vs = new visits_types();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<visits_types> Get(int id)
        {
            con_vs.visit_type_id = id;
            subject = con_vs.get_visits_types_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new visits_types()
                                 {
                                     visit_type_id = Convert.ToInt32(rw["visit_type_id"]),
                                     visit_type_name = Convert.ToString(rw["visit_type_name"]),
                                     is_visit_date = Convert.ToInt32(rw["is_visit_date"]),
                                     visit_date = Convert.ToString(rw["visit_date"]),
                                     is_phone = Convert.ToInt32(rw["is_phone"]),
                                     phone_label = Convert.ToString(rw["phone_label"]),
                                     is_start_time = Convert.ToInt32(rw["is_start_time"]),
                                     start_time_label = Convert.ToString(rw["start_time_label"]),
                                     is_end_time = Convert.ToInt32(rw["is_end_time"]),
                                     end_time_label = Convert.ToString(rw["end_time_label"]),
                                     is_name = Convert.ToInt32(rw["is_name"]),
                                     name_label = Convert.ToString(rw["name_label"]),
                                     is_topic = Convert.ToInt32(rw["is_topic"]),
                                     topic_label = Convert.ToString(rw["topic_label"]),
                                     is_instructions = Convert.ToInt32(rw["is_instructions"]),
                                     instructions_label = Convert.ToString(rw["instructions_label"]),
                                     is_job = Convert.ToInt32(rw["is_job"]),
                                     job_label = Convert.ToString(rw["job_label"]),
                                     is_notes = Convert.ToInt32(rw["is_notes"]),
                                     notes_label = Convert.ToString(rw["notes_label"]),
                                     is_dep = Convert.ToInt32(rw["is_dep"]),
                                     dep_label = Convert.ToString(rw["dep_label"]),
                                     is_vnote = Convert.ToInt32(rw["is_vnote"]),
                                     vnote_label = Convert.ToString(rw["vnote_label"]),
                                     is_vpic = Convert.ToInt32(rw["is_vpic"]),
                                     vpic_label = Convert.ToString(rw["vpic_label"]),
                                     is_emp_from = Convert.ToInt32(rw["is_emp_from"]),
                                     emp_from_label = Convert.ToString(rw["emp_from_label"]),
                                     is_emp_to = Convert.ToInt32(rw["is_emp_to"]),
                                     emp_to_label = Convert.ToString(rw["emp_to_label"]),
                                     is_takeem = Convert.ToInt32(rw["is_takeem"]),
                                     takeem_label = Convert.ToString(rw["takeem_label"])


                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<visits_types> Get()
        {
            subject = con_vs.get_visits_types();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new visits_types()
                                 {
                                     visit_type_id = Convert.ToInt32(rw["visit_type_id"]),
                                     visit_type_name = Convert.ToString(rw["visit_type_name"]),
                                     is_visit_date = Convert.ToInt32(rw["is_visit_date"]),
                                     visit_date = Convert.ToString(rw["visit_date"]),
                                     is_phone = Convert.ToInt32(rw["is_phone"]),
                                     phone_label = Convert.ToString(rw["phone_label"]),
                                     is_start_time = Convert.ToInt32(rw["is_start_time"]),
                                     start_time_label = Convert.ToString(rw["start_time_label"]),
                                     is_end_time = Convert.ToInt32(rw["is_end_time"]),
                                     end_time_label = Convert.ToString(rw["end_time_label"]),
                                     is_name = Convert.ToInt32(rw["is_name"]),
                                     name_label = Convert.ToString(rw["name_label"]),
                                     is_topic = Convert.ToInt32(rw["is_topic"]),
                                     topic_label = Convert.ToString(rw["topic_label"]),
                                     is_instructions = Convert.ToInt32(rw["is_instructions"]),
                                     instructions_label = Convert.ToString(rw["instructions_label"]),
                                     is_job = Convert.ToInt32(rw["is_job"]),
                                     job_label = Convert.ToString(rw["job_label"]),
                                     is_notes = Convert.ToInt32(rw["is_notes"]),
                                     notes_label = Convert.ToString(rw["notes_label"]),
                                     is_dep = Convert.ToInt32(rw["is_dep"]),
                                     dep_label = Convert.ToString(rw["dep_label"]),
                                     is_vnote = Convert.ToInt32(rw["is_vnote"]),
                                     vnote_label = Convert.ToString(rw["vnote_label"]),
                                     is_vpic = Convert.ToInt32(rw["is_vpic"]),
                                     vpic_label = Convert.ToString(rw["vpic_label"]),
                                     is_emp_from = Convert.ToInt32(rw["is_emp_from"]),
                                     emp_from_label = Convert.ToString(rw["emp_from_label"]),
                                     is_emp_to = Convert.ToInt32(rw["is_emp_to"]),
                                     emp_to_label = Convert.ToString(rw["emp_to_label"]),
                                     is_takeem = Convert.ToInt32(rw["is_takeem"]),
                                     takeem_label = Convert.ToString(rw["takeem_label"])


                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(visits_types objsubject)
        {

            con_vs.visit_type_name = objsubject.visit_type_name;
            con_vs.is_visit_date = objsubject.is_visit_date;
            con_vs.visit_date = objsubject.visit_date;
            con_vs.is_phone = objsubject.is_phone;
            con_vs.phone_label = objsubject.phone_label;
            con_vs.is_start_time = objsubject.is_start_time;
            con_vs.start_time_label = objsubject.start_time_label;
            con_vs.is_end_time = objsubject.is_end_time;
            con_vs.end_time_label = objsubject.end_time_label;
            con_vs.is_name = objsubject.is_name;
            con_vs.name_label = objsubject.name_label;
            con_vs.is_topic = objsubject.is_topic;
            con_vs.topic_label = objsubject.topic_label;
            con_vs.is_instructions = objsubject.is_instructions;
            con_vs.instructions_label = objsubject.instructions_label;
            con_vs.is_job = objsubject.is_job;
            con_vs.job_label = objsubject.job_label;
            con_vs.is_notes = objsubject.is_notes;
            con_vs.notes_label = objsubject.notes_label;
            con_vs.is_dep = objsubject.is_dep;
            con_vs.dep_label = objsubject.dep_label;
            con_vs.is_vnote = objsubject.is_vnote;
            con_vs.vnote_label = objsubject.vnote_label;
            con_vs.is_vpic = objsubject.is_vpic;
            con_vs.vpic_label = objsubject.vpic_label;
            con_vs.is_emp_from = objsubject.is_emp_from;
            con_vs.emp_from_label = objsubject.emp_from_label;
            con_vs.is_emp_to = objsubject.is_emp_to;
            con_vs.emp_to_label = objsubject.emp_to_label;
            con_vs.is_takeem = objsubject.is_takeem;
            con_vs.takeem_label = objsubject.takeem_label;




            con_vs.save_in_visits_types();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(visits_types objsubject)
        {
            con_vs.visit_type_id = objsubject.visit_type_id;
            con_vs.visit_type_name = objsubject.visit_type_name;
            con_vs.is_visit_date = objsubject.is_visit_date;
            con_vs.visit_date = objsubject.visit_date;
            con_vs.is_phone = objsubject.is_phone;
            con_vs.phone_label = objsubject.phone_label;
            con_vs.is_start_time = objsubject.is_start_time;
            con_vs.start_time_label = objsubject.start_time_label;
            con_vs.is_end_time = objsubject.is_end_time;
            con_vs.end_time_label = objsubject.end_time_label;
            con_vs.is_name = objsubject.is_name;
            con_vs.name_label = objsubject.name_label;
            con_vs.is_topic = objsubject.is_topic;
            con_vs.topic_label = objsubject.topic_label;
            con_vs.is_instructions = objsubject.is_instructions;
            con_vs.instructions_label = objsubject.instructions_label;
            con_vs.is_job = objsubject.is_job;
            con_vs.job_label = objsubject.job_label;
            con_vs.is_notes = objsubject.is_notes;
            con_vs.notes_label = objsubject.notes_label;
            con_vs.is_dep = objsubject.is_dep;
            con_vs.dep_label = objsubject.dep_label;
            con_vs.is_vnote = objsubject.is_vnote;
            con_vs.vnote_label = objsubject.vnote_label;
            con_vs.is_vpic = objsubject.is_vpic;
            con_vs.vpic_label = objsubject.vpic_label;
            con_vs.is_emp_from = objsubject.is_emp_from;
            con_vs.emp_from_label = objsubject.emp_from_label;
            con_vs.is_emp_to = objsubject.is_emp_to;
            con_vs.emp_to_label = objsubject.emp_to_label;
            con_vs.is_takeem = objsubject.is_takeem;
            con_vs.takeem_label = objsubject.takeem_label;

            con_vs.update_visits_types();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_vs.visit_type_id = id;
            con_vs.delete_from_visits_types();
            return new JsonResult("deleted Successfully");


        }

    }
}