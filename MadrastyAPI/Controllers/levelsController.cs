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
    public class levelsController : ControllerBase
    {
        levels con_level = new levels();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<levels> Get(int id)
        {
            con_level.lev_id = id;
            dataset = con_level.get_levels_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new levels()
                                 {
                                     lev_id = Convert.ToInt32(rw["lev_id"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     lev_class_no = Convert.ToInt32(rw["lev_class_no"]),
                                     lev_desc = Convert.ToString(rw["lev_desc"])
                                   
                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<levels> Get()
        {
            dataset = con_level.get_levels();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new levels()
                                 {
                                     lev_id = Convert.ToInt32(rw["lev_id"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     lev_class_no = Convert.ToInt32(rw["lev_class_no"]),
                                     lev_desc = Convert.ToString(rw["lev_desc"])
                        

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(levels objlevels)
        {
            con_level.lev_name = objlevels.lev_name;
            con_level.lev_class_no = objlevels.lev_class_no;
            con_level.lev_desc = objlevels.lev_desc;


            con_level.save_in_levels();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(levels objlevels)
        {
            con_level.lev_id = objlevels.lev_id;
            con_level.lev_name = objlevels.lev_name;
            con_level.lev_class_no = objlevels.lev_class_no;
            con_level.lev_desc = objlevels.lev_desc;


            con_level.update_levels();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_level.lev_id = id;
            con_level.delete_from_levels();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("get_levels_stats")]
        public List<levels> get_levels_stats()
        {
            dataset = con_level.get_levels_stats();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new levels()
                                 {
                                     lev_id = Convert.ToInt32(rw["lev_id"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     num_students = Convert.ToString(rw["num_students"]),
                                     num_classes = Convert.ToString(rw["num_classes"]),
                                     total_students = Convert.ToString(rw["total_students"]),
                                     total_classes = Convert.ToString(rw["total_classes"])



                                 }).ToList();

            return convertedList;

        }
    }
}