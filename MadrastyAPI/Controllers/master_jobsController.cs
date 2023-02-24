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
    public class master_jobsController : ControllerBase
    {
        master_jobs con_m_jobs = new master_jobs();
        public DataSet jobs { get; set; }
        job_details_def con_m_det_jobs = new job_details_def();
        public DataSet dataset1 { get; set; }
        public DataSet get_job_master_def
        {
            get { return con_m_jobs.get_job_master_def(); }
        }
        [HttpGet]
        public List<master_jobs> Get()
        {
            var convertedList = (from rw in get_job_master_def.Tables[0].AsEnumerable()
                                 select new master_jobs()
                                 {
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     job_desc = Convert.ToString(rw["job_desc"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"])
                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(master_jobs objjobs)
        {
            con_m_jobs.job_id = objjobs.job_id;
            con_m_jobs.job_name = objjobs.job_name;
            con_m_jobs.job_desc = objjobs.job_desc;
            con_m_jobs.in_class_priv = objjobs.in_class_priv;
            con_m_jobs.dep_work = objjobs.dep_work;
   
            con_m_jobs.update_job_master_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_m_jobs.job_id = id;
            con_m_jobs.delete_from_job_master_def();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<master_jobs> Get(int id)
        {
            con_m_jobs.job_id = id;
            jobs = con_m_jobs.get_job_master_def_with_id();

            var convertedList = (from rw in jobs.Tables[0].AsEnumerable()
                                 select new master_jobs()
                                 {
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                     job_desc = Convert.ToString(rw["job_desc"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"])
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("job_id")]
        public List<master_jobs> Get(int id, string x)
        {
            con_m_jobs.job_id = id;
            jobs = con_m_jobs.get_emp_def_with_job_id();

            var convertedList = (from rw in jobs.Tables[0].AsEnumerable()
                                 select new master_jobs()
                                 {
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     emp_name = Convert.ToString(rw["emp_name"])
                                    
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("privs")]
        public List<job_details_def> Get(string privs)
        {
            dataset1 = con_m_det_jobs.get_privilige_def();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new job_details_def()
                                 {
                                     priv_id = Convert.ToInt32(rw["priv_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"])

                                 }).ToList();

            return convertedList;
        }
        public JsonResult Post(master_jobs objjobs)
        {
            con_m_jobs.job_id = objjobs.job_id;
            con_m_jobs.job_name = objjobs.job_name;
            con_m_jobs.job_desc = objjobs.job_desc;
            con_m_jobs.in_class_priv = objjobs.in_class_priv;
            con_m_jobs.dep_work = objjobs.dep_work;

            var job_id =con_m_jobs.save_in_job_master_def();
            return new JsonResult(job_id);
        }

    }
}