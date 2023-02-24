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
                                     student_class_name = Convert.ToString(rw["student_class_name"]),
                                     birth_cert_no = Convert.ToString(rw["birth_cert_no"]),
                                     birth_cert_source_id = Convert.ToInt32(rw["birth_cert_source_id"]),
                                     birth_cert_source = Convert.ToString(rw["birth_cert_source"]),
                                     birth_cert_date = Convert.ToString(rw["birth_cert_date"]),
                                     birth_location_id = Convert.ToInt32(rw["birth_location_id"]),
                                     birth_location = Convert.ToString(rw["birth_location"]),
                                     gov_id = Convert.ToInt32(rw["gov_id"]),
                                     gov_name = Convert.ToString(rw["gov_name"]),
                                     city_id = Convert.ToInt32(rw["city_id"]),
                                     city_name = Convert.ToString(rw["city_name"]),
                                     elkt3a = Convert.ToInt32(rw["elkt3a"]),
                                     street = Convert.ToString(rw["street"]),
                                     elgada = Convert.ToInt32(rw["elgada"]),
                                     building = Convert.ToInt32(rw["building"]),
                                     build_level = Convert.ToInt32(rw["build_level"]),
                                     apart_no = Convert.ToInt32(rw["apart_no"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     name_in_english = Convert.ToString(rw["name_in_english"]),
                                     guardian_relation_id = Convert.ToInt32(rw["guardian_relation_id"]),
                                     guardian_relation = Convert.ToString(rw["guardian_relation"]),
                                     guardian_civilian_id = Convert.ToString(rw["guardian_civilian_id"]),
                                     guard_mobile = Convert.ToString(rw["guard_mobile"]),
                                     guardian_name = Convert.ToString(rw["guardian_name"]),
                                     work_phone = Convert.ToString(rw["work_phone"]),
                                     work_name = Convert.ToString(rw["work_name"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     email = Convert.ToString(rw["email"]),
                                     guard_gov_id = Convert.ToInt32(rw["guard_gov_id"]),
                                     guard_gov_name = Convert.ToString(rw["guard_gov_name"]),
                                     guard_city_id = Convert.ToInt32(rw["guard_city_id"]),
                                     guard_city_name = Convert.ToString(rw["guard_city_name"]),
                                     guard_kt3a = Convert.ToInt32(rw["guard_kt3a"]),
                                     guard_street = Convert.ToString(rw["guard_street"]),
                                     guard_build = Convert.ToInt32(rw["guard_build"]),
                                     guard_build_level = Convert.ToInt32(rw["guard_build_level"]),
                                     guard_phone = Convert.ToString(rw["guard_phone"]),
                                     mother_name = Convert.ToString(rw["mother_name"]),
                                     mother_civilian_id = Convert.ToString(rw["mother_civilian_id"]),
                                     mother_nat_id = Convert.ToInt32(rw["mother_nat_id"]),
                                     mother_nationality = Convert.ToString(rw["mother_nationality"]),
                                     mother_phone = Convert.ToString(rw["mother_phone"]),
                                     mother_mobile = Convert.ToString(rw["mother_mobile"])

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
            con_stu.student_class_id = objstudent.student_class_id;
            con_stu.student_class_name = objstudent.student_class_name;
            con_stu.birth_cert_no = objstudent.birth_cert_no;
            con_stu.birth_cert_source_id = objstudent.birth_cert_source_id;
            con_stu.birth_cert_source = objstudent.birth_cert_source;
            con_stu.birth_cert_date = objstudent.birth_cert_date;
            con_stu.birth_location_id = objstudent.birth_location_id;
            con_stu.birth_location = objstudent.birth_location;
            con_stu.gov_id = objstudent.gov_id;
            con_stu.gov_name = objstudent.gov_name;
            con_stu.city_id = objstudent.city_id;
            con_stu.city_name = objstudent.city_name;
            con_stu.elkt3a = objstudent.elkt3a;
            con_stu.street = objstudent.street;
            con_stu.elgada = objstudent.elgada;
            con_stu.building = objstudent.building;
            con_stu.build_level = objstudent.build_level;
            con_stu.apart_no = objstudent.apart_no;
            con_stu.phone = objstudent.phone;
            con_stu.name_in_english = objstudent.name_in_english;
            con_stu.guardian_relation_id = objstudent.guardian_relation_id;
            con_stu.guardian_relation = objstudent.guardian_relation;
            con_stu.guardian_civilian_id = objstudent.guardian_civilian_id;
            con_stu.guard_mobile = objstudent.guard_mobile;
            con_stu.guardian_name = objstudent.guardian_name;
            con_stu.work_phone = objstudent.work_phone;
            con_stu.work_name = objstudent.work_name;
            con_stu.job_name = objstudent.job_name;
            con_stu.email = objstudent.email;
            con_stu.guard_gov_id = objstudent.guard_gov_id;
            con_stu.guard_gov_name = objstudent.guard_gov_name;
            con_stu.guard_city_id = objstudent.guard_city_id;
            con_stu.guard_city_name = objstudent.guard_city_name;
            con_stu.guard_kt3a = objstudent.guard_kt3a;
            con_stu.guard_street = objstudent.guard_street;
            con_stu.guard_build = objstudent.guard_build;
            con_stu.guard_build_level = objstudent.guard_build_level;
            con_stu.guard_phone = objstudent.guard_phone;
            con_stu.mother_name = objstudent.mother_name;
            con_stu.mother_civilian_id = objstudent.mother_civilian_id;
            con_stu.mother_nat_id = objstudent.mother_nat_id;
            con_stu.mother_nationality = objstudent.mother_nationality;
            con_stu.mother_phone = objstudent.mother_phone;
            con_stu.mother_mobile = objstudent.mother_mobile;




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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"]),
                                     student_branch = Convert.ToString(rw["student_branch"]),
                                     phone = Convert.ToString(rw["phone"]),


                                 }).ToList();

            return convertedList;
        }

        [HttpPost("update")]
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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"]),
                                     student_class_id = Convert.ToInt32(rw["student_class_id"]),
                                     student_class_name = Convert.ToString(rw["student_class_name"]),
                                     student_branch = Convert.ToString(rw["student_branch"]),
                                     birth_cert_no = Convert.ToString(rw["birth_cert_no"]),
                                     birth_cert_source_id = Convert.ToInt32(rw["birth_cert_source_id"]),
                                     birth_cert_source = Convert.ToString(rw["birth_cert_source"]),
                                     birth_cert_date = Convert.ToString(rw["birth_cert_date"]),
                                     birth_location_id = Convert.ToInt32(rw["birth_location_id"]),
                                     birth_location = Convert.ToString(rw["birth_location"]),
                                     gov_id = Convert.ToInt32(rw["gov_id"]),
                                     gov_name = Convert.ToString(rw["gov_name"]),
                                     city_id = Convert.ToInt32(rw["city_id"]),
                                     city_name = Convert.ToString(rw["city_name"]),
                                     elkt3a = Convert.ToInt32(rw["elkt3a"]),
                                     street = Convert.ToString(rw["street"]),
                                     elgada = Convert.ToInt32(rw["elgada"]),
                                     building = Convert.ToInt32(rw["building"]),
                                     build_level = Convert.ToInt32(rw["build_level"]),
                                     apart_no = Convert.ToInt32(rw["apart_no"]),
                                     phone = Convert.ToString(rw["phone"]),
                                     name_in_english = Convert.ToString(rw["name_in_english"]),
                                     guardian_relation_id = Convert.ToInt32(rw["guardian_relation_id"]),
                                     guardian_relation = Convert.ToString(rw["guardian_relation"]),
                                     guardian_civilian_id = Convert.ToString(rw["guardian_civilian_id"]),
                                     guard_mobile = Convert.ToString(rw["guard_mobile"]),
                                     guardian_name = Convert.ToString(rw["guardian_name"]),
                                     work_phone = Convert.ToString(rw["work_phone"]),
                                     work_name = Convert.ToString(rw["work_name"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     email = Convert.ToString(rw["email"]),
                                     guard_gov_id = Convert.ToInt32(rw["guard_gov_id"]),
                                     guard_gov_name = Convert.ToString(rw["guard_gov_name"]),
                                     guard_city_id = Convert.ToInt32(rw["guard_city_id"]),
                                     guard_city_name = Convert.ToString(rw["guard_city_name"]),
                                     guard_kt3a = Convert.ToInt32(rw["guard_kt3a"]),
                                     guard_street = Convert.ToString(rw["guard_street"]),
                                     guard_build = Convert.ToInt32(rw["guard_build"]),
                                     guard_build_level = Convert.ToInt32(rw["guard_build_level"]),
                                     guard_phone = Convert.ToString(rw["guard_phone"]),
                                     mother_name = Convert.ToString(rw["mother_name"]),
                                     mother_civilian_id = Convert.ToString(rw["mother_civilian_id"]),
                                     mother_nat_id = Convert.ToInt32(rw["mother_nat_id"]),
                                     mother_nationality = Convert.ToString(rw["mother_nationality"]),
                                     mother_phone = Convert.ToString(rw["mother_phone"]),
                                     mother_mobile = Convert.ToString(rw["mother_mobile"])


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
                                     student_failure_years = Convert.ToInt32(rw["student_failure_years"]),
                                     phone = Convert.ToString(rw["phone"]),


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
            con_stu.student_class_id = objstudent.student_class_id;
            con_stu.student_class_name = objstudent.student_class_name;
            con_stu.birth_cert_no = objstudent.birth_cert_no;
            con_stu.birth_cert_source_id = objstudent.birth_cert_source_id;
            con_stu.birth_cert_source = objstudent.birth_cert_source;
            con_stu.birth_cert_date = objstudent.birth_cert_date;
            con_stu.birth_location_id = objstudent.birth_location_id;
            con_stu.birth_location = objstudent.birth_location;
            con_stu.gov_id = objstudent.gov_id;
            con_stu.gov_name = objstudent.gov_name;
            con_stu.city_id = objstudent.city_id;
            con_stu.city_name = objstudent.city_name;
            con_stu.elkt3a = objstudent.elkt3a;
            con_stu.street = objstudent.street;
            con_stu.elgada = objstudent.elgada;
            con_stu.building = objstudent.building;
            con_stu.build_level = objstudent.build_level;
            con_stu.apart_no = objstudent.apart_no;
            con_stu.phone = objstudent.phone;
            con_stu.name_in_english = objstudent.name_in_english;
            con_stu.guardian_relation_id = objstudent.guardian_relation_id;
            con_stu.guardian_relation = objstudent.guardian_relation;
            con_stu.guardian_civilian_id = objstudent.guardian_civilian_id;
            con_stu.guard_mobile = objstudent.guard_mobile;
            con_stu.guardian_name = objstudent.guardian_name;
            con_stu.work_phone = objstudent.work_phone;
            con_stu.work_name = objstudent.work_name;
            con_stu.job_name = objstudent.job_name;
            con_stu.email = objstudent.email;
            con_stu.guard_gov_id = objstudent.guard_gov_id;
            con_stu.guard_gov_name = objstudent.guard_gov_name;
            con_stu.guard_city_id = objstudent.guard_city_id;
            con_stu.guard_city_name = objstudent.guard_city_name;
            con_stu.guard_kt3a = objstudent.guard_kt3a;
            con_stu.guard_street = objstudent.guard_street;
            con_stu.guard_build = objstudent.guard_build;
            con_stu.guard_build_level = objstudent.guard_build_level;
            con_stu.guard_phone = objstudent.guard_phone;
            con_stu.mother_name = objstudent.mother_name;
            con_stu.mother_civilian_id = objstudent.mother_civilian_id;
            con_stu.mother_nat_id = objstudent.mother_nat_id;
            con_stu.mother_nationality = objstudent.mother_nationality;
            con_stu.mother_phone = objstudent.mother_phone;
            con_stu.mother_mobile = objstudent.mother_mobile;

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
                                     
                                       level11 = Convert.ToString(rw["level11"]),

        level12 = Convert.ToString(rw["level12"]),

         student_branch_stat = Convert.ToString(rw["student_branch"]),

                                     total_students = Convert.ToString(rw["total_students"])
                                 }).ToList();

            return convertedList;
        }

    }
}