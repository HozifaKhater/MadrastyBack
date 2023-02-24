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
    public class MaintenanceController : ControllerBase
    {
        Maintenance con_maint = new Maintenance();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<Maintenance> Get(int id)
        {
            con_maint.maint_id = id;
            dataset = con_maint.get_Maintenance_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new Maintenance()
                                 {
                                     maint_id = Convert.ToInt32(rw["maint_id"]),
                                     maint_date = Convert.ToString(rw["maint_date"]),
                                     maint_type = Convert.ToString(rw["maint_type"]),
                                     maint_loc = Convert.ToString(rw["maint_loc"]),
                                     maint_work = Convert.ToString(rw["maint_work"]),
                                     maint_notes = Convert.ToString(rw["maint_notes"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<Maintenance> Get()
        {
            dataset = con_maint.get_Maintenance();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new Maintenance()
                                 {
                                     maint_id = Convert.ToInt32(rw["maint_id"]),
                                     maint_date = Convert.ToString(rw["maint_date"]),
                                     maint_type = Convert.ToString(rw["maint_type"]),
                                     maint_loc = Convert.ToString(rw["maint_loc"]),
                                     maint_work = Convert.ToString(rw["maint_work"]),
                                     maint_notes = Convert.ToString(rw["maint_notes"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(Maintenance objmaint)
        {
            con_maint.maint_date = objmaint.maint_date;
            con_maint.maint_type = objmaint.maint_type;
            con_maint.maint_loc = objmaint.maint_loc;
            con_maint.maint_work = objmaint.maint_work;
            con_maint.maint_notes = objmaint.maint_notes;

            con_maint.save_in_Maintenance();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(Maintenance objmaint)
        {
            con_maint.maint_id = objmaint.maint_id;
            con_maint.maint_date = objmaint.maint_date;
            con_maint.maint_type = objmaint.maint_type;
            con_maint.maint_loc = objmaint.maint_loc;
            con_maint.maint_work = objmaint.maint_work;
            con_maint.maint_notes = objmaint.maint_notes;

            con_maint.update_Maintenance();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_maint.maint_id = id;
            con_maint.delete_from_Maintenance();
            return new JsonResult("deleted Successfully");


        }
    }
}