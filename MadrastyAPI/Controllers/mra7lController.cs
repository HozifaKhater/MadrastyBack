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
    public class mra7lController : ControllerBase
    {

        mra7l con_mra7l = new mra7l();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<mra7l> Get(int id)
        {
            con_mra7l.mr7la_id = id;
            dataset = con_mra7l.get_mra7l_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new mra7l()
                                 {
                                     mr7la_id = Convert.ToInt32(rw["mr7la_id"]),
                                     mr7la_name = Convert.ToString(rw["mr7la_name"]),
                                     mr7la_code = Convert.ToInt32(rw["mr7la_code"]),
                                     mr7la_desc = Convert.ToString(rw["mr7la_desc"])
                                   

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<mra7l> Get()
        {
            dataset = con_mra7l.get_mra7l();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new mra7l()
                                 {
                                     mr7la_id = Convert.ToInt32(rw["mr7la_id"]),
                                     mr7la_name = Convert.ToString(rw["mr7la_name"]),
                                     mr7la_code = Convert.ToInt32(rw["mr7la_code"]),
                                     mr7la_desc = Convert.ToString(rw["mr7la_desc"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(mra7l objmra7l)
        {
            con_mra7l.mr7la_name = objmra7l.mr7la_name;
            con_mra7l.mr7la_code = objmra7l.mr7la_code;
            con_mra7l.mr7la_desc = objmra7l.mr7la_desc;



            con_mra7l.save_in_mra7l();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(mra7l objmra7l)
        {
            con_mra7l.mr7la_id = objmra7l.mr7la_id;
            con_mra7l.mr7la_name = objmra7l.mr7la_name;
            con_mra7l.mr7la_code = objmra7l.mr7la_code;
            con_mra7l.mr7la_desc = objmra7l.mr7la_desc;


            con_mra7l.update_mra7l();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_mra7l.mr7la_id = id;
            con_mra7l.delete_from_mra7l();
            return new JsonResult("deleted Successfully");


        }

    }
}