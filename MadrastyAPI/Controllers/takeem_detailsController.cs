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
    public class takeem_detailsController : ControllerBase
    {
        takeem_details con_takimdet = new takeem_details();


        public DataSet takeem_details { get; set; }

        [HttpGet]
        public List<takeem_details> Get()
        {
            takeem_details = con_takimdet.get_takeem_details();
            var convertedList = (from rw in takeem_details.Tables[0].AsEnumerable()
                                 select new takeem_details()
                                 {

                                     takeem_detail_id = Convert.ToInt32(rw["takeem_detail_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     Evaluation_item_id = Convert.ToInt32(rw["Evaluation_item_id"]),
                                     Evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     Evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     Evaluation_score = Convert.ToInt32(rw["Evaluation_score"]),
                                      evaluation_result = Convert.ToInt32(rw["evaluation_result"])




                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(takeem_details objtakimdet)
        {
            con_takimdet.takeem_detail_id = objtakimdet.takeem_detail_id;
            con_takimdet.takeem_id = objtakimdet.takeem_id;
            con_takimdet.Evaluation_item_id = objtakimdet.Evaluation_item_id;
            con_takimdet.Evaluation_item_name = objtakimdet.Evaluation_item_name;
            con_takimdet.Evaluation_appreciation = objtakimdet.Evaluation_appreciation;
            con_takimdet.Evaluation_score = objtakimdet.Evaluation_score;
            con_takimdet.evaluation_result = objtakimdet.evaluation_result;


            con_takimdet.update_takeem_details();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_takimdet.takeem_detail_id = id;
            con_takimdet.delete_from_takeem_details();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<takeem_details> Get(int id)
        {
            con_takimdet.takeem_detail_id = id;
            takeem_details = con_takimdet.get_takeem_details_with_id();

            var convertedList = (from rw in takeem_details.Tables[0].AsEnumerable()
                                 select new takeem_details()
                                 {

                                     takeem_detail_id = Convert.ToInt32(rw["takeem_detail_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     Evaluation_item_id = Convert.ToInt32(rw["Evaluation_item_id"]),
                                     Evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     Evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     Evaluation_score = Convert.ToInt32(rw["Evaluation_score"]),
                                     evaluation_result = Convert.ToInt32(rw["evaluation_result"])
                                 }).ToList();

            return convertedList;
        }


        public JsonResult Post(takeem_details objtakimdet)
        {


            con_takimdet.takeem_id = objtakimdet.takeem_id;
            con_takimdet.Evaluation_item_id = objtakimdet.Evaluation_item_id;
            con_takimdet.Evaluation_item_name = objtakimdet.Evaluation_item_name;
            con_takimdet.Evaluation_appreciation = objtakimdet.Evaluation_appreciation;
            con_takimdet.Evaluation_score = objtakimdet.Evaluation_score;
            con_takimdet.evaluation_result = objtakimdet.evaluation_result;

            con_takimdet.save_in_takeem_details();
            return new JsonResult("Added Successfully");
        }
        [HttpGet("get_takeem_details_with_takeem_id")]
        public List<takeem_details> get_takeem_details_with_takeem_id(int id)
        {
            con_takimdet.takeem_id = id;
            takeem_details = con_takimdet.get_takeem_details_with_takeem_id();

            var convertedList = (from rw in takeem_details.Tables[0].AsEnumerable()
                                 select new takeem_details()
                                 {

                                     takeem_detail_id = Convert.ToInt32(rw["takeem_detail_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     Evaluation_item_id = Convert.ToInt32(rw["Evaluation_item_id"]),
                                     Evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     Evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     Evaluation_score = Convert.ToInt32(rw["Evaluation_score"]),
                                     evaluation_result = Convert.ToInt32(rw["evaluation_result"])




                                 }).ToList();

            return convertedList;
        }
        [HttpPost("get_evaluation_with_evaluation_subject")]
        public List<takeem_details> get_evaluation_with_evaluation_subject(takeem_details objtakimdet)
        {
            con_takimdet.evaluation_subject_id = objtakimdet.evaluation_subject_id;
            con_takimdet.evaluation_date = objtakimdet.evaluation_date;
            takeem_details = con_takimdet.get_evaluation_with_evaluation_subject();

            var convertedList = (from rw in takeem_details.Tables[0].AsEnumerable()
                                 select new takeem_details()
                                 {

                                     takeem_detail_id = Convert.ToInt32(rw["takeem_detail_id"]),
                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     Evaluation_item_id = Convert.ToInt32(rw["Evaluation_item_id"]),
                                     Evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     Evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     Evaluation_score = Convert.ToInt32(rw["Evaluation_score"]),
                                     evaluation_result = Convert.ToInt32(rw["evaluation_result"])
                                 }).ToList();

            return convertedList;
        }

    }
}