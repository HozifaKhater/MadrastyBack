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
    public class twze3_students_mostwa_t7sylyController : ControllerBase
    {
        twze3_students_mostwa_t7syly con_obj = new twze3_students_mostwa_t7syly();

        public DataSet dataset1 { get; set; }

        // GET: api/<controller>
        [HttpGet]
        public List<twze3_students_mostwa_t7syly> Get()
        {
            dataset1 = con_obj.get_levels_with_stistics();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new twze3_students_mostwa_t7syly()
                                 {
                                   
                                     level_id = Convert.ToInt32(rw["level_id"]),
                                     level_name = Convert.ToString(rw["level_name"]),
                                     first_term_fails = Convert.ToInt32(rw["first_term_fails"]),
                                     second_term_fails = Convert.ToInt32(rw["second_term_fails"]),
                                     academic_failure = Convert.ToInt32(rw["academic_failure"]),
                                     academic_excellence = Convert.ToInt32(rw["academic_excellence"]),

                                 }).ToList();

            return convertedList;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        [HttpPost]
        public void Post(twze3_students_mostwa_t7syly obj)
        {
         
            con_obj.level_id = obj.level_id;
            con_obj.level_name = obj.level_name;
            con_obj.first_term_fails = obj.first_term_fails;
            con_obj.second_term_fails = obj.second_term_fails;
            con_obj.academic_failure = obj.academic_failure;
            con_obj.academic_excellence = obj.academic_excellence;


            con_obj.save_in_twze3_students_mostwa_t7syly();

        }
    

    }
}