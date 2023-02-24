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
    public class change_branchController : ControllerBase
    {
        change_branch con_branch = new change_branch();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<change_branch> Get(int id)
        {
            con_branch.branch_id = id;
            dataset = con_branch.get_change_branch_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new change_branch()
                                 {
                                     branch_id = Convert.ToInt32(rw["branch_id"]),
                                     branch_level = Convert.ToString(rw["branch_level"]),
                                     branch_class = Convert.ToString(rw["branch_class"]),
                                     branch_student = Convert.ToString(rw["branch_student"]),
                                     branch_from = Convert.ToString(rw["branch_from"]),
                                     branch_to = Convert.ToString(rw["branch_to"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<change_branch> Get()
        {
            dataset = con_branch.get_change_branch();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new change_branch()
                                 {
                                     branch_id = Convert.ToInt32(rw["branch_id"]),
                                     branch_level = Convert.ToString(rw["branch_level"]),
                                     branch_class = Convert.ToString(rw["branch_class"]),
                                     branch_student = Convert.ToString(rw["branch_student"]),
                                     branch_from = Convert.ToString(rw["branch_from"]),
                                     branch_to = Convert.ToString(rw["branch_to"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(change_branch objbranch)
        {
            con_branch.branch_level = objbranch.branch_level;
            con_branch.branch_class = objbranch.branch_class;
            con_branch.branch_student = objbranch.branch_student;
            con_branch.branch_from = objbranch.branch_from;
            con_branch.branch_to = objbranch.branch_to;

            con_branch.save_in_change_branch();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(change_branch objbranch)
        {
            con_branch.branch_id = objbranch.branch_id;
            con_branch.branch_level = objbranch.branch_level;
            con_branch.branch_class = objbranch.branch_class;
            con_branch.branch_student = objbranch.branch_student;
            con_branch.branch_from = objbranch.branch_from;
            con_branch.branch_to = objbranch.branch_to;

            con_branch.update_change_branch();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_branch.branch_id = id;
            con_branch.delete_from_change_branch();
            return new JsonResult("deleted Successfully");


        }
    }
}