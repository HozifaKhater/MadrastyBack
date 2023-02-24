using  BusinessLogic.Abstractions;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;
using  MadrastyAPI.Models;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ta7dierJoinEmployeeController : Controller
    {
        /*
        private readonly ITa7dierJoinEmployeeService _ta7dierJoinEmployeeService;

        public Ta7dierJoinEmployeeController(ITa7dierJoinEmployeeService ta7dierJoinEmployeeService)
        {
            _ta7dierJoinEmployeeService = ta7dierJoinEmployeeService;
        }

        [HttpGet("ta7dier")]
        public async Task<IActionResult> GetTa7dierTable(Ta7dierJoinEmployee ta7dier)
        {
            return Ok(await _ta7dierJoinEmployeeService.GetTa7dierWithDeptAndSubj(ta7dier));
        }*/

        Ta7dierJoinEmployee con = new Ta7dierJoinEmployee();
        public DataSet dataset { get; set; }

        CLS_connection con_abs = new CLS_connection();

        [HttpGet("ta7dier")]
        public List<Ta7dierJoinEmployee> Get(Ta7dierJoinEmployee ta7Dier)
        {
            con.emp_dep = ta7Dier.emp_dep;
            con.subject_name = ta7Dier.subject_name;

            dataset = con.get_t7deer_with_dept_and_subj();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new Ta7dierJoinEmployee()
                                 {
                                     ta7dier_week = Convert.ToInt32(rw["ta7dier_week"]),
                                     ta7dier_day = Convert.ToInt32(rw["ta7dier_day"]),
                                     ta7dier_date = Convert.ToString(rw["ta7dier_date"]),
                                     ta7dier_name = Convert.ToString(rw["ta7dier_name"]),
                                     ta7dier_notes = Convert.ToString(rw["ta7dier_notes"]),
                                     className = Convert.ToString(rw["className"]),
                                     lev_name = Convert.ToString(rw["lev_name"]),
                                     emp_name = Convert.ToString(rw["emp_name"]),
                         
                                 }).ToList();

            return convertedList;
        }
    }
}
