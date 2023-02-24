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
    public class gdwel_7ssController : ControllerBase
    {
        gdwel_7ss con_hol = new gdwel_7ss();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<gdwel_7ss> Get(int id)
        {
            con_hol.id = id;
            subject = con_hol.get_gdwel_7ss_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<gdwel_7ss> Get()
        {
            subject = con_hol.get_gdwel_7ss();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"])
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(gdwel_7ss objsubject)
        {

            con_hol.title = objsubject.title;
            con_hol.start = objsubject.start;
            con_hol.end = objsubject.end;
            con_hol.className = objsubject.className;

            con_hol.save_in_gdwel_7ss();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(gdwel_7ss objsubject)
        {
            con_hol.id = objsubject.id;
            con_hol.title = objsubject.title;
            con_hol.start = objsubject.start;
            con_hol.end = objsubject.end;
            con_hol.className = objsubject.className;


            con_hol.update_gdwel_7ss();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_hol.id = id;
            con_hol.delete_from_gdwel_7ss();
            return new JsonResult("deleted Successfully");


        }
    }
}