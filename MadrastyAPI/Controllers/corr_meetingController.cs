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
    public class corr_meetingController : ControllerBase
    {
        corr_meeting con_cor_meet = new corr_meeting();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<corr_meeting> Get(int id)
        {
            con_cor_meet.corr_meet_id = id;
            dataset = con_cor_meet.get_corr_meeting_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new corr_meeting()
                                 {
                                     corr_meet_id = Convert.ToInt32(rw["corr_meet_id"]),
                                     corr_meet_date = Convert.ToString(rw["corr_meet_date"]),
                                     corr_meet_time = Convert.ToString(rw["corr_meet_time"]),
                                     corr_meet_loc = Convert.ToString(rw["corr_meet_loc"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<corr_meeting> Get()
        {
            dataset = con_cor_meet.get_corr_meeting();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new corr_meeting()
                                 {
                                     corr_meet_id = Convert.ToInt32(rw["corr_meet_id"]),
                                     corr_meet_date = Convert.ToString(rw["corr_meet_date"]),
                                     corr_meet_time = Convert.ToString(rw["corr_meet_time"]),
                                     corr_meet_loc = Convert.ToString(rw["corr_meet_loc"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(corr_meeting objcor_met)
        {
            con_cor_meet.corr_meet_date = objcor_met.corr_meet_date;
            con_cor_meet.corr_meet_time = objcor_met.corr_meet_time;
            con_cor_meet.corr_meet_loc = objcor_met.corr_meet_loc;


            con_cor_meet.save_in_corr_meeting();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(corr_meeting objcor_met)
        {
            con_cor_meet.corr_meet_id = objcor_met.corr_meet_id;
            con_cor_meet.corr_meet_date = objcor_met.corr_meet_date;
            con_cor_meet.corr_meet_time = objcor_met.corr_meet_time;
            con_cor_meet.corr_meet_loc = objcor_met.corr_meet_loc;


            con_cor_meet.update_corr_meeting();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_cor_meet.corr_meet_id = id;
            con_cor_meet.delete_from_corr_meeting();
            return new JsonResult("deleted Successfully");


        }
    }
}