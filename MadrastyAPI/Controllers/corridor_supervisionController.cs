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
    public class corridor_supervisionController : ControllerBase
    {
        corridor_supervision con_corsup = new corridor_supervision();


        public DataSet corridor_supervision { get; set; }

        [HttpGet]
        public List<corridor_supervision> Get()
        {
            corridor_supervision = con_corsup.get_corridor_supervision();
            var convertedList = (from rw in corridor_supervision.Tables[0].AsEnumerable()
                                 select new corridor_supervision()
                                 {

                                     supervision_id = Convert.ToInt32(rw["supervision_id"]),
                                     corridor_id = Convert.ToInt32(rw["corridor_id"]),
                                     basic_emp_id = Convert.ToInt32(rw["basic_emp_id"]),
                                     basic_emp_name = Convert.ToString(rw["basic_emp_name"]),
                                     spare_emp_id = Convert.ToInt32(rw["spare_emp_id"]),
                                     spare_emp_name = Convert.ToString(rw["spare_emp_name"]),
                                     from_date = Convert.ToString(rw["from_date"]),
                                     to_date = Convert.ToString(rw["to_date"]),
                                     corridor_name = Convert.ToString(rw["corridor_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"])



                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(corridor_supervision objcorsup)
        {
            con_corsup.supervision_id = objcorsup.supervision_id;
            con_corsup.corridor_id = objcorsup.corridor_id;
            con_corsup.basic_emp_id = objcorsup.basic_emp_id;
            con_corsup.basic_emp_name = objcorsup.basic_emp_name;
            con_corsup.spare_emp_id = objcorsup.spare_emp_id;
            con_corsup.spare_emp_name = objcorsup.spare_emp_name;
            con_corsup.from_date = objcorsup.from_date;
            con_corsup.to_date = objcorsup.to_date;
            con_corsup.corridor_name = objcorsup.corridor_name;
            con_corsup.dep_id = objcorsup.dep_id;
            con_corsup.dep_name = objcorsup.dep_name;
            con_corsup.emp_id = objcorsup.emp_id;
            con_corsup.emp_name = objcorsup.emp_name;

          con_corsup.update_corridor_supervision();
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_corsup.supervision_id = id;
            con_corsup.delete_from_corridor_supervision();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<corridor_supervision> Get(int id)
        {
            con_corsup.supervision_id = id;
            corridor_supervision = con_corsup.get_corridor_supervision_with_id();

            var convertedList = (from rw in corridor_supervision.Tables[0].AsEnumerable()
                                 select new corridor_supervision()
                                 {

                                     supervision_id = Convert.ToInt32(rw["supervision_id"]),
                                     corridor_id = Convert.ToInt32(rw["corridor_id"]),
                                     basic_emp_id = Convert.ToInt32(rw["basic_emp_id"]),
                                     basic_emp_name = Convert.ToString(rw["basic_emp_name"]),
                                     spare_emp_id = Convert.ToInt32(rw["spare_emp_id"]),
                                     spare_emp_name = Convert.ToString(rw["spare_emp_name"]),
                                     from_date = Convert.ToString(rw["from_date"]),
                                     to_date = Convert.ToString(rw["to_date"]),
                                     corridor_name = Convert.ToString(rw["corridor_name"]),
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"])



                                 }).ToList();

            return convertedList;
        }


        public JsonResult Post(corridor_supervision objcorridor_supervision)
        {
            //con_corsup.supervision_id = objcorridor_supervision.supervision_id;
            con_corsup.corridor_id = objcorridor_supervision.corridor_id;
            con_corsup.basic_emp_id = objcorridor_supervision.basic_emp_id;
            con_corsup.basic_emp_name = objcorridor_supervision.basic_emp_name;
            con_corsup.spare_emp_id = objcorridor_supervision.spare_emp_id;
            con_corsup.spare_emp_name = objcorridor_supervision.spare_emp_name;
            con_corsup.from_date = objcorridor_supervision.from_date;
            con_corsup.to_date = objcorridor_supervision.to_date;
            con_corsup.corridor_name = objcorridor_supervision.corridor_name;
            con_corsup.dep_id = objcorridor_supervision.dep_id;
            con_corsup.dep_name = objcorridor_supervision.dep_name;
            con_corsup.emp_id = objcorridor_supervision.emp_id;
            con_corsup.emp_name = objcorridor_supervision.emp_name;

            con_corsup.save_in_corridor_supervision();
            return new JsonResult("Added Successfully");
        }

    }
}