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
    public class nchra_detailsController : ControllerBase
    {
        nchra_details con_nchra_det = new nchra_details();


        public DataSet dataset { get; set; }

        [HttpGet]
        public List<nchra_details> Get()
        {
            dataset = con_nchra_det.get_nchra_details();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new nchra_details()
                                 {
                                     nchra_details_id = Convert.ToInt32(rw["nchra_details_id"]),
                                     nchra_id = Convert.ToInt32(rw["nchra_id"]),
                                     nchra_obj_id = Convert.ToInt32(rw["nchra_obj_id"]),
                                     nchra_obj_name = Convert.ToString(rw["nchra_obj_name"])
                               
                                 }).ToList();

            return convertedList;
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_nchra_det.nchra_details_id = id;
            con_nchra_det.delete_from_nchra_details();
            return new JsonResult("deleted Successfully");


        }

        [HttpGet("id")]
        public List<nchra_details> Get(int id)
        {
            con_nchra_det.nchra_details_id = id;
            dataset = con_nchra_det.get_nchra_details_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new nchra_details()
                                 {
                                     nchra_details_id = Convert.ToInt32(rw["nchra_details_id"]),
                                     nchra_id = Convert.ToInt32(rw["nchra_id"]),
                                     nchra_obj_id = Convert.ToInt32(rw["nchra_obj_id"]),
                                     nchra_obj_name = Convert.ToString(rw["nchra_obj_name"])
                                 }).ToList();

            return convertedList;
        }

        [HttpPut]
        public JsonResult Put(nchra_details objnchra_details)
        {
            con_nchra_det.nchra_id = objnchra_details.nchra_id;
            con_nchra_det.nchra_obj_id = objnchra_details.nchra_obj_id;
            con_nchra_det.nchra_obj_name = objnchra_details.nchra_obj_name;

            con_nchra_det.update_nchra_details();
            return new JsonResult("Updated Successfully");
        }

        [HttpPost]
        public JsonResult Post(nchra_details objnchra_details)
        {

            con_nchra_det.nchra_id = objnchra_details.nchra_id;
            con_nchra_det.nchra_obj_id = objnchra_details.nchra_obj_id;
            con_nchra_det.nchra_obj_name = objnchra_details.nchra_obj_name;


            con_nchra_det.save_in_nchra_details();
            return new JsonResult("Added Successfully");
        }

        [HttpGet("get_nchra_details_with_nchra_id")]
        public List<nchra_details> get_nchra_details_with_nchra_id(int nchra_id)
        {
            con_nchra_det.nchra_id = nchra_id;
            dataset = con_nchra_det.get_nchra_details_with_nchra_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new nchra_details()
                                 {
                                     nchra_details_id = Convert.ToInt32(rw["nchra_details_id"]),
                                     nchra_id = Convert.ToInt32(rw["nchra_id"]),
                                     nchra_obj_id = Convert.ToInt32(rw["nchra_obj_id"]),
                                     nchra_obj_name = Convert.ToString(rw["nchra_obj_name"])
                                 }).ToList();

            return convertedList;
        }
    }
}