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
    public class countriesController : ControllerBase
    {
        CLS_connection con_abs = new CLS_connection();

        public DataSet dataset { get; set; }

        [HttpGet]
        public List<CLS_connection> Get()
        {
            
            dataset = con_abs.get_countries();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new CLS_connection()
                                 {
                                     country_id = Convert.ToInt32(rw["country_id"]),
                                     country_name = Convert.ToString(rw["country_name"])

                                 }).ToList();

            return convertedList;
        }
    }
}