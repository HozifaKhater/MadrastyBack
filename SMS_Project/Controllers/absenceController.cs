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
    public class absenceController : ControllerBase

    {
        absence con_abs = new absence();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<absence> Get(int id)
        {
            con_abs.absence_id = id;
            dataset = con_abs.get_absence_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new absence()
                                 {
                                     absence_id = Convert.ToInt32(rw["absence_id"]),
                                     absence_lev = Convert.ToString(rw["absence_lev"]),
                                     absence_class = Convert.ToString(rw["absence_class"]),
                                     absence_date = Convert.ToString(rw["absence_date"]),
                                     absence_student_id = Convert.ToInt32(rw["absence_student_id"]),
                                     absence_student_name = Convert.ToString(rw["absence_student_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<absence> Get()
        {
            dataset = con_abs.get_absence();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new absence()
                                 {
                                     absence_id = Convert.ToInt32(rw["absence_id"]),
                                     absence_lev = Convert.ToString(rw["absence_lev"]),
                                     absence_class = Convert.ToString(rw["absence_class"]),
                                     absence_date = Convert.ToString(rw["absence_date"]),
                                     absence_student_id = Convert.ToInt32(rw["absence_student_id"]),
                                     absence_student_name = Convert.ToString(rw["absence_student_name"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(absence objabs)
        {
            con_abs.absence_lev = objabs.absence_lev;
            con_abs.absence_class = objabs.absence_class;
            con_abs.absence_date = objabs.absence_date;
            con_abs.absence_student_id = objabs.absence_student_id;
            con_abs.absence_student_name = objabs.absence_student_name;

            con_abs.save_in_absence();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(absence objabs)
        {
            con_abs.absence_id = objabs.absence_id;
            con_abs.absence_lev = objabs.absence_lev;
            con_abs.absence_class = objabs.absence_class;
            con_abs.absence_date = objabs.absence_date;
            con_abs.absence_student_id = objabs.absence_student_id;
            con_abs.absence_student_name = objabs.absence_student_name;

            con_abs.update_absence();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_abs.absence_id = id;
            con_abs.delete_from_absence();
            return new JsonResult("deleted Successfully");


        }
    }
}