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
    public class update_class_in_studentController : ControllerBase
    {
        student con_update_stu = new student();
        public DataSet dataset { get; set; }
        [HttpPut]
        public JsonResult Put(student objstudent)
        {
            con_update_stu.student_id = objstudent.student_id;
            con_update_stu.student_class_id = objstudent.student_class_id;
            con_update_stu.student_class_name = objstudent.student_class_name;


            con_update_stu.update_class_in_student();
            return new JsonResult("Updated Successfully");
        }
    }
}