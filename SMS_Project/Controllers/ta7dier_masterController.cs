using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS_project.Models;

namespace SMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ta7dier_masterController : ControllerBase
    {
        ta7dier_master con_t7m = new ta7dier_master();
        public DataSet dataset1 { get; set; }
        public JsonResult Post(ta7dier_master objta7dier_master)
        {
            con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
            con_t7m.emp_id = objta7dier_master.emp_id;
            con_t7m.emp_name = objta7dier_master.emp_name;
            con_t7m.subject_id = objta7dier_master.subject_id;
            con_t7m.subject_name = objta7dier_master.subject_name;
            con_t7m.grade_id = objta7dier_master.grade_id;
            con_t7m.grade_name = objta7dier_master.grade_name;
            con_t7m.ta7dier_date = objta7dier_master.ta7dier_date;
            con_t7m.ta7dier_week = objta7dier_master.ta7dier_week;
            con_t7m.ta7dier_day = objta7dier_master.ta7dier_day;
            con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
            con_t7m.state_name = objta7dier_master.state_name;
            con_t7m.ta7dier_name = objta7dier_master.ta7dier_name;
            con_t7m.ta7dier_body = objta7dier_master.ta7dier_body;
            con_t7m.ta7dier_notes = objta7dier_master.ta7dier_notes;
            con_t7m.ta7dier_supervision_state_id = objta7dier_master.ta7dier_supervision_state_id;
            con_t7m.ta7dier_supervision_state_name = objta7dier_master.ta7dier_supervision_state_name;
            con_t7m.ta7dier_state_name = objta7dier_master.ta7dier_state_name;

            con_t7m.save_in_ta7dier_master();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(ta7dier_master objta7dier_master)
        {
            con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
            con_t7m.emp_id = objta7dier_master.emp_id;
            con_t7m.emp_name = objta7dier_master.emp_name;
            con_t7m.subject_id = objta7dier_master.subject_id;
            con_t7m.subject_name = objta7dier_master.subject_name;
            con_t7m.grade_id = objta7dier_master.grade_id;
            con_t7m.grade_name = objta7dier_master.grade_name;
            con_t7m.ta7dier_date = objta7dier_master.ta7dier_date;
            con_t7m.ta7dier_week = objta7dier_master.ta7dier_week;
            con_t7m.ta7dier_day = objta7dier_master.ta7dier_day;
            con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
            con_t7m.state_name = objta7dier_master.state_name;
            con_t7m.ta7dier_name = objta7dier_master.ta7dier_name;
            con_t7m.ta7dier_body = objta7dier_master.ta7dier_body;
            con_t7m.ta7dier_notes = objta7dier_master.ta7dier_notes;
            con_t7m.ta7dier_supervision_state_id = objta7dier_master.ta7dier_supervision_state_id;
            con_t7m.ta7dier_supervision_state_name = objta7dier_master.ta7dier_supervision_state_name;
            con_t7m.ta7dier_state_name = objta7dier_master.ta7dier_state_name;
            con_t7m.update_ta7dier_master();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_t7m.ta7dier_id = id;
            con_t7m.delete_from_ta7dier_master();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet]
        public List<ta7dier_master> Get()
        {
            dataset1 = con_t7m.get_ta7dier_master();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                     state_name = Convert.ToString(rw["state_name"]),
                                     ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                     ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                     ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                     ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                     ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                     ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpGet("id")]
        public List<ta7dier_master> Get(int id)
        {
            con_t7m.ta7dier_id = id;
            dataset1 = con_t7m.get_ta7dier_master_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                     state_name = Convert.ToString(rw["state_name"]),
                                     ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                     ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                     ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                     ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                     ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                     ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("subject_id")]
        public List<ta7dier_master> Get(int subject_id, string x)
        {
            con_t7m.subject_id = subject_id;
            dataset1 = con_t7m.get_ta7dier_master_with_subject_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ta7dier_master()
                                 {
                                     ta7dier_id = Convert.ToInt32(rw["ta7dier_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     grade_name = Convert.ToString(rw["grade_name"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     ta7dier_state_id = Convert.ToInt32(rw["ta7dier_state_id"]),
                                     state_name = Convert.ToString(rw["state_name"]),
                                     ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                     ta7dier_body = Convert.ToString(rw["ta7dier_body"]),
                                     ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                     ta7dier_supervision_state_id = Convert.ToInt32(rw["ta7dier_supervision_state_id"]),
                                     ta7dier_supervision_state_name = Convert.ToString(rw["ta7dier_supervision_state_name"]),
                                     ta7dier_state_name = Convert.ToString(rw["ta7dier_state_name"]),
                                 }).ToList();

            return convertedList;
        }
    }
}