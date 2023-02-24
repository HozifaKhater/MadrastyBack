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
    public class classController : ControllerBase
    {
        classes con_class = new classes();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<classes> Get(int id)
        {
            con_class.class_id = id;
            dataset = con_class.get_class_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new classes()
                                 {
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_mr7la = Convert.ToString(rw["class_mr7la"]),
                                     class_level = Convert.ToString(rw["class_level"]),
                                     class_corr = Convert.ToString(rw["class_corr"]),
                                     class_name = Convert.ToString(rw["class_name"])
                          
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("class_level")]
        public List<classes> get_class_with_level_id(string class_level)
        {
            con_class.class_level = class_level;
            dataset = con_class.get_class_with_level_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new classes()
                                 {
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_mr7la = Convert.ToString(rw["class_mr7la"]),
                                     class_level = Convert.ToString(rw["class_level"]),
                                     class_corr = Convert.ToString(rw["class_corr"]),
                                     class_name = Convert.ToString(rw["class_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<classes> Get()
        {
            dataset = con_class.get_class();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new classes()
                                 {
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_mr7la = Convert.ToString(rw["class_mr7la"]),
                                     class_level = Convert.ToString(rw["class_level"]),
                                     class_corr = Convert.ToString(rw["class_corr"]),
                                     class_name = Convert.ToString(rw["class_name"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(classes objclasses)
        {
            con_class.class_mr7la = objclasses.class_mr7la;
            con_class.class_level = objclasses.class_level;
            con_class.class_corr = objclasses.class_corr;
            con_class.class_name = objclasses.class_name;


            con_class.save_in_class();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(classes objclasses)
        {
            con_class.class_id = objclasses.class_id;
            con_class.class_mr7la = objclasses.class_mr7la;
            con_class.class_level = objclasses.class_level;
            con_class.class_corr = objclasses.class_corr;
            con_class.class_name = objclasses.class_name;

            con_class.update_class();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_class.class_id = id;
            con_class.delete_from_class();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("get_class_count_for_teacher")]
        public List<classes> get_class_count_for_teacher(int emp_id)
        {
            con_class.emp_id = emp_id;
            dataset = con_class.get_class_count_for_teacher();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new classes()
                                 {
                                     class_count = Convert.ToInt32(rw["class_count"]),
                                    
                                 }).ToList();

            return convertedList;

        }
    }
}