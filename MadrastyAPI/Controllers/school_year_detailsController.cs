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
    public class school_year_detailsController : ControllerBase
    {
        school_year_details con_year_data_det = new school_year_details();


        public DataSet dataset { get; set; }

        [HttpGet]
        public List<school_year_details> Get()
        {
            dataset = con_year_data_det.get_school_year_details();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new school_year_details()
                                 {
                                     year_details_id = Convert.ToInt32(rw["year_details_id"]),
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     term_date_from = Convert.ToString(rw["term_date_from"]),
                                     term_date_to = Convert.ToString(rw["term_date_to"])

                                 }).ToList();

            return convertedList;
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_year_data_det.year_details_id = id;
            con_year_data_det.delete_from_school_year_details();
            return new JsonResult("deleted Successfully");


        }

        [HttpGet("id")]
        public List<school_year_details> Get(int id)
        {
            con_year_data_det.year_details_id = id;
            dataset = con_year_data_det.get_school_year_details_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new school_year_details()
                                 {
                                     year_details_id = Convert.ToInt32(rw["year_details_id"]),
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     term_date_from = Convert.ToString(rw["term_date_from"]),
                                     term_date_to = Convert.ToString(rw["term_date_to"])
                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(school_year_details objyear_det)
        {

            con_year_data_det.year_data_id = objyear_det.year_data_id;
            con_year_data_det.term_date_from = objyear_det.term_date_from;
            con_year_data_det.term_date_to = objyear_det.term_date_to;


            con_year_data_det.save_in_school_year_details();
            return new JsonResult("Added Successfully");
        }

        [HttpGet("year_data_id")]
        public List<school_year_details> get_school_year_details_with_year_data_id(int id)
        {
            con_year_data_det.year_details_id = id;
            dataset = con_year_data_det.get_school_year_details_with_year_data_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new school_year_details()
                                 {
                                     year_details_id = Convert.ToInt32(rw["year_details_id"]),
                                     year_data_id = Convert.ToInt32(rw["year_data_id"]),
                                     term_date_from = Convert.ToString(rw["term_date_from"]),
                                     term_date_to = Convert.ToString(rw["term_date_to"])
                                 }).ToList();

            return convertedList;
        }
    }
}