using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS_Project.Models;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        student con_stu = new student();
        public DataSet dataset1 { get; set; }
        public DataSet get_student_def
        {
            get { return con_stu.get_student_def(); }
        }
        [HttpGet]
        public List<student> Get()
        {

            var convertedList = (from rw in get_student_def.Tables[0].AsEnumerable()
                                 select new student()
                                 {
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     student_file_ser = Convert.ToInt32(rw["student_file_ser"]),
                                     student_civilian_id = Convert.ToString(rw["student_civilian_id"]),
                                     student_nationality = Convert.ToString(rw["student_nationality"]),
                                     student_school = Convert.ToString(rw["student_school"]),
                                     student_class_id = Convert.ToInt32(rw["student_class_id"]),
                                     student_class_name = Convert.ToString(rw["student_class_name"])
                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(student objstudent)
        {
            con_stu.student_id = objstudent.student_id;
            con_stu.student_file_ser = objstudent.student_file_ser;
            con_stu.student_civilian_id = objstudent.student_civilian_id;
            con_stu.student_sex = objstudent.student_sex;
            con_stu.student_sex_id = objstudent.student_sex_id;
            con_stu.student_name = objstudent.student_name;
            con_stu.student_nationality = objstudent.student_nationality;
            con_stu.student_nationality_id = objstudent.student_nationality_id;
            con_stu.student_dob = objstudent.student_dob;
            con_stu.student_age_year = objstudent.student_age_year;
            con_stu.student_age_month = objstudent.student_age_month;
            con_stu.student_age_day = objstudent.student_age_day;
            con_stu.student_acceptance_reason_id = objstudent.student_acceptance_reason_id;
            con_stu.student_acceptance_reason = objstudent.student_acceptance_reason;
            con_stu.student_religion = objstudent.student_religion;
            con_stu.student_religion_id = objstudent.student_religion_id;
            con_stu.student_district = objstudent.student_district;
            con_stu.student_district_id = objstudent.student_district_id;
            con_stu.student_school = objstudent.student_school;
            con_stu.student_stage = objstudent.student_stage;
            con_stu.student_stage_id = objstudent.student_stage_id;
            con_stu.student_state = objstudent.student_state;
            con_stu.student_state_id = objstudent.student_state_id;
            con_stu.student_study_state = objstudent.student_study_state;
            con_stu.student_study_state_id = objstudent.student_study_state_id;
            con_stu.student_grade = objstudent.student_grade;
            con_stu.student_grade_id = objstudent.student_grade_id;
            con_stu.student_div = objstudent.student_div;
            con_stu.student_div_id = objstudent.student_div_id;
            con_stu.student_failure_years = objstudent.student_failure_years;



            con_stu.update_student_def();
            return new JsonResult("Updated Successfully");
        }

        [HttpGet("class_id")]
        public List<student> get_students_with_class_id(int class_id)
        {
            con_stu.student_class_id = class_id;
            dataset1 = con_stu.get_students_with_class_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"])


                                 }).ToList();

            return convertedList;
        }

        [HttpPut("update")]
        public JsonResult update_student_branch(student objstudent)
        {
            con_stu.student_id = objstudent.student_id;
            con_stu.student_branch = objstudent.student_branch;



            con_stu.update_student_branch();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_stu.student_id = id;

            con_stu.delete_from_student_def();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<student> Get(int id)
        {
            con_stu.student_id = id;
            dataset1 = con_stu.get_student_def_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"])


                                 }).ToList();

            return convertedList;
        }

        [HttpGet("grade_id")]
        public List<student> Get(int grade_id, Boolean x)
        {
            con_stu.student_id = grade_id;
            dataset1 = con_stu.get_students_with_grade_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"])


                                 }).ToList();

            return convertedList;
        }

        [HttpPost]
        public JsonResult Post(student objstudent)
        {
            con_stu.student_id = objstudent.student_id;
            con_stu.student_file_ser = objstudent.student_file_ser;
            con_stu.student_civilian_id = objstudent.student_civilian_id;
            con_stu.student_sex = objstudent.student_sex;
            con_stu.student_sex_id = objstudent.student_sex_id;
            con_stu.student_name = objstudent.student_name;
            con_stu.student_nationality = objstudent.student_nationality;
            con_stu.student_nationality_id = objstudent.student_nationality_id;
            con_stu.student_dob = objstudent.student_dob;
            con_stu.student_age_month = objstudent.student_age_month;
            con_stu.student_age_day = objstudent.student_age_day;
            con_stu.student_acceptance_reason_id = objstudent.student_acceptance_reason_id;
            con_stu.student_acceptance_reason = objstudent.student_acceptance_reason;
            con_stu.student_religion = objstudent.student_religion;
            con_stu.student_religion_id = objstudent.student_religion_id;
            con_stu.student_district = objstudent.student_district;
            con_stu.student_district_id = objstudent.student_district_id;
            con_stu.student_school = objstudent.student_school;
            con_stu.student_stage = objstudent.student_stage;
            con_stu.student_stage_id = objstudent.student_stage_id;
            con_stu.student_state = objstudent.student_state;
            con_stu.student_state_id = objstudent.student_state_id;
            con_stu.student_study_state = objstudent.student_study_state;
            con_stu.student_study_state_id = objstudent.student_study_state_id;
            con_stu.student_grade = objstudent.student_grade;
            con_stu.student_grade_id = objstudent.student_grade_id;
            con_stu.student_div = objstudent.student_div;
            con_stu.student_div_id = objstudent.student_div_id;
            con_stu.student_failure_years = objstudent.student_failure_years;

            con_stu.save_in_student_def();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("start_year")]
        public List<student> Get(int id, string x)
        
        {
            con_stu.student_id = id;
            dataset1 = con_stu.get_start_date_from_school_year_config();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student()
                                 {
                                     start_year_date = Convert.ToString(rw["start_year_date"]),

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_branch_stistics")]
        public List<student> get_branch_stistics()

        {
          
            dataset1 = con_stu.get_branch_stistics();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new student()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     
                                       hady_34r = Convert.ToString(rw["hady_34r"]),

        sany_34r = Convert.ToString(rw["sany_34r"]),

         sho3ba = Convert.ToString(rw["sho3ba"]),

                                     student_count = Convert.ToString(rw["student_count"])
                                 }).ToList();

            return convertedList;
        }

    }
}