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
    public class failure_casesController : ControllerBase
    {
        failure_cases con_fail = new failure_cases();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<failure_cases> Get(int id)
        {
            con_fail.fail_id = id;
            dataset = con_fail.get_failure_cases_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new failure_cases()
                                 {
                                     fail_id = Convert.ToInt32(rw["fail_id"]),
                                     fail_lev = Convert.ToString(rw["fail_lev"]),
                                     fail_class = Convert.ToString(rw["fail_class"]),
                                     fail_student = Convert.ToString(rw["fail_student"]),
                                     fail_nation = Convert.ToString(rw["fail_nation"]),
                                     fail_mob = Convert.ToInt32(rw["fail_mob"]),
                                     fail_birth = Convert.ToString(rw["fail_birth"]),
                                     fail_date = Convert.ToString(rw["fail_date"]),
                                     fail_desc = Convert.ToString(rw["fail_desc"]),
                                     fail_reason = Convert.ToString(rw["fail_reason"]),
                                     fail_sub = Convert.ToString(rw["fail_sub"]),
                                     fail_1 = Convert.ToInt32(rw["fail_1"]),
                                     fail_2 = Convert.ToInt32(rw["fail_2"]),
                                     fail_3 = Convert.ToInt32(rw["fail_3"]),
                                     fail_4 = Convert.ToInt32(rw["fail_4"]),
                                     fail_end_year = Convert.ToInt32(rw["fail_end_year"]),
                                     fail_sit = Convert.ToString(rw["fail_sit"]),
                                     fail_eff_date = Convert.ToString(rw["fail_eff_date"]),
                                     fail_eff_results = Convert.ToString(rw["fail_eff_results"]),
                                     fail_recomm = Convert.ToString(rw["fail_recomm"])


                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<failure_cases> Get()
        {
            dataset = con_fail.get_failure_cases();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new failure_cases()
                                 {
                                     fail_id = Convert.ToInt32(rw["fail_id"]),
                                     fail_lev = Convert.ToString(rw["fail_lev"]),
                                     fail_class = Convert.ToString(rw["fail_class"]),
                                     fail_student = Convert.ToString(rw["fail_student"]),
                                     fail_nation = Convert.ToString(rw["fail_nation"]),
                                     fail_mob = Convert.ToInt32(rw["fail_mob"]),
                                     fail_birth = Convert.ToString(rw["fail_birth"]),
                                     fail_date = Convert.ToString(rw["fail_date"]),
                                     fail_desc = Convert.ToString(rw["fail_desc"]),
                                     fail_reason = Convert.ToString(rw["fail_reason"]),
                                     fail_sub = Convert.ToString(rw["fail_sub"]),
                                     fail_1 = Convert.ToInt32(rw["fail_1"]),
                                     fail_2 = Convert.ToInt32(rw["fail_2"]),
                                     fail_3 = Convert.ToInt32(rw["fail_3"]),
                                     fail_4 = Convert.ToInt32(rw["fail_4"]),
                                     fail_end_year = Convert.ToInt32(rw["fail_end_year"]),
                                     fail_sit = Convert.ToString(rw["fail_sit"]),
                                     fail_eff_date = Convert.ToString(rw["fail_eff_date"]),
                                     fail_eff_results = Convert.ToString(rw["fail_eff_results"]),
                                     fail_recomm = Convert.ToString(rw["fail_recomm"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(failure_cases objfail)
        {

            con_fail.fail_lev = objfail.fail_lev;
            con_fail.fail_class = objfail.fail_class;
            con_fail.fail_student = objfail.fail_student;
            con_fail.fail_nation = objfail.fail_nation;
            con_fail.fail_mob = objfail.fail_mob;
            con_fail.fail_birth = objfail.fail_birth;
            con_fail.fail_date = objfail.fail_date;
            con_fail.fail_desc = objfail.fail_desc;
            con_fail.fail_reason = objfail.fail_reason;
            con_fail.fail_sub = objfail.fail_sub;
            con_fail.fail_1 = objfail.fail_1;
            con_fail.fail_2 = objfail.fail_2;
            con_fail.fail_3 = objfail.fail_3;
            con_fail.fail_4 = objfail.fail_4;
            con_fail.fail_end_year = objfail.fail_end_year;
            con_fail.fail_sit = objfail.fail_sit;
            con_fail.fail_eff_date = objfail.fail_eff_date;
            con_fail.fail_eff_results = objfail.fail_eff_results;
            con_fail.fail_recomm = objfail.fail_recomm;



            con_fail.save_in_failure_cases();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(failure_cases objfail)
        {
            con_fail.fail_id = objfail.fail_id;
            con_fail.fail_lev = objfail.fail_lev;
            con_fail.fail_class = objfail.fail_class;
            con_fail.fail_student = objfail.fail_student;
            con_fail.fail_nation = objfail.fail_nation;
            con_fail.fail_mob = objfail.fail_mob;
            con_fail.fail_birth = objfail.fail_birth;
            con_fail.fail_date = objfail.fail_date;
            con_fail.fail_desc = objfail.fail_desc;
            con_fail.fail_reason = objfail.fail_reason;
            con_fail.fail_sub = objfail.fail_sub;
            con_fail.fail_1 = objfail.fail_1;
            con_fail.fail_2 = objfail.fail_2;
            con_fail.fail_3 = objfail.fail_3;
            con_fail.fail_4 = objfail.fail_4;
            con_fail.fail_end_year = objfail.fail_end_year;
            con_fail.fail_sit = objfail.fail_sit;
            con_fail.fail_eff_date = objfail.fail_eff_date;
            con_fail.fail_eff_results = objfail.fail_eff_results;
            con_fail.fail_recomm = objfail.fail_recomm;

            con_fail.update_failure_cases();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_fail.fail_id = id;
            con_fail.delete_from_failure_cases();
            return new JsonResult("deleted Successfully");


        }
    }
}