using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Linq;
using  System.Threading.Tasks;
using  Microsoft.AspNetCore.Mvc;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class new_workController : ControllerBase
    {
        new_work con_obj = new new_work();


        public DataSet dataset1 { get; set; }

        [HttpGet]
        public List<new_work> Get()
        {
            dataset1 = con_obj.get_new_work();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new new_work()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     new_work_var = Convert.ToString(rw["new_work"]),
                                     date = Convert.ToString(rw["date"])




                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(new_work obj)
        {
            con_obj.ser = obj.ser;
            con_obj.new_work_var = obj.new_work_var;
            con_obj.date = obj.date;



            con_obj.update_new_work();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_obj.ser = id;
            con_obj.delete_from_new_work();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<new_work> Get(int id)
        {
            con_obj.ser = id;
            dataset1 = con_obj.get_new_work_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new new_work()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),
                                     new_work_var = Convert.ToString(rw["new_work"]),
                                     date = Convert.ToString(rw["date"])



                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(new_work obj)
        {



            con_obj.new_work_var = obj.new_work_var;
            con_obj.date = obj.date;

            var year_data_id = con_obj.save_in_new_work();
            return new JsonResult(year_data_id);
        }
    }
}