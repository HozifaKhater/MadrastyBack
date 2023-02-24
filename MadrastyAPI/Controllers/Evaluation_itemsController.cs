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
    public class Evaluation_itemsController : ControllerBase
    {
        Evaluation_items con_evit = new Evaluation_items();

        public DataSet Evaluation_items { get; set; }

        [HttpGet]
        public List<Evaluation_items> Get()
        {
            Evaluation_items = con_evit.get_evaluation_settings();
            var convertedList = (from rw in Evaluation_items.Tables[0].AsEnumerable()
                                 select new Evaluation_items    ()
                                 {

                                     evaluation_id = Convert.ToInt32(rw["evaluation_id"]),
                                     evaluation_object = Convert.ToInt32(rw["evaluation_object"]),
                                     evaluation_object_name = Convert.ToString(rw["evaluation_object_name"]),
                                     evaluation_subject = Convert.ToString(rw["evaluation_subject"]),
                                     evaluation_subject_id = Convert.ToInt32(rw["evaluation_subject_id"]),
                                 evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     evaluation_score = Convert.ToInt32(rw["Evaluation_score"])





                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(Evaluation_items objEvaluation_items)
        {
            con_evit.evaluation_id = objEvaluation_items.evaluation_id;
            con_evit.evaluation_object = objEvaluation_items.evaluation_object;
            con_evit.evaluation_object_name = objEvaluation_items.evaluation_object_name;
            con_evit.evaluation_subject = objEvaluation_items.evaluation_subject;
            con_evit.evaluation_subject_id = objEvaluation_items.evaluation_subject_id;     
            con_evit.evaluation_item_name = objEvaluation_items.evaluation_item_name;
            con_evit.evaluation_appreciation = objEvaluation_items.evaluation_appreciation;
            con_evit.evaluation_score = objEvaluation_items.evaluation_score;

            con_evit.update_evaluation_settings();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_evit.evaluation_id = id;
            con_evit.delete_from_evaluation_settings();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<Evaluation_items> Get(int id)
        {
            con_evit.evaluation_id = id;
            Evaluation_items = con_evit.get_evaluation_settings_with_id();

            var convertedList = (from rw in Evaluation_items.Tables[0].AsEnumerable()
                                 select new Evaluation_items()
                                 {

                                     evaluation_id = Convert.ToInt32(rw["evaluation_id"]),
                                     evaluation_object = Convert.ToInt32(rw["evaluation_object"]),
                                     evaluation_object_name = Convert.ToString(rw["evaluation_object_name"]),
                                     evaluation_subject = Convert.ToString(rw["evaluation_subject"]),
                                     evaluation_subject_id = Convert.ToInt32(rw["evaluation_subject_id"]),                              
                                     evaluation_item_name = Convert.ToString(rw["Evaluation_item_name"]),
                                     evaluation_appreciation = Convert.ToString(rw["Evaluation_appreciation"]),
                                     evaluation_score = Convert.ToInt32(rw["Evaluation_score"])





                                 }).ToList();

            return convertedList;
        }

        public JsonResult Post(Evaluation_items objEvaluation_items)
        {
            con_evit.evaluation_id = objEvaluation_items.evaluation_id;
            con_evit.evaluation_object = objEvaluation_items.evaluation_object;
            con_evit.evaluation_object_name = objEvaluation_items.evaluation_object_name;
            con_evit.evaluation_subject = objEvaluation_items.evaluation_subject;
            con_evit.evaluation_subject_id = objEvaluation_items.evaluation_subject_id;       
            con_evit.evaluation_item_name = objEvaluation_items.evaluation_item_name;
            con_evit.evaluation_appreciation = objEvaluation_items.evaluation_appreciation;
            con_evit.evaluation_score = objEvaluation_items.evaluation_score;

            con_evit.save_in_evaluation_settings();
            return new JsonResult("Added Successfully");
        }

    }
}