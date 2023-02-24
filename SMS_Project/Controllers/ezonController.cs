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
    public class ezonController : ControllerBase
    {

        ezon con_ezon = new ezon();
        public DataSet dataset1 { get; set; }
        [HttpGet]
        public List<ezon> Get()
        {
            dataset1 = con_ezon.get_absent_premit_ezoon();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.emp_id = objaezon.emp_id;
            con_ezon.ezn_date = objaezon.ezn_date;
            con_ezon.ezn_reason = objaezon.ezn_reason;
            con_ezon.time_from = objaezon.time_from;
            con_ezon.time_to = objaezon.time_to;
          

            con_ezon.save_in_absent_premit_ezoon();

        }
        [HttpGet("id")]
        public List<ezon> Get(int id)
        {
            con_ezon.ezn_id = id;
            dataset1 = con_ezon.get_absent_premit_ezoon_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("emp_id")]
        public List<ezon> Get(int emp_id, string x)
        {
            con_ezon.emp_id = emp_id;
            dataset1 = con_ezon.get_absent_premit_ezoon_with_emp_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new ezon()
                                 {
                                     ezn_id = Convert.ToInt32(rw["ezn_id"]),
                                     absent_ezn_id = Convert.ToInt32(rw["absent_ezn_id"]),
                                     premit_id = Convert.ToInt32(rw["premit_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     ezn_date = Convert.ToString(rw["ezn_date"]),
                                     ezn_reason = Convert.ToString(rw["ezn_reason"]),
                                     time_from = Convert.ToString(rw["time_from"]),
                                     time_to = Convert.ToString(rw["time_to"]),
                                     ezn_state = Convert.ToInt32(rw["ezn_state"]),
                                 }).ToList();

            return convertedList;
        }

        [HttpPut]
        public JsonResult Put(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.emp_id = objaezon.emp_id;
            con_ezon.ezn_date = objaezon.ezn_date;
            con_ezon.ezn_reason = objaezon.ezn_reason;
            con_ezon.time_from = objaezon.time_from;
            con_ezon.time_to = objaezon.time_to;

            //con_ezon.save_in_activity_def();
            con_ezon.update_absent_premit_ezoon();
            return new JsonResult("Updated Successfully");
        }
        //[HttpPut]
        //public JsonResult Put_state(ezon objaezon)
        //{
        //    con_ezon.ezn_id = objaezon.ezn_id;
        //    con_ezon.ezn_state = objaezon.ezn_state;
        //    //con_ezon.save_in_activity_def();
        //    con_ezon.update_absent_premit_ezoon_for_state();
        //    return new JsonResult("Updated Successfully");
        //}
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_ezon.ezn_id = id;
            con_ezon.delete_from_absent_premit_ezoon();
            return new JsonResult("deleted Successfully");


        }
    }
}
