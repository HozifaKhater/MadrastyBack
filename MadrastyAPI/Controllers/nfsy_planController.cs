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
    public class nfsy_planController : ControllerBase
    {
        nfsy_plan con_hol = new nfsy_plan();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<nfsy_plan> Get(int id)
        {
            con_hol.id = id;
            subject = con_hol.get_nfsy_plan_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new nfsy_plan()
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
        public List<nfsy_plan> Get()
        {
            subject = con_hol.get_nfsy_plan();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new nfsy_plan()
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
        public JsonResult Post(nfsy_plan objsubject)
        {

            con_hol.title = objsubject.title;
            con_hol.start = objsubject.start;
            con_hol.end = objsubject.end;
            con_hol.className = objsubject.className;

            con_hol.save_in_nfsy_plan();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(nfsy_plan objsubject)
        {
            con_hol.id = objsubject.id;
            con_hol.title = objsubject.title;
            con_hol.start = objsubject.start;
            con_hol.end = objsubject.end;
            con_hol.className = objsubject.className;


            con_hol.update_nfsy_plan();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_hol.id = id;
            con_hol.delete_from_nfsy_plan();
            return new JsonResult("deleted Successfully");


        }
    }
}
