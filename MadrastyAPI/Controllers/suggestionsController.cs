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
    public class suggestionsController : ControllerBase
    {
        suggestions con_sugg = new suggestions();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<suggestions> Get(int id)
        {
            con_sugg.sugg_id = id;
            dataset = con_sugg.get_suggestions_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new suggestions()
                                 {
                                     sugg_id = Convert.ToInt32(rw["sugg_id"]),
                                     sugg_body = Convert.ToString(rw["sugg_body"]),
                                     sugg_title = Convert.ToString(rw["sugg_title"]),
                                     sugg_file = Convert.ToString(rw["sugg_file"]),
                                     sugg_type = Convert.ToString(rw["sugg_type"]),
                                     sugg_upload = Convert.ToString(rw["sugg_upload"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<suggestions> Get()
        {
            dataset = con_sugg.get_suggestions();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new suggestions()
                                 {
                                     sugg_id = Convert.ToInt32(rw["sugg_id"]),
                                     sugg_body = Convert.ToString(rw["sugg_body"]),
                                     sugg_title = Convert.ToString(rw["sugg_title"]),
                                     sugg_file = Convert.ToString(rw["sugg_file"]),
                                     sugg_type = Convert.ToString(rw["sugg_type"]),
                                     sugg_upload = Convert.ToString(rw["sugg_upload"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(suggestions objsugg)
        {
            con_sugg.sugg_body = objsugg.sugg_body;
            con_sugg.sugg_title = objsugg.sugg_title;
            con_sugg.sugg_file = objsugg.sugg_file;
            con_sugg.sugg_type = objsugg.sugg_type;
            con_sugg.sugg_upload = objsugg.sugg_upload;

            con_sugg.save_in_suggestions();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(suggestions objsugg)
        {
            con_sugg.sugg_id = objsugg.sugg_id;
            con_sugg.sugg_body = objsugg.sugg_body;
            con_sugg.sugg_title = objsugg.sugg_title;
            con_sugg.sugg_file = objsugg.sugg_file;
            con_sugg.sugg_type = objsugg.sugg_type;
            con_sugg.sugg_upload = objsugg.sugg_upload;

            con_sugg.update_suggestions();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_sugg.sugg_id = id;
            con_sugg.delete_from_suggestions();
            return new JsonResult("deleted Successfully");


        }
    }
}