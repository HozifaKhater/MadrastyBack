using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class teams_and_groupsController : ControllerBase
    {
        teams_and_groups con_obj = new teams_and_groups();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<teams_and_groups> Get(int id)
        {
            con_obj.id = id;
            subject = con_obj.get_teams_and_groups_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new teams_and_groups()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     type_id = Convert.ToInt32(rw["type_id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     name = Convert.ToString(rw["name"]),
                                     goals = Convert.ToString(rw["goals"]),



                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<teams_and_groups> Get()
        {
            subject = con_obj.get_teams_and_groups();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new teams_and_groups()
                                 {

                                     id = Convert.ToInt32(rw["id"]),
                                     type_id = Convert.ToInt32(rw["type_id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     name = Convert.ToString(rw["name"]),
                                     goals = Convert.ToString(rw["goals"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(teams_and_groups obj)
        {

           
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;
            con_obj.name = obj.name;
            con_obj.goals = obj.goals;


            con_obj.save_in_teams_and_groups();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(teams_and_groups obj)
        {
            con_obj.id = obj.id;
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;
            con_obj.name = obj.name;
            con_obj.goals = obj.goals;


            con_obj.update_teams_and_groups();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.id = id;
            con_obj.delete_from_teams_and_groups();
            return new JsonResult("deleted Successfully");


        }
    }
}