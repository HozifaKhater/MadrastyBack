using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  BusinessLogic.Abstractions;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        /*
        private readonly IEmployeeService _employeeService;

        public employeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _employeeService.GetEmployees());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            return Ok(await _employeeService.GetEmployeeById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveEmployee(employee employee)
        {
            return Ok(await _employeeService.SaveEmployee(employee));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(employee employee)
        {
            return Ok(await _employeeService.UpdateEmployee(employee));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return Ok(await _employeeService.DeleteEmployee(id));
        }

        [HttpGet("dep_id")]
        public async Task<IActionResult> GetEmployeeByDeptId(int dept_id)
        {
            return Ok(await _employeeService.GetEmployeeByDeptId(dept_id));
        }
        */
       
        employee con_emp = new employee();
        public DataSet dataset1 { get; set; }

        [HttpGet]
        public List<employee> Get()
        {

            dataset1 = con_emp.get_emp_def();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new employee()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_nationality = Convert.ToString(rw["emp_nationality"]),
                                     emp_civilian_id = Convert.ToString(rw["emp_civilian_id"]),
                                 }).ToList();

            return convertedList;
        }


        [HttpPost]
        public JsonResult Post(employee objemployee)
        {
            //con_emp.emp_id = objemployee.emp_id;
            con_emp.emp_civilian_id = objemployee.emp_civilian_id;
            con_emp.emp_sex = objemployee.emp_sex;
            con_emp.emp_sex_id = objemployee.emp_sex_id;
            con_emp.emp_name = objemployee.emp_name;
            con_emp.emp_nationality = objemployee.emp_nationality;
            con_emp.emp_nationality_id = objemployee.emp_nationality_id;
            con_emp.emp_marital_status = objemployee.emp_marital_status;
            con_emp.emp_marital_status_id = objemployee.emp_marital_status_id;
            con_emp.emp_file_ser = objemployee.emp_file_ser;
            con_emp.emp_dob = objemployee.emp_dob;
            con_emp.emp_age_year = objemployee.emp_age_year;

            con_emp.emp_age_month = objemployee.emp_age_month;
            con_emp.emp_age_day = objemployee.emp_age_day;
            con_emp.emp_pos_type = objemployee.emp_pos_type;
            con_emp.emp_pos_type_id = objemployee.emp_pos_type_id;
            con_emp.emp_pos = objemployee.emp_pos;
            con_emp.emp_pos_id = objemployee.emp_pos_id;
            con_emp.emp_dep = objemployee.emp_dep;
            con_emp.emp_dep_id = objemployee.emp_dep_id;
            con_emp.emp_subject = objemployee.emp_subject;
            con_emp.emp_subject_id = objemployee.emp_subject_id;
            con_emp.emp_div = objemployee.emp_div;
            con_emp.emp_div_id = objemployee.emp_div_id;

            con_emp.emp_contract = objemployee.emp_contract;
            con_emp.emp_contract_id = objemployee.emp_contract_id;
            con_emp.emp_employment_date = objemployee.emp_employment_date;
            con_emp.emp_educationa_qualification = objemployee.emp_educationa_qualification;
            con_emp.emp_educationa_qualification_id = objemployee.emp_educationa_qualification_id;
            con_emp.emp_educationa_qualification_date = objemployee.emp_educationa_qualification_date;
            con_emp.emp_educationa_qualification_country = objemployee.emp_educationa_qualification_country;
            con_emp.emp_educationa_qualification_country_id = objemployee.emp_educationa_qualification_country_id;
            con_emp.emp_exp_out_country = objemployee.emp_exp_out_country;
            con_emp.emp_exp_in_country_same_grade = objemployee.emp_exp_in_country_same_grade;
            con_emp.emp_exp_in_country_another_grade = objemployee.emp_exp_in_country_another_grade;
            con_emp.emp_exp_in_country_same_school = objemployee.emp_exp_in_country_same_school;

            con_emp.emp_address = objemployee.emp_address;
            con_emp.emp_email = objemployee.emp_email;
            con_emp.emp_mob = objemployee.emp_mob;
            con_emp.emp_mob1 = objemployee.emp_mob1;
            con_emp.emp_tel = objemployee.emp_tel;
            con_emp.emp_username = objemployee.emp_username;
            con_emp.emp_password = objemployee.emp_password;
            con_emp.in_class_priv = objemployee.in_class_priv;
            con_emp.dep_work = objemployee.dep_work;
            con_emp.relgion_id = objemployee.relgion_id;
            con_emp.religion_name = objemployee.religion_name;
            con_emp.emp_dep_parent = objemployee.emp_dep_parent;

            con_emp.save_in_emp_def();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("id")]
        public List<employee> Get(int id)
        {
            con_emp.emp_id = id;
            dataset1 = con_emp.get_emp_def_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new employee()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_civilian_id = Convert.ToString(rw["emp_civilian_id"]),
                                     emp_sex = Convert.ToString(rw["emp_sex"]),
                                     emp_sex_id = Convert.ToInt32(rw["emp_sex_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_nationality = Convert.ToString(rw["emp_nationality"]),
                                     emp_nationality_id = Convert.ToInt32(rw["emp_nationality_id"]),
                                     emp_marital_status = Convert.ToString(rw["emp_marital_status"]),
                                     emp_marital_status_id = Convert.ToInt32(rw["emp_marital_status_id"]),
                                     emp_file_ser = Convert.ToInt32(rw["emp_file_ser"]),
                                     emp_dob = Convert.ToString(rw["emp_dob"]),
                                     emp_age_year = Convert.ToInt32(rw["emp_age_year"]),
                                     emp_age_month = Convert.ToInt32(rw["emp_age_month"]),
                                     emp_age_day = Convert.ToInt32(rw["emp_age_day"]),
                                     emp_pos_type = Convert.ToString(rw["emp_pos_type"]),
                                     emp_pos_type_id = Convert.ToInt32(rw["emp_pos_type_id"]),
                                     emp_pos = Convert.ToString(rw["emp_pos"]),
                                     emp_pos_id = Convert.ToInt32(rw["emp_pos_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),
                                     emp_dep_id = Convert.ToInt32(rw["emp_dep_id"]),
                                     emp_subject = Convert.ToString(rw["emp_subject"]),
                                     emp_subject_id = Convert.ToInt32(rw["emp_subject_id"]),
                                     emp_div = Convert.ToString(rw["emp_div"]),
                                     emp_div_id = Convert.ToInt32(rw["emp_div_id"]),
                                     emp_contract = Convert.ToString(rw["emp_contract"]),
                                     emp_contract_id = Convert.ToInt32(rw["emp_contract_id"]),
                                     emp_employment_date = Convert.ToString(rw["emp_employment_date"]),
                                     emp_educationa_qualification = Convert.ToString(rw["emp_educationa_qualification"]),
                                     emp_educationa_qualification_id = Convert.ToInt32(rw["emp_educationa_qualification_id"]),
                                     emp_educationa_qualification_date = Convert.ToString(rw["emp_educationa_qualification_date"]),
                                     emp_educationa_qualification_country = Convert.ToString(rw["emp_educationa_qualification_country"]),
                                     emp_educationa_qualification_country_id = Convert.ToInt32(rw["emp_educationa_qualification_country_id"]),
                                     emp_exp_out_country = Convert.ToInt32(rw["emp_exp_out_country"]),
                                     emp_exp_in_country_same_grade = Convert.ToInt32(rw["emp_exp_in_country_same_grade"]),
                                     emp_exp_in_country_another_grade = Convert.ToInt32(rw["emp_exp_in_country_another_grade"]),
                                     emp_exp_in_country_same_school = Convert.ToInt32(rw["emp_exp_in_country_same_school"]),
                                     emp_address = Convert.ToString(rw["emp_address"]),
                                     emp_email = Convert.ToString(rw["emp_email"]),
                                     emp_mob = Convert.ToString(rw["emp_mob"]),
                                     emp_mob1 = Convert.ToString(rw["emp_mob1"]),
                                     emp_tel = Convert.ToString(rw["emp_tel"]),
                                     emp_username = Convert.ToString(rw["emp_username"]),
                                     emp_password = Convert.ToString(rw["emp_password"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"]),
                                     relgion_id = Convert.ToInt32(rw["relgion_id"]),
                                     religion_name = Convert.ToString(rw["religion_name"]),
                                     emp_dep_parent = Convert.ToInt32(rw["emp_dep_parent"])
                                     //school_id = Convert.ToInt32(rw["school_id"])

                                 }).ToList();

            return convertedList;
        }

        [HttpGet("dep_id")]
        public List<employee> get_emp_def_with_dep_id(int dep_id)
        {
            con_emp.dep_id = dep_id;
            dataset1 = con_emp.get_emp_def_with_dep_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new employee()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),

                                 }).ToList();

            return convertedList;
        }

        [HttpPut]
        public JsonResult Put(employee objemployee)
        {
            con_emp.emp_id = objemployee.emp_id;
            con_emp.emp_civilian_id = objemployee.emp_civilian_id;
            con_emp.emp_sex = objemployee.emp_sex;
            con_emp.emp_sex_id = objemployee.emp_sex_id;
            con_emp.emp_name = objemployee.emp_name;
            con_emp.emp_nationality = objemployee.emp_nationality;
            con_emp.emp_nationality_id = objemployee.emp_nationality_id;
            con_emp.emp_marital_status = objemployee.emp_marital_status;
            con_emp.emp_marital_status_id = objemployee.emp_marital_status_id;
            con_emp.emp_file_ser = objemployee.emp_file_ser;
            con_emp.emp_dob = objemployee.emp_dob;
            con_emp.emp_age_year = objemployee.emp_age_year;

            con_emp.emp_age_month = objemployee.emp_age_month;
            con_emp.emp_age_day = objemployee.emp_age_day;
            con_emp.emp_pos_type = objemployee.emp_pos_type;
            con_emp.emp_pos_type_id = objemployee.emp_pos_type_id;
            con_emp.emp_pos = objemployee.emp_pos;
            con_emp.emp_pos_id = objemployee.emp_pos_id;
            con_emp.emp_dep = objemployee.emp_dep;
            con_emp.emp_dep_id = objemployee.emp_dep_id;
            con_emp.emp_subject = objemployee.emp_subject;
            con_emp.emp_subject_id = objemployee.emp_subject_id;
            con_emp.emp_div = objemployee.emp_div;
            con_emp.emp_div_id = objemployee.emp_div_id;

            con_emp.emp_contract = objemployee.emp_contract;
            con_emp.emp_contract_id = objemployee.emp_contract_id;
            con_emp.emp_employment_date = objemployee.emp_employment_date;
            con_emp.emp_educationa_qualification = objemployee.emp_educationa_qualification;
            con_emp.emp_educationa_qualification_id = objemployee.emp_educationa_qualification_id;
            con_emp.emp_educationa_qualification_date = objemployee.emp_educationa_qualification_date;
            con_emp.emp_educationa_qualification_country = objemployee.emp_educationa_qualification_country;
            con_emp.emp_educationa_qualification_country_id = objemployee.emp_educationa_qualification_country_id;
            con_emp.emp_exp_out_country = objemployee.emp_exp_out_country;
            con_emp.emp_exp_in_country_same_grade = objemployee.emp_exp_in_country_same_grade;
            con_emp.emp_exp_in_country_another_grade = objemployee.emp_exp_in_country_another_grade;
            con_emp.emp_exp_in_country_same_school = objemployee.emp_exp_in_country_same_school;

            con_emp.emp_address = objemployee.emp_address;
            con_emp.emp_email = objemployee.emp_email;
            con_emp.emp_mob = objemployee.emp_mob;
            con_emp.emp_mob1 = objemployee.emp_mob1;
            con_emp.emp_tel = objemployee.emp_tel;
            con_emp.emp_username = objemployee.emp_username;
            con_emp.emp_password = objemployee.emp_password;
            con_emp.in_class_priv = objemployee.in_class_priv;
            con_emp.dep_work = objemployee.dep_work;
            con_emp.relgion_id = objemployee.relgion_id;
            con_emp.religion_name = objemployee.religion_name;
            con_emp.emp_dep_parent = objemployee.emp_dep_parent;
            con_emp.update_emp_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_emp.emp_id = id;
            con_emp.delete_from_emp_def();
            return new JsonResult("deleted Successfully");


        }
        [HttpPost("update_emp_def_connection_id")]
        public JsonResult update_emp_def_connection_id(employee objemployee)
        {
            con_emp.emp_id = objemployee.emp_id;
            con_emp.connection_id = objemployee.connection_id;


            con_emp.update_emp_def_connection_id();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("get_emp_def_with_subject_id")]
        public List<employee> get_emp_def_with_subject_id(int id)
        {
            con_emp.subject_id = id;
            dataset1 = con_emp.get_emp_def_with_subject_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new employee()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_emp_def_with_subject_id_with_validation")]
        public List<employee> get_emp_def_with_subject_id_with_validation(int id, string date)
        {
            con_emp.start_date = date;
            con_emp.subject_id = id;
            dataset1 = con_emp.get_emp_def_with_subject_id_with_validation();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new employee()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),

                                 }).ToList();

            return convertedList;
        }
    }
}