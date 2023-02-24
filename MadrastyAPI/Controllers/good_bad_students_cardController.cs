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
    public class good_bad_students_cardController : ControllerBase
    {
        good_bad_students_card con_gbsc = new good_bad_students_card();

     
        public DataSet good_bad_students_card { get; set; }



        [HttpGet]
        public List<good_bad_students_card> Get()
        {
            good_bad_students_card = con_gbsc.get_good_bad_students_card(); 
            var convertedList = (from rw in good_bad_students_card.Tables[0].AsEnumerable()
                                 select new good_bad_students_card()
                                 {
                                     student_card_id = Convert.ToInt32(rw["student_card_id"]),
                                     good_card_id = Convert.ToInt32(rw["good_card_id"]),
                                     bad_card_id = Convert.ToInt32(rw["bad_card_id"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     garde_name = Convert.ToString(rw["garde_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     good_ebda3 = Convert.ToString(rw["good_ebda3"]),
                                     good_tahfeez = Convert.ToString(rw["good_tahfeez"]),
                                     good_result = Convert.ToString(rw["good_result"]),
                                     bad_da3f = Convert.ToString(rw["bad_da3f"]),
                                     bad_da3f_reasons = Convert.ToString(rw["bad_da3f_reasons"]),
                                     bad_cure_ways = Convert.ToString(rw["bad_cure_ways"]),
                                     bad_result = Convert.ToString(rw["bad_result"]),

                                     civil_id = Convert.ToInt32(rw["civil_id"]),

                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(good_bad_students_card objgoodbad)
        {
            con_gbsc.student_card_id = objgoodbad.student_card_id;
            con_gbsc.good_card_id = objgoodbad.good_card_id;
            con_gbsc.bad_card_id = objgoodbad.bad_card_id;
            con_gbsc.grade_id = objgoodbad.grade_id;
            con_gbsc.garde_name = objgoodbad.garde_name;
            con_gbsc.class_id = objgoodbad.class_id;
            con_gbsc.class_name = objgoodbad.class_name;
            con_gbsc.subject_id = objgoodbad.subject_id;
            con_gbsc.subject_name = objgoodbad.subject_name;
            con_gbsc.student_id = objgoodbad.student_id;
            con_gbsc.student_name = objgoodbad.student_name;
            con_gbsc.good_ebda3 = objgoodbad.good_ebda3;
            con_gbsc.good_tahfeez = objgoodbad.good_tahfeez;
            con_gbsc.good_result = objgoodbad.good_result;
            con_gbsc.bad_da3f = objgoodbad.bad_da3f;
            con_gbsc.bad_da3f_reasons = objgoodbad.bad_da3f_reasons;
            con_gbsc.bad_cure_ways = objgoodbad.bad_cure_ways;
            con_gbsc.bad_result = objgoodbad.bad_result;



            con_gbsc.update_good_bad_students_card();
            return new JsonResult("Updated Successfully");
        }

        [HttpPut("bad")]
        public JsonResult Put(good_bad_students_card objgoodbad, string bad)
        {
            con_gbsc.student_card_id = objgoodbad.student_card_id;
            con_gbsc.good_card_id = objgoodbad.good_card_id;
            con_gbsc.bad_card_id = objgoodbad.bad_card_id;
            con_gbsc.grade_id = objgoodbad.grade_id;
            con_gbsc.garde_name = objgoodbad.garde_name;
            con_gbsc.class_id = objgoodbad.class_id;
            con_gbsc.class_name = objgoodbad.class_name;
            con_gbsc.subject_id = objgoodbad.subject_id;
            con_gbsc.subject_name = objgoodbad.subject_name;
            con_gbsc.student_id = objgoodbad.student_id;
            con_gbsc.student_name = objgoodbad.student_name;
            con_gbsc.good_ebda3 = objgoodbad.good_ebda3;
            con_gbsc.good_tahfeez = objgoodbad.good_tahfeez;
            con_gbsc.good_result = objgoodbad.good_result;
            con_gbsc.bad_da3f = objgoodbad.bad_da3f;
            con_gbsc.bad_da3f_reasons = objgoodbad.bad_da3f_reasons;
            con_gbsc.bad_cure_ways = objgoodbad.bad_cure_ways;
            con_gbsc.bad_result = objgoodbad.bad_result;



            con_gbsc.update_good_bad_students_card();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_gbsc.student_card_id = id;
            con_gbsc.delete_from_good_bad_students_card();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<good_bad_students_card> Get(int id)
        {
            con_gbsc.student_card_id = id;
            good_bad_students_card = con_gbsc.get_good_bad_students_card_with_id();

            var convertedList = (from rw in good_bad_students_card.Tables[0].AsEnumerable()
                                 select new good_bad_students_card()
                                 {
                                     student_card_id = Convert.ToInt32(rw["student_card_id"]),
                                     good_card_id = Convert.ToInt32(rw["good_card_id"]),
                                     bad_card_id = Convert.ToInt32(rw["bad_card_id"]),
                                     grade_id = Convert.ToInt32(rw["grade_id"]),
                                     garde_name = Convert.ToString(rw["garde_name"]),
                                     class_id = Convert.ToInt32(rw["class_id"]),
                                     class_name = Convert.ToString(rw["class_name"]),
                                     subject_id = Convert.ToInt32(rw["subject_id"]),
                                     subject_name = Convert.ToString(rw["subject_name"]),
                                     student_id = Convert.ToInt32(rw["student_id"]),
                                     student_name = Convert.ToString(rw["student_name"]),
                                     good_ebda3 = Convert.ToString(rw["good_ebda3"]),
                                     good_tahfeez = Convert.ToString(rw["good_tahfeez"]),
                                     good_result = Convert.ToString(rw["good_result"]),
                                     bad_da3f = Convert.ToString(rw["bad_da3f"]),
                                     bad_da3f_reasons = Convert.ToString(rw["bad_da3f_reasons"]),
                                     bad_cure_ways = Convert.ToString(rw["bad_cure_ways"]),
                                     bad_result = Convert.ToString(rw["bad_result"])

                                 }).ToList();

            return convertedList;
        }


        public JsonResult Post(good_bad_students_card objgood_bad_students_card)
        {
            con_gbsc.student_card_id = objgood_bad_students_card.student_card_id;
            con_gbsc.good_card_id = objgood_bad_students_card.good_card_id;
            con_gbsc.bad_card_id = objgood_bad_students_card.bad_card_id;
            con_gbsc.grade_id = objgood_bad_students_card.grade_id;
            con_gbsc.garde_name = objgood_bad_students_card.garde_name;
            con_gbsc.class_id = objgood_bad_students_card.class_id;
            con_gbsc.class_name = objgood_bad_students_card.class_name;
            con_gbsc.subject_id = objgood_bad_students_card.subject_id;
            con_gbsc.subject_name = objgood_bad_students_card.subject_name;
            con_gbsc.student_id = objgood_bad_students_card.student_id;
            con_gbsc.student_name = objgood_bad_students_card.student_name;
            con_gbsc.good_ebda3 = objgood_bad_students_card.good_ebda3;
            con_gbsc.good_tahfeez = objgood_bad_students_card.good_tahfeez;
            con_gbsc.good_result = objgood_bad_students_card.good_result;
            con_gbsc.bad_da3f = objgood_bad_students_card.bad_da3f;
            con_gbsc.bad_da3f_reasons = objgood_bad_students_card.bad_da3f_reasons;
            con_gbsc.bad_cure_ways = objgood_bad_students_card.bad_cure_ways;
            con_gbsc.bad_result = objgood_bad_students_card.bad_result;


            con_gbsc.save_in_good_bad_students_card();
            return new JsonResult("Added Successfully");
        }
    }
}