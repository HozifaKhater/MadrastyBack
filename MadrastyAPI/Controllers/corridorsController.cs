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
    public class corridorsController : ControllerBase
    {
        corridors con_cor = new corridors();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<corridors> Get(int id)
        {
            con_cor.corridor_id = id;
            dataset = con_cor.get_corridors_def_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new corridors()
                                 {
                                     corridor_id = Convert.ToInt32(rw["corridor_id"]),
                                     corridor_name = Convert.ToString(rw["corridor_name"]),
                                     corridor_desc = Convert.ToString(rw["corridor_desc"]),
                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<corridors> Get()
        {
            dataset = con_cor.get_corridors_def();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new corridors()
                                 {
                                     corridor_id = Convert.ToInt32(rw["corridor_id"]),
                                     corridor_name = Convert.ToString(rw["corridor_name"]),
                                     corridor_desc = Convert.ToString(rw["corridor_desc"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(corridors objcorridors)
        {
            con_cor.corridor_id = objcorridors.corridor_id;
            con_cor.corridor_name = objcorridors.corridor_name;
            con_cor.corridor_desc = objcorridors.corridor_desc;

            con_cor.save_in_corridors_def();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(corridors objcorridors)
        {
            con_cor.corridor_id = objcorridors.corridor_id;
            con_cor.corridor_name = objcorridors.corridor_name;
            con_cor.corridor_desc = objcorridors.corridor_desc;


            con_cor.update_corridors_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_cor.corridor_id = id;
            con_cor.delete_from_corridors_def();
            return new JsonResult("deleted Successfully");


        }
    }
}