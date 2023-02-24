using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json.Linq;
using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class activityController : ControllerBase
    {
        activity con_act = new activity();

        public DataSet dataset1 { get; set; }
        public DataSet get_activity_def
        {
            get { return con_act.get_activity_def(); }
        }
        // GET: api/<controller>
        [HttpGet]
        public List<activity> Get()
        {
            var convertedList = (from rw in get_activity_def.Tables[0].AsEnumerable()
                                 select new activity()
                                 {
                                     activity_id = Convert.ToInt32(rw["activity_id"]),
                                     activity_name = Convert.ToString(rw["activity_name"]),
                                     activity_dep = Convert.ToString(rw["activity_dep"]),
                                     activity_school_year = Convert.ToString(rw["activity_school_year"]),
                                     activity_school_year_id = Convert.ToInt32(rw["activity_school_year_id"]),
                                     activity_level = Convert.ToInt32(rw["activity_level"])
                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(activity objactivity)
        {
            con_act.activity_id = objactivity.activity_id;
            con_act.activity_name = objactivity.activity_name;
            con_act.activity_dep = objactivity.activity_dep;
            con_act.activity_school_year = objactivity.activity_school_year;
            con_act.activity_level = objactivity.activity_level;
            con_act.activity_date = objactivity.activity_date;
            con_act.activity_school_term = objactivity.activity_school_term;
            con_act.activity_notes = objactivity.activity_notes;
            con_act.activity_school_year_id = objactivity.activity_school_year_id;
            con_act.save_in_activity_def();
            
        }
        [HttpGet("id")]
        public List<activity> Get(int id)
        {
            con_act.activity_id = id;
            dataset1 = con_act.get_activity_def_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new activity()
                                 {
                                     activity_id = Convert.ToInt32(rw["activity_id"]),
                                     activity_name = Convert.ToString(rw["activity_name"]),
                                     activity_dep = Convert.ToString(rw["activity_dep"]),
                                     activity_school_year = Convert.ToString(rw["activity_school_year"]),
                                     activity_school_year_id = Convert.ToInt32(rw["activity_school_year_id"]),
                                     activity_level = Convert.ToInt32(rw["activity_level"]),
                                     activity_date = Convert.ToString(rw["activity_date"]),
                                     activity_school_term = Convert.ToString(rw["activity_school_term"]),
                                     activity_notes = Convert.ToString(rw["activity_notes"])
                                 }).ToList();

            return convertedList;
        }


        [HttpPut]
        public JsonResult Put(activity objactivity)
        {
            con_act.activity_id = objactivity.activity_id;
            con_act.activity_name = objactivity.activity_name;
            con_act.activity_dep = objactivity.activity_dep;
            con_act.activity_school_year = objactivity.activity_school_year;
            con_act.activity_level = objactivity.activity_level;
            con_act.activity_date = objactivity.activity_date;
            con_act.activity_school_term = objactivity.activity_school_term;
            con_act.activity_notes = objactivity.activity_notes;
            con_act.activity_school_year_id = objactivity.activity_school_year_id;
            //con_act.save_in_activity_def();
            con_act.update_activity_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_act.activity_id = id;
            con_act.delete_from_activity_def();
            return new JsonResult("deleted Successfully");


        }
    }
}
