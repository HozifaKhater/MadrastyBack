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
    public class observationsController : ControllerBase
    {
        observations con_observ = new observations();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<observations> Get(int id)
        {
            con_observ.observer_id = id;
            dataset = con_observ.get_observations_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new observations()
                                 {
                                     observer_id = Convert.ToInt32(rw["observer_id"]),
                                     observ_ftra = Convert.ToString(rw["observ_ftra"]),
                                     lev_id = Convert.ToInt32(rw["lev_id"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     observ_loc = Convert.ToString(rw["observ_loc"]),
                                     observe_date = Convert.ToString(rw["observe_date"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<observations> Get()
        {
            dataset = con_observ.get_observations();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new observations()
                                 {
                                     observer_id = Convert.ToInt32(rw["observer_id"]),
                                     observ_ftra = Convert.ToString(rw["observ_ftra"]),
                                     lev_id = Convert.ToInt32(rw["lev_id"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     observ_loc = Convert.ToString(rw["observ_loc"]),
                                     observe_date = Convert.ToString(rw["observe_date"]),
                                     civil_id = Convert.ToInt32(rw["civil_id"]),
                                     emp_dep = Convert.ToString(rw["emp_dep"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(observations objobserv)
        {
            con_observ.observ_ftra = objobserv.observ_ftra;
            con_observ.lev_id = objobserv.lev_id;
            con_observ.lev_name = objobserv.lev_name;
            con_observ.class_id = objobserv.class_id;
            con_observ.class_name = objobserv.class_name;
            con_observ.emp_id = objobserv.emp_id;
            con_observ.emp_name = objobserv.emp_name;
            con_observ.observ_loc = objobserv.observ_loc;
            con_observ.observe_date = objobserv.observe_date;

            con_observ.save_in_observations();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(observations objobserv)
        {
            con_observ.observer_id = objobserv.observer_id;
            con_observ.observ_ftra = objobserv.observ_ftra;
            con_observ.lev_id = objobserv.lev_id;
            con_observ.lev_name = objobserv.lev_name;
            con_observ.class_id = objobserv.class_id;
            con_observ.class_name = objobserv.class_name;
            con_observ.emp_id = objobserv.emp_id;
            con_observ.emp_name = objobserv.emp_name;
            con_observ.observ_loc = objobserv.observ_loc;
            con_observ.observe_date = objobserv.observe_date;

            con_observ.update_observations();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_observ.observer_id = id;
            con_observ.delete_from_observations();
            return new JsonResult("deleted Successfully");


        }
    }
}