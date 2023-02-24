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
    public class school_dataController : ControllerBase
    {
        school_data con_scho_data = new school_data();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<school_data> Get(int id)
        {
            con_scho_data.school_id = id;
            dataset = con_scho_data.get_school_data_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new school_data()
                                 {
                                     school_id = Convert.ToInt32(rw["school_id"]),
                                     school_man = Convert.ToString(rw["school_man"]),
                                     school_assis1 = Convert.ToString(rw["school_assis1"]),
                                     school_assis2 = Convert.ToString(rw["school_assis2"]),
                                     school_assis3 = Convert.ToString(rw["school_assis3"]),
                                     school_assis4 = Convert.ToString(rw["school_assis4"]),
                                     school_bdala = Convert.ToString(rw["school_bdala"]),
                                     school_faks = Convert.ToString(rw["school_faks"]),
                                     school_addr = Convert.ToString(rw["school_addr"]),
                                     school_dir = Convert.ToString(rw["school_dir"]),
                                     school_logo = Convert.ToString(rw["school_logo"]),
                                     school_name = Convert.ToString(rw["school_name"]),
                                     school_assis1_id = Convert.ToInt32(rw["school_assis1_id"]),
                                     school_assis2_id = Convert.ToInt32(rw["school_assis2_id"]),
                                     school_assis3_id = Convert.ToInt32(rw["school_assis3_id"]),
                                     school_assis4_id = Convert.ToInt32(rw["school_assis4_id"]),
                                     school_man_id = Convert.ToInt32(rw["school_man_id"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<school_data> Get()
        {
            dataset = con_scho_data.get_school_data();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new school_data()
                                 {
                                     school_id = Convert.ToInt32(rw["school_id"]),
                                     school_man = Convert.ToString(rw["school_man"]),
                                     school_assis1 = Convert.ToString(rw["school_assis1"]),
                                     school_assis2 = Convert.ToString(rw["school_assis2"]),
                                     school_assis3 = Convert.ToString(rw["school_assis3"]),
                                     school_assis4 = Convert.ToString(rw["school_assis4"]),
                                     school_bdala = Convert.ToString(rw["school_bdala"]),
                                     school_faks = Convert.ToString(rw["school_faks"]),
                                     school_addr = Convert.ToString(rw["school_addr"]),
                                     school_dir = Convert.ToString(rw["school_dir"]),
                                     school_logo = Convert.ToString(rw["school_logo"]),
                                     school_name = Convert.ToString(rw["school_name"]),
                                     school_assis1_id = Convert.ToInt32(rw["school_assis1_id"]),
                                     school_assis2_id = Convert.ToInt32(rw["school_assis2_id"]),
                                     school_assis3_id = Convert.ToInt32(rw["school_assis3_id"]),
                                     school_assis4_id = Convert.ToInt32(rw["school_assis4_id"]),
                                     school_man_id = Convert.ToInt32(rw["school_man_id"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(school_data objschool_data)
        {
           


            con_scho_data.school_man = objschool_data.school_man;
            con_scho_data.school_assis1 = objschool_data.school_assis1;
            con_scho_data.school_assis2 = objschool_data.school_assis2;
            con_scho_data.school_assis3 = objschool_data.school_assis3;
            con_scho_data.school_assis4 = objschool_data.school_assis4;
            con_scho_data.school_bdala = objschool_data.school_bdala;
            con_scho_data.school_faks = objschool_data.school_faks;
            con_scho_data.school_addr = objschool_data.school_addr;
            con_scho_data.school_dir = objschool_data.school_dir;
            con_scho_data.school_logo = objschool_data.school_logo;
            con_scho_data.school_name = objschool_data.school_name;
            con_scho_data.school_assis1_id = objschool_data.school_assis1_id;
            con_scho_data.school_assis2_id = objschool_data.school_assis2_id;
            con_scho_data.school_assis3_id = objschool_data.school_assis3_id;
            con_scho_data.school_assis4_id = objschool_data.school_assis4_id;
            con_scho_data.school_man_id = objschool_data.school_man_id;


            con_scho_data.save_in_school_data();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(school_data objschool_data)
        {
            con_scho_data.school_id = objschool_data.school_id;
            con_scho_data.school_man = objschool_data.school_man;
            con_scho_data.school_assis1 = objschool_data.school_assis1;
            con_scho_data.school_assis2 = objschool_data.school_assis2;
            con_scho_data.school_assis3 = objschool_data.school_assis3;
            con_scho_data.school_assis4 = objschool_data.school_assis4;
            con_scho_data.school_bdala = objschool_data.school_bdala;
            con_scho_data.school_faks = objschool_data.school_faks;
            con_scho_data.school_addr = objschool_data.school_addr;
            con_scho_data.school_dir = objschool_data.school_dir;
            con_scho_data.school_logo = objschool_data.school_logo;
            con_scho_data.school_name = objschool_data.school_name;
            con_scho_data.school_assis1_id = objschool_data.school_assis1_id;
            con_scho_data.school_assis2_id = objschool_data.school_assis2_id;
            con_scho_data.school_assis3_id = objschool_data.school_assis3_id;
            con_scho_data.school_assis4_id = objschool_data.school_assis4_id;
            con_scho_data.school_man_id = objschool_data.school_man_id;


            con_scho_data.update_school_data();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_scho_data.school_id = id;
            con_scho_data.delete_from_school_data();
            return new JsonResult("deleted Successfully");


        }
    }
}