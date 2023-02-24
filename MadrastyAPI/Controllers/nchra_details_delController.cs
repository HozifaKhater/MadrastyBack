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
    public class nchra_details_delController : ControllerBase
    {
        nchra_details con_nchra_det = new nchra_details();


        public DataSet dataset { get; set; }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_nchra_det.nchra_id = id;
            con_nchra_det.delete_from_nchra_details_with_nchra_id();
            return new JsonResult("deleted Successfully");


        }
    }
}