using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class twze3_studentsController : ControllerBase
    {

        twze3_students con_twze3 = new twze3_students();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<twze3_students> Get(int id)
        {
            con_twze3.twze3_id = id;
            dataset = con_twze3.get_twze3_students_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new twze3_students()
                                 {
                                     twze3_id = Convert.ToInt32(rw["twze3_id"]),
                                     twze3_lev = Convert.ToString(rw["twze3_lev"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"])

                                 }).ToList();

            return convertedList;
        }

        [HttpGet("student_id")]
        public List<twze3_students> Get(int student_id ,string x)
        {
            con_twze3.twze3_id = student_id;
            dataset = con_twze3.check_student_in_class();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new twze3_students()
                                 {
                             
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"])
                          

                                 }).ToList();

            return convertedList;
        }

        [HttpGet("student_grade_id")]
        public List<student> Get_student_grade_id(int student_grade_id)
        {
            con_twze3.student_grade_id = student_grade_id;
            dataset = con_twze3.get_students_with_grade_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new student()
                                 {
                        
                              student_id = Convert.ToInt32(rw["student_id"]),
                                     student_file_ser = Convert.ToInt32(rw["student_file_ser"]),
                                     student_civilian_id = Convert.ToString(rw["student_civilian_id"]),
                                     student_sex = Convert.ToString(rw["student_sex"]),
                                     student_sex_id = Convert.ToInt32(rw["student_sex_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     student_nationality = Convert.ToString(rw["student_nationality"]),
                                     student_nationality_id = Convert.ToInt32(rw["student_nationality_id"]),
                                     student_dob = Convert.ToString(rw["student_dob"]),
                                     student_age_year = Convert.ToInt32(rw["student_age_year"]),
                                     student_age_month = Convert.ToInt32(rw["student_age_month"]),
                                     student_age_day = Convert.ToInt32(rw["student_age_day"]),
                                     student_acceptance_reason_id = Convert.ToInt32(rw["student_acceptance_reason_id"]),
                                     student_acceptance_reason = Convert.ToString(rw["student_acceptance_reason"]),
                                     student_religion = Convert.ToString(rw["student_religion"]),
                                     student_religion_id = Convert.ToInt32(rw["student_religion_id"]),
                                     student_district = Convert.ToString(rw["student_district"]),
                                     student_district_id = Convert.ToInt32(rw["student_district_id"]),
                                     student_school = Convert.ToString(rw["student_school"]),
                                     student_stage = Convert.ToString(rw["student_stage"]),
                                     student_stage_id = Convert.ToInt32(rw["student_stage_id"]),
                                     student_state = Convert.ToString(rw["student_state"]),
                                     student_state_id = Convert.ToInt32(rw["student_state_id"]),
                                     student_study_state = Convert.ToString(rw["student_study_state"]),
                                     student_study_state_id = Convert.ToInt32(rw["student_study_state_id"]),
                                     student_grade = Convert.ToString(rw["student_grade"]),
                                     student_grade_id = Convert.ToInt32(rw["student_grade_id"]),
                                     student_div = Convert.ToString(rw["student_div"]),
                                     student_div_id = Convert.ToInt32(rw["student_div_id"]),
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"]),
                                     student_class_id = Convert.ToInt32(rw["student_class_id"]),
                                     student_class_name = Convert.ToString(rw["student_class_name"])

                                 }).ToList();

            return convertedList;
        }

        [HttpGet]
        public List<twze3_students> Get()
        {
            dataset = con_twze3.get_twze3_students();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new twze3_students()
                                 {
                                     twze3_id = Convert.ToInt32(rw["twze3_id"]),
                                     twze3_lev = Convert.ToString(rw["twze3_lev"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(twze3_students objtwze3_students)
        {
            con_twze3.twze3_lev = objtwze3_students.twze3_lev;
            con_twze3.student_id = objtwze3_students.student_id;
            con_twze3.student_name = objtwze3_students.student_name;
            con_twze3.class_id = objtwze3_students.class_id;
            con_twze3.class_name = objtwze3_students.class_name;

            con_twze3.save_in_twze3_students();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(twze3_students objtwze3_students)
        {
            con_twze3.twze3_id = objtwze3_students.twze3_id;
            con_twze3.twze3_lev = objtwze3_students.twze3_lev;
            con_twze3.student_id = objtwze3_students.student_id;
            con_twze3.student_name = objtwze3_students.student_name;
            con_twze3.class_id = objtwze3_students.class_id;
            con_twze3.class_name = objtwze3_students.class_name;

            con_twze3.update_twze3_students();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_twze3.twze3_id = id;
            con_twze3.delete_from_twze3_students();
            return new JsonResult("deleted Successfully");


        }

    }
}