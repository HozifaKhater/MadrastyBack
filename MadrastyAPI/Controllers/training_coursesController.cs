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
    public class training_coursesController : ControllerBase
    {
        training_courses con_trainig_cor = new training_courses();
        public DataSet dataset { get; set; }
  
        [HttpPost]
        public JsonResult Post(training_courses objtraining_courses)
        {
            con_trainig_cor.trainig_name = objtraining_courses.trainig_name;
            con_trainig_cor.trainig_from = objtraining_courses.trainig_from;
            con_trainig_cor.trainig_to = objtraining_courses.trainig_to;
            con_trainig_cor.traing_desc = objtraining_courses.traing_desc;


            con_trainig_cor.save_in_training_courses();
            return new JsonResult("Added Successfully");
        }
    }
}