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
    public class school_year_dataController : ControllerBase
    {
        school_year_data con_yeardata = new school_year_data();

  
        public DataSet dataset1 { get; set; }

        [HttpGet]
        public List<school_year_data> Get()
        {
            dataset1 = con_yeardata.get_school_year_data();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new school_year_data()
                                 {
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     year_date_from = Convert.ToString(rw["year_date_from"]),
                                     year_date_to = Convert.ToString(rw["year_date_to"])
                         
                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(school_year_data objyeardata)
        {
            con_yeardata.year_data_id = objyeardata.year_data_id;
            con_yeardata.year_date_from = objyeardata.year_date_from;
            con_yeardata.year_date_to = objyeardata.year_date_to;


            con_yeardata.update_school_year_data();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_yeardata.year_data_id = id;
            con_yeardata.delete_from_school_year_data();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<school_year_data> Get(int id)
        {
            con_yeardata.year_data_id = id;
            dataset1 = con_yeardata.get_school_year_data_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new school_year_data()
                                 {
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     year_date_from = Convert.ToString(rw["year_date_from"]),
                                     year_date_to = Convert.ToString(rw["year_date_to"])

                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(school_year_data objyeardata)
        {


            con_yeardata.year_date_from = objyeardata.year_date_from;
            con_yeardata.year_date_to = objyeardata.year_date_to;

            var year_data_id = con_yeardata.save_in_school_year_data();
            return new JsonResult(year_data_id);
        }

        [HttpGet("year_data_dropdown")]
        public List<school_year_data> get_school_year_data_for_dropdown()
        {
            dataset1 = con_yeardata.get_school_year_data_for_dropdown();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new school_year_data()
                                 {
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     year_data = Convert.ToString(rw["year_data"])
                                  

                                 }).ToList();

            return convertedList;
        }
    }
}