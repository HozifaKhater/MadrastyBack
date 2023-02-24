using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json.Linq;
using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Controllers
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

                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"])


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
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"])

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
            con_obj.emp_name = obj.emp_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;


            var returned_id = con_obj.save_in_teams_and_groups();
            return new JsonResult(returned_id);
        }
        [HttpPut]
        public JsonResult Put(teams_and_groups obj)
        {
            con_obj.id = obj.id;
            con_obj.type_id = obj.type_id;
            con_obj.type_name = obj.type_name;
            con_obj.name = obj.name;
            con_obj.goals = obj.goals;
            con_obj.emp_name = obj.emp_name;
            con_obj.emp_id = obj.emp_id;
            con_obj.dep_id = obj.dep_id;
            con_obj.dep_name = obj.dep_name;


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

        [HttpGet("details_id")]
        public List<teams_and_groups> get_teams_members_with_id(int id)
        {
            con_obj.id = id;
            subject = con_obj.get_teams_members_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new teams_and_groups()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     team_id = Convert.ToInt32(rw["team_id"]),
                                     team_name = Convert.ToString(rw["team_name"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"])




                                 }).ToList();

            return convertedList;
        }
        [HttpGet("details")]
        public List<teams_and_groups> get_teams_members()
        {
            subject = con_obj.get_teams_members();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new teams_and_groups()
                                 {

                                     ser = Convert.ToInt32(rw["ser"]),
                                     team_id = Convert.ToInt32(rw["team_id"]),
                                     team_name = Convert.ToString(rw["team_name"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost("details")]
        public JsonResult save_in_teams_members(teams_and_groups obj)
        {

            con_obj.team_id = obj.team_id;
            con_obj.team_name = obj.team_name;
            con_obj.emp_name = obj.emp_name;
            con_obj.emp_id = obj.emp_id;

            con_obj.save_in_teams_members();
            return new JsonResult("Added Successfully");
        }
        [HttpPut("details")]
        public JsonResult update_teams_members(teams_and_groups obj)
        {
            con_obj.ser = obj.ser;
            con_obj.team_id = obj.team_id;
            con_obj.team_name = obj.team_name;
            con_obj.emp_name = obj.emp_name;
            con_obj.emp_id = obj.emp_id;


            con_obj.update_teams_members();
            return new JsonResult("Updated Successfully");
        }
        [HttpPost("delete_details")]
        public JsonResult delete_from_teams_members(teams_and_groups obj)
        {
            con_obj.ser = obj.id;
            con_obj.delete_from_teams_members();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("get_teams_members_with_team_id")]
        public List<teams_and_groups> get_teams_members_with_team_id(int id)
        {
            con_obj.team_id = id;
            subject = con_obj.get_teams_members_with_team_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new teams_and_groups()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     team_id = Convert.ToInt32(rw["team_id"]),
                                     team_name = Convert.ToString(rw["team_name"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"])




                                 }).ToList();

            return convertedList;
        }
    }
}