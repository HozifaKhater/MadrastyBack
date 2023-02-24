using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
  
{
    [Route("api/[controller]")]
    [ApiController]
    public class instructionsController : ControllerBase
    {

        instructions con_obj = new instructions();


        public DataSet dataset1 { get; set; }

        [HttpGet]
        public List<instructions> Get()
        {
            dataset1 = con_obj.get_instructions();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new instructions()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     group_number = Convert.ToInt32(rw["group_number"]),
                                     sessions_number = Convert.ToInt32(rw["sessions_number"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     type_id = Convert.ToInt32(rw["type_id"])



                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(instructions obj)
        {
            con_obj.ser = obj.ser;
            con_obj.level_name = obj.level_name;
            con_obj.level_id = obj.level_id;
            con_obj.class_name = obj.class_name;
            con_obj.class_id = obj.class_id;
            con_obj.topic = obj.topic;
            con_obj.group_number = obj.group_number;
            con_obj.sessions_number = obj.sessions_number;
            con_obj.notes = obj.notes;
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;



            con_obj.update_instructions();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.ser = id;
            con_obj.delete_from_instructions();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<instructions> Get(int id)
        {
            con_obj.ser = id;
            dataset1 = con_obj.get_instructions_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new instructions()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     topic = Convert.ToString(rw["topic"]),
                                     group_number = Convert.ToInt32(rw["group_number"]),
                                     sessions_number = Convert.ToInt32(rw["sessions_number"]),
                                     notes = Convert.ToString(rw["notes"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     type_id = Convert.ToInt32(rw["type_id"])



                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(instructions obj)
        {



            
            con_obj.level_name = obj.level_name;
            con_obj.level_id = obj.level_id;
            con_obj.class_name = obj.class_name;
            con_obj.class_id = obj.class_id;
            con_obj.topic = obj.topic;
            con_obj.group_number = obj.group_number;
            con_obj.sessions_number = obj.sessions_number;
            con_obj.notes = obj.notes;
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;

            var year_data_id = con_obj.save_in_instructions();
            return new JsonResult(year_data_id);
        }
    
    }
}