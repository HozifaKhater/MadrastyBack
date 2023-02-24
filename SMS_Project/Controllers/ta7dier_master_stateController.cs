using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS_project.Models;

namespace SMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ta7dier_master_stateController : Controller
    {
        ta7dier_master con_t7m = new ta7dier_master();
        public DataSet dataset1 { get; set; }
        [HttpPost]
        public JsonResult Post(ta7dier_master objta7dier_master)
        {
            con_t7m.ta7dier_id = objta7dier_master.ta7dier_id;
            con_t7m.ta7dier_state_id = objta7dier_master.ta7dier_state_id;
       
            con_t7m.update_ta7dier_master_for_state();
            return new JsonResult("Updated Successfully");
        }
    }
}
