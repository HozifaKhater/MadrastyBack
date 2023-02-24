using Microsoft.AspNetCore.Mvc;
using SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ezon_stateController : ControllerBase
    {
        ezon con_ezon = new ezon();
        public DataSet dataset1 { get; set; }
        [HttpPost]
        public JsonResult post(ezon objaezon)
        {
            con_ezon.ezn_id = objaezon.ezn_id;
            con_ezon.ezn_state = objaezon.ezn_state;
            //con_ezon.save_in_activity_def();
            con_ezon.update_absent_premit_ezoon_for_state();
            return new JsonResult("Updated Successfully");
        }
    }
}
