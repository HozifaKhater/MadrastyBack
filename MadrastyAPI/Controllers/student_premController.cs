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
    public class student_premController : ControllerBase
    {
        student_prem con_stu_prem = new student_prem();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<student_prem> Get(int id)
        {
            con_stu_prem.student_prem_id = id;
            dataset = con_stu_prem.get_student_prem_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new student_prem()
                                 {
                                     student_prem_id = Convert.ToInt32(rw["student_prem_id"]),
                                     prem_date = Convert.ToString(rw["prem_date"]),
                                     prem_leave_time = Convert.ToString(rw["prem_leave_time"]),
                                     prem_arrive_time = Convert.ToString(rw["prem_arrive_time"]),
                                     prem_level = Convert.ToString(rw["prem_level"]),
                                     prem_class = Convert.ToString(rw["prem_class"]),
                                     prem_stu_id = Convert.ToInt32(rw["prem_stu_id"]),
                                     prem_stu_name = Convert.ToString(rw["prem_stu_name"]),
                                     prem_state = Convert.ToInt32(rw["prem_state"]),
                                     prem_parent_type = Convert.ToString(rw["prem_parent_type"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<student_prem> Get()
        {
            dataset = con_stu_prem.get_student_prem();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new student_prem()
                                 {
                                     student_prem_id = Convert.ToInt32(rw["student_prem_id"]),
                                     prem_date = Convert.ToString(rw["prem_date"]),
                                     prem_leave_time = Convert.ToString(rw["prem_leave_time"]),
                                     prem_arrive_time = Convert.ToString(rw["prem_arrive_time"]),
                                     prem_level = Convert.ToString(rw["prem_level"]),
                                     prem_class = Convert.ToString(rw["prem_class"]),
                                     prem_stu_id = Convert.ToInt32(rw["prem_stu_id"]),
                                     prem_stu_name = Convert.ToString(rw["prem_stu_name"]),
                                     prem_state = Convert.ToInt32(rw["prem_state"]),
                                     prem_parent_type = Convert.ToString(rw["prem_parent_type"]),
                                      civil_id = Convert.ToInt32(rw["civil_id"]),
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(student_prem objstuprem)
        {
            con_stu_prem.prem_date = objstuprem.prem_date;
            con_stu_prem.prem_leave_time = objstuprem.prem_leave_time;
            con_stu_prem.prem_arrive_time = objstuprem.prem_arrive_time;
            con_stu_prem.prem_level = objstuprem.prem_level;
            con_stu_prem.prem_class = objstuprem.prem_class;
            con_stu_prem.prem_stu_id = objstuprem.prem_stu_id;
            con_stu_prem.prem_stu_name = objstuprem.prem_stu_name;
            con_stu_prem.prem_state = objstuprem.prem_state;
            con_stu_prem.prem_parent_type = objstuprem.prem_parent_type;

            con_stu_prem.save_in_student_prem();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(student_prem objstuprem)
        {
            con_stu_prem.student_prem_id = objstuprem.student_prem_id;
            con_stu_prem.prem_date = objstuprem.prem_date;
            con_stu_prem.prem_leave_time = objstuprem.prem_leave_time;
            con_stu_prem.prem_arrive_time = objstuprem.prem_arrive_time;
            con_stu_prem.prem_level = objstuprem.prem_level;
            con_stu_prem.prem_class = objstuprem.prem_class;
            con_stu_prem.prem_stu_id = objstuprem.prem_stu_id;
            con_stu_prem.prem_stu_name = objstuprem.prem_stu_name;
            con_stu_prem.prem_state = objstuprem.prem_state;
            con_stu_prem.prem_parent_type = objstuprem.prem_parent_type;

            con_stu_prem.update_student_prem();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_stu_prem.student_prem_id = id;
            con_stu_prem.delete_from_student_prem();
            return new JsonResult("deleted Successfully");


        }

    }
}