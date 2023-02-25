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
                                     className = Convert.ToString(rw["className"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_id = Convert.ToInt32(rw["class_id"])

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
                                     className = Convert.ToString(rw["className"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_id = Convert.ToInt32(rw["class_id"])
                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(gdwel_7ss objsubjects)
        {
            var dateStart = Convert.ToDateTime(objsubjects.start);
            var dateEnd = Convert.ToDateTime(objsubjects.end);

            while (dateStart < dateEnd)
            {
                var objsubject = new gdwel_7ss
                {
                    title = objsubjects.title,
                    start = dateStart.ToString(),
                    end = objsubjects.end,
                    className = objsubjects.className,
                    emp_id = objsubjects.emp_id,
                    emp_name = objsubjects.emp_name,
                    subject_id = objsubjects.subject_id,
                    level_id = objsubjects.level_id,
                    class_id = objsubjects.class_id
                };

                con_hol.title = objsubject.title;
                con_hol.start = objsubject.start;
                con_hol.end = objsubject.end;
                con_hol.className = objsubject.className;
                con_hol.emp_id = objsubject.emp_id;
                con_hol.emp_name = objsubject.emp_name;
                con_hol.subject_id = objsubject.subject_id;
                con_hol.level_id = objsubject.level_id;
                con_hol.class_id = objsubject.class_id;

                con_hol.save_in_gdwel_7ss();

                dateStart = dateStart.AddDays(7);
            }
            
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
            con_hol.emp_id = objsubject.emp_id;
            con_hol.emp_name = objsubject.emp_name;
            con_hol.subject_id = objsubject.subject_id;
            con_hol.level_id = objsubject.level_id;
            con_hol.class_id = objsubject.class_id;
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
        [HttpGet("gdwel_id")]
        public List<gdwel_7ss> get_gdwel_replacements_with_gdwel_id(int id)
        {
            con_hol.id = id;
            subject = con_hol.get_gdwel_replacements_with_gdwel_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     replacement = Convert.ToString(rw["replacement"]),
                                     replacement_id = Convert.ToInt32(rw["replacement_id"])

                                 }).ToList();

            return convertedList;
        }
        [HttpPost("save_in_gdwel_replacements")]
        public JsonResult save_in_gdwel_replacements(gdwel_7ss objsubject)
        {

            con_hol.id = objsubject.id;
            con_hol.replacement = objsubject.replacement;
            con_hol.replacement_id = objsubject.replacement_id;


            con_hol.save_in_gdwel_replacements();
            return new JsonResult("Added Successfully");
        }
        [HttpPost("delete_from_gdwel_replacements_with_gdwel_id")]
        public JsonResult delete_from_gdwel_replacements_with_gdwel_id(gdwel_7ss objsubject)
        {

            con_hol.id = objsubject.id;



            con_hol.delete_from_gdwel_replacements_with_gdwel_id();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("get_gdwel_7ss_with_subject_id")]
        public List<gdwel_7ss> get_gdwel_7ss_with_subject_id(int id)
        {
            con_hol.subject_id = id;
            subject = con_hol.get_gdwel_7ss_with_subject_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"]),
                                     class_id = Convert.ToInt32(rw["id"]),
                                     level_id = Convert.ToInt32(rw["id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     lev_name = Convert.ToString(rw["lev_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_gdwel_7ss_with_emp_id")]
        public List<gdwel_7ss> get_gdwel_7ss_with_emp_id(int id)
        {
            con_hol.emp_id = id;
            subject = con_hol.get_gdwel_7ss_with_emp_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     lev_name = Convert.ToString(rw["lev_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_gdwel_7ss_with_class_id")]
        public List<gdwel_7ss> get_gdwel_7ss_with_class_id(int id)
        {
            con_hol.class_id = id;
            subject = con_hol.get_gdwel_7ss_with_class_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     lev_name = Convert.ToString(rw["lev_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_gdwel_7ss_with_dep_id")]
        public List<gdwel_7ss> get_gdwel_7ss_with_dep_id(int id)
        {
            con_hol.dep_id = id;
            subject = con_hol.get_gdwel_7ss_with_dep_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     title = Convert.ToString(rw["title"]),
                                     start = Convert.ToString(rw["start"]),
                                     end = Convert.ToString(rw["end"]),
                                     className = Convert.ToString(rw["className"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     lev_name = Convert.ToString(rw["lev_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpPost("update_gdwel_7ss_is_late")]
        public JsonResult update_gdwel_7ss_is_late(gdwel_7ss objsubject)
        {
            con_hol.id = objsubject.id;
            con_hol.update_gdwel_7ss_is_late();
            return new JsonResult("Added Successfully");
        }
        [HttpPost("update_gdwel_7ss_is_block")]
        public JsonResult update_gdwel_7ss_is_block(gdwel_7ss objsubject)
        {
            con_hol.id = objsubject.id;
            con_hol.update_gdwel_7ss_is_block();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("get_gdwel_7ss_new")]
        public async Task<IActionResult> get_gdwel_7ss_new(int id)
        {
            con_hol.class_id = id;
            subject = con_hol.get_gdwel_7ss_new();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     teacher = Convert.ToString(rw["teacher"]),
                                     @class = Convert.ToString(rw["class"]),
                                     level = Convert.ToString(rw["level"]),
                                     eventtime = Convert.ToString(rw["eventtime"]),
                                     day = Convert.ToString(rw["day"])
                                 })
                     .GroupBy(x => x.day)
                     .Select(x=> new { day = x.Key , events = x.Select(e=> new { e.teacher,e.level,e.@class, e.eventtime }) })
                     .ToList();

            return Ok(convertedList);

          //  return Ok((List<gdwel_7ss>)convertedList.GroupBy(x => x.day));

            //return (List<gdwel_7ss>)convertedList.GroupBy(x=>x.day);
        }
        [HttpGet("get_gdwel_7ss_all")]
        public async Task<IActionResult> get_gdwel_7ss_all()
        {
            subject = con_hol.get_gdwel_7ss_all();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new gdwel_7ss()
                                 {
                                     @class = Convert.ToString(rw["class"]),
                                     title = Convert.ToString(rw["title"]),
                                     position = Convert.ToInt32(rw["position"])
                                 })
                     .GroupBy(x => x.@class)
                     .Select(x => new { @class = x.Key, events = x.Select(e => new { e.title, e.position }) })
                     .ToList();

            return Ok(convertedList);

            //  return Ok((List<gdwel_7ss>)convertedList.GroupBy(x => x.day));

            //return (List<gdwel_7ss>)convertedList.GroupBy(x=>x.day);
        }
    }
}