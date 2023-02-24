using  Microsoft.AspNetCore.Mvc;
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
    public class job_details_defController : ControllerBase
    {
        job_details_def con_m_det_jobs = new job_details_def();
        public DataSet dataset1 { get; set; }
        master_jobs con_m_jobs = new master_jobs();
        public DataSet jobs { get; set; }
        [HttpPost]
        public JsonResult Post(job_details_def objjobs)
        {
            con_m_det_jobs.job_id = objjobs.job_id;
            con_m_det_jobs.priv_name = objjobs.priv_name;
            con_m_det_jobs.priv_def_id = objjobs.priv_def_id;
            con_m_det_jobs.page_name = objjobs.page_name;
            con_m_det_jobs.dep_work = objjobs.dep_work;
            con_m_det_jobs.in_class_priv = objjobs.in_class_priv;

            con_m_det_jobs.save_in_job_details_def();
            return new JsonResult("Added Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_m_det_jobs.job_id = id;
            con_m_det_jobs.delete_from_job_details_def();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("privs")]
        public List<job_details_def> Get()
        {
            dataset1 = con_m_det_jobs.get_privilige_def();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new job_details_def()
                                 {
                                     menu_id = Convert.ToInt32(rw["menu_id"]),
                                     user_menu_name = Convert.ToString(rw["user_menu_name"])
                                    
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("job_id")]
        public List<job_details_def> Get(int job_id)
        {
            con_m_jobs.job_id = job_id;
            jobs = con_m_jobs.get_emp_def_with_job_id();

            var convertedList = (from rw in jobs.Tables[0].AsEnumerable()
                                 select new job_details_def()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("job_id_priv")]
        public List<job_details_def> Get(string job_id_priv)
        {
            con_m_det_jobs.job_id = Convert.ToInt32(job_id_priv);
            jobs = con_m_det_jobs.get_job_details_for_job();

            var convertedList = (from rw in jobs.Tables[0].AsEnumerable()
                                 select new job_details_def()
                                 {
                                     priv_id = Convert.ToInt32(rw["priv_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"])

                                 }).ToList();

            return convertedList;
        }
    }
}
