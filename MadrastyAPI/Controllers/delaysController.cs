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
    public class delaysController : ControllerBase
    {
        delays con_delay = new delays();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<delays> Get(int id)
        {
            con_delay.delay_id = id;
            dataset = con_delay.get_delays_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new delays()
                                 {
                                     delay_id = Convert.ToInt32(rw["delay_id"]),
                                     delay_date = Convert.ToString(rw["delay_date"]),
                                     delay_emp_name = Convert.ToString(rw["delay_emp_name"]),
                                     time_attend = Convert.ToString(rw["time_attend"]),
                                     delay_state = Convert.ToInt32(rw["delay_state"]),
                                     delay_emp_id = Convert.ToInt32(rw["delay_emp_id"])
                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<delays> Get()
        {
            dataset = con_delay.get_delays();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new delays()
                                 {
                                     delay_id = Convert.ToInt32(rw["delay_id"]),
                                     delay_date = Convert.ToString(rw["delay_date"]),
                                     delay_emp_name = Convert.ToString(rw["delay_emp_name"]),
                                     time_attend = Convert.ToString(rw["time_attend"]),
                                     delay_state = Convert.ToInt32(rw["delay_state"]),
                                     delay_emp_id = Convert.ToInt32(rw["delay_emp_id"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(delays objdelays)
        {
            con_delay.delay_date = objdelays.delay_date;
            con_delay.delay_emp_name = objdelays.delay_emp_name;
            con_delay.time_attend = objdelays.time_attend;
            con_delay.delay_state = objdelays.delay_state;
            con_delay.delay_emp_id = objdelays.delay_emp_id;

            con_delay.save_in_delays();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(delays objdelays)
        {
            con_delay.delay_id = objdelays.delay_id;
            con_delay.delay_date = objdelays.delay_date;
            con_delay.delay_emp_name = objdelays.delay_emp_name;
            con_delay.time_attend = objdelays.time_attend;
            con_delay.delay_state = objdelays.delay_state;
            con_delay.delay_emp_id = objdelays.delay_emp_id;

            con_delay.update_delays();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_delay.delay_id = id;
            con_delay.delete_from_delays();
            return new JsonResult("deleted Successfully");


        }
    }
}