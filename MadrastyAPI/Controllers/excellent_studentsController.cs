using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class excellent_studentsController : ControllerBase
    {
        excellent_students con_excstu = new excellent_students();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<excellent_students> Get(int id)
        {
            con_excstu.exc_stu_id = id;
            dataset = con_excstu.get_excellent_students_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new excellent_students()
                                 {
                                     exc_stu_id = Convert.ToInt32(rw["exc_stu_id"]),
                                     exc_stu_lev = Convert.ToString(rw["exc_stu_lev"]),
                                     exc_stu_clas = Convert.ToString(rw["exc_stu_clas"]),
                                     exc_stu_name = Convert.ToString(rw["exc_stu_name"]),
                                     exc_stu_nation = Convert.ToString(rw["exc_stu_nation"]),
                                     exc_stu_mob = Convert.ToInt32(rw["exc_stu_mob"]),
                                     exc_stu_birth = Convert.ToString(rw["exc_stu_birth"]),
                                     exc_stu_notes = Convert.ToString(rw["exc_stu_notes"]),
                                     exc_stu_eff = Convert.ToString(rw["exc_stu_eff"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<excellent_students> Get()
        {
            dataset = con_excstu.get_excellent_students();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new excellent_students()
                                 {
                                     exc_stu_id = Convert.ToInt32(rw["exc_stu_id"]),
                                     exc_stu_lev = Convert.ToString(rw["exc_stu_lev"]),
                                     exc_stu_clas = Convert.ToString(rw["exc_stu_clas"]),
                                     exc_stu_name = Convert.ToString(rw["exc_stu_name"]),
                                     exc_stu_nation = Convert.ToString(rw["exc_stu_nation"]),
                                     exc_stu_mob = Convert.ToInt32(rw["exc_stu_mob"]),
                                     exc_stu_birth = Convert.ToString(rw["exc_stu_birth"]),
                                     exc_stu_notes = Convert.ToString(rw["exc_stu_notes"]),
                                     exc_stu_eff = Convert.ToString(rw["exc_stu_eff"]),

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(excellent_students objexcstu)
        {
            con_excstu.exc_stu_lev = objexcstu.exc_stu_lev;
            con_excstu.exc_stu_clas = objexcstu.exc_stu_clas;
            con_excstu.exc_stu_name = objexcstu.exc_stu_name;
            con_excstu.exc_stu_nation = objexcstu.exc_stu_nation;
            con_excstu.exc_stu_mob = objexcstu.exc_stu_mob;
            con_excstu.exc_stu_birth = objexcstu.exc_stu_birth;
            con_excstu.exc_stu_notes = objexcstu.exc_stu_notes;
            con_excstu.exc_stu_eff = objexcstu.exc_stu_eff;

            con_excstu.save_in_excellent_students();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(excellent_students objexcstu)
        {
            con_excstu.exc_stu_id = objexcstu.exc_stu_id;
            con_excstu.exc_stu_lev = objexcstu.exc_stu_lev;
            con_excstu.exc_stu_clas = objexcstu.exc_stu_clas;
            con_excstu.exc_stu_name = objexcstu.exc_stu_name;
            con_excstu.exc_stu_nation = objexcstu.exc_stu_nation;
            con_excstu.exc_stu_mob = objexcstu.exc_stu_mob;
            con_excstu.exc_stu_birth = objexcstu.exc_stu_birth;
            con_excstu.exc_stu_notes = objexcstu.exc_stu_notes;
            con_excstu.exc_stu_eff = objexcstu.exc_stu_eff;

            con_excstu.update_excellent_students();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_excstu.exc_stu_id = id;
            con_excstu.delete_from_excellent_students();
            return new JsonResult("deleted Successfully");


        }
    }
}