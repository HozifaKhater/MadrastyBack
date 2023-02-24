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
    public class tests_metricController : ControllerBase
    {
        tests_metric con_tests = new tests_metric();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<tests_metric> Get(int id)
        {
            con_tests.tests_id = id;
            dataset = con_tests.get_tests_metric_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new tests_metric()
                                 {
                                     tests_id = Convert.ToInt32(rw["tests_id"]),
                                     tests_type = Convert.ToString(rw["tests_type"]),
                                     tests_date = Convert.ToString(rw["tests_date"]),
                                     tests_stu_no = Convert.ToInt32(rw["tests_stu_no"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<tests_metric> Get()
        {
            dataset = con_tests.get_tests_metric();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new tests_metric()
                                 {
                                     tests_id = Convert.ToInt32(rw["tests_id"]),
                                     tests_type = Convert.ToString(rw["tests_type"]),
                                     tests_date = Convert.ToString(rw["tests_date"]),
                                     tests_stu_no = Convert.ToInt32(rw["tests_stu_no"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(tests_metric objtests)
        {
            con_tests.tests_type = objtests.tests_type;
            con_tests.tests_date = objtests.tests_date;
            con_tests.tests_stu_no = objtests.tests_stu_no;


            con_tests.save_in_tests_metric();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(tests_metric objtests)
        {
            con_tests.tests_id = objtests.tests_id;
            con_tests.tests_type = objtests.tests_type;
            con_tests.tests_date = objtests.tests_date;
            con_tests.tests_stu_no = objtests.tests_stu_no;

            con_tests.update_tests_metric();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_tests.tests_id = id;
            con_tests.delete_from_tests_metric();
            return new JsonResult("deleted Successfully");


        }
    }
}