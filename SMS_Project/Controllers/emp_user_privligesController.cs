using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class emp_user_privligesController : ControllerBase
    {
        emp_user_privliges con_emp_priv = new emp_user_privliges();

        public DataSet dataset1 { get; set; }
        [HttpPost]
        public JsonResult Post(emp_user_privliges objjobs)
        {
            con_emp_priv.emp_id = objjobs.emp_id;
            con_emp_priv.priv_name = objjobs.priv_name;
            con_emp_priv.page_name = objjobs.page_name;
            con_emp_priv.in_class_priv = objjobs.in_class_priv;
            con_emp_priv.dep_work = objjobs.dep_work;
            con_emp_priv.job_id = objjobs.job_id;

            con_emp_priv.save_in_emp_user_privliges();
            return new JsonResult("Added Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_emp_priv.user_id = id;
            con_emp_priv.delete_from_emp_user_privliges();
            return new JsonResult("deleted Successfully");


        }
        [HttpDelete("emp_id")]
        public JsonResult Delete(string emp_id)
        {
            con_emp_priv.job_id = Convert.ToInt32(emp_id);
            con_emp_priv.delete_from_emp_user_privliges_one_priv();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet]
        public List<emp_user_privliges> Get()
        {
            dataset1 = con_emp_priv.get_emp_user_privliges();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new emp_user_privliges()
                                 {
                                     user_id = Convert.ToInt32(rw["user_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"]),
                                     page_name = Convert.ToString(rw["page_name"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"]),
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                      emp_name = Convert.ToString(rw["emp_name"])
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("emp_id")]
        public List<emp_user_privliges> Get(int emp_id)
        {
            dataset1 = con_emp_priv.get_emp_user_privliges();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new emp_user_privliges()
                                 {
                                     user_id = Convert.ToInt32(rw["user_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"]),
                                     page_name = Convert.ToString(rw["page_name"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"]),
                                     job_id = Convert.ToInt32(rw["job_id"])

                                 }).ToList();

            return convertedList;
        }
    }

}
