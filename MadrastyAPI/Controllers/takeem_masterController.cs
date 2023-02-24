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
    public class takeem_masterController : ControllerBase
    {
        takeem_master con_takimaster = new takeem_master();


        public DataSet takeem_master { get; set; }

        [HttpGet]
        public List<takeem_master> Get()
        {
            takeem_master = con_takimaster.get_takeem_master();
            var convertedList = (from rw in takeem_master.Tables[0].AsEnumerable()
                                 select new takeem_master()
                                 {

                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     evaluation_id = Convert.ToInt32(rw["evaluation_id"]),
                                     evaluation_object = Convert.ToInt32(rw["evaluation_object"]),
                                     evaluation_object_name = Convert.ToString(rw["evaluation_object_name"]),
                                     evaluation_subject = Convert.ToString(rw["evaluation_subject"]),
                                     evaluation_subject_id = Convert.ToInt32(rw["evaluation_subject_id"]),
                                     the_object_id = Convert.ToInt32(rw["the_object_id"]),
                                     evaluation_date = Convert.ToString(rw["evaluation_date"])
                                



                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(takeem_master objtakimaster)
        {
            con_takimaster.takeem_id = objtakimaster.takeem_id;
            con_takimaster.evaluation_id = objtakimaster.evaluation_id;
            con_takimaster.evaluation_object = objtakimaster.evaluation_object;
            con_takimaster.evaluation_object_name = objtakimaster.evaluation_object_name;
            con_takimaster.evaluation_subject = objtakimaster.evaluation_subject;
            con_takimaster.evaluation_subject_id = objtakimaster.evaluation_subject_id;
            con_takimaster.the_object_id = objtakimaster.the_object_id;
            con_takimaster.evaluation_date = objtakimaster.evaluation_date;


            con_takimaster.update_takeem_master();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_takimaster.takeem_id = id;
            con_takimaster.delete_from_takeem_master();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<takeem_master> Get(int id)
        {
            con_takimaster.takeem_id = id;
            takeem_master = con_takimaster.get_takeem_master_with_id();

            var convertedList = (from rw in takeem_master.Tables[0].AsEnumerable()
                                 select new takeem_master()
                                 {

                                     takeem_id = Convert.ToInt32(rw["takeem_id"]),
                                     evaluation_id = Convert.ToInt32(rw["evaluation_id"]),
                                     evaluation_object = Convert.ToInt32(rw["evaluation_object"]),
                                     evaluation_object_name = Convert.ToString(rw["evaluation_object_name"]),
                                     evaluation_subject = Convert.ToString(rw["evaluation_subject"]),
                                     evaluation_subject_id = Convert.ToInt32(rw["evaluation_subject_id"]),
                                     the_object_id = Convert.ToInt32(rw["the_object_id"]),
                                     evaluation_date = Convert.ToString(rw["evaluation_date"])
                           



                                 }).ToList();

            return convertedList;
        }


        public JsonResult Post(takeem_master objtakimaster)
        {
          
            con_takimaster.evaluation_id = objtakimaster.evaluation_id;
            con_takimaster.evaluation_object = objtakimaster.evaluation_object;
            con_takimaster.evaluation_object_name = objtakimaster.evaluation_object_name;
            con_takimaster.evaluation_subject = objtakimaster.evaluation_subject;
            con_takimaster.evaluation_subject_id = objtakimaster.evaluation_subject_id;
            con_takimaster.the_object_id = objtakimaster.the_object_id;
            con_takimaster.evaluation_date = objtakimaster.evaluation_date;

           var returned_id = con_takimaster.save_in_takeem_master();
            return new JsonResult(returned_id);
        }
    }
}