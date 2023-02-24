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
    public class nchraController : ControllerBase
    {

        nchra con_nchra = new nchra();

        job_details_def con_m_det_jobs = new job_details_def();
        public DataSet dataset1 { get; set; }
   
        [HttpGet]
        public List<nchra> Get()
        {
            dataset1= con_nchra.get_nchra();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new nchra()
                                 {
                                     nchra_id = Convert.ToInt32(rw["nchra_id"]),
                                     nchra_date = Convert.ToString(rw["nchra_date"]),
                                     nchra_sender = Convert.ToString(rw["nchra_sender"]),
                                     nchra_topic = Convert.ToString(rw["nchra_topic"]),
                                     nchra_text = Convert.ToString(rw["nchra_text"]),
                                     nchra_pages_num = Convert.ToInt32(rw["nchra_pages_num"]),
                                     nchra_attach = Convert.ToString(rw["nchra_attach"]),
                                     nachra_file_type = Convert.ToString(rw["nachra_file_type"]),
                                     is_file = Convert.ToInt32(rw["is_file"]),
                                     is_dep = Convert.ToInt32(rw["is_dep"])
                                 }).ToList();

            return convertedList;
        }
        [HttpPut]
        public JsonResult Put(nchra objjobs)
        {
            con_nchra.nchra_id = objjobs.nchra_id;
            con_nchra.nchra_date = objjobs.nchra_date;
            con_nchra.nchra_sender = objjobs.nchra_sender;
            con_nchra.nchra_topic = objjobs.nchra_topic;
            con_nchra.nchra_text = objjobs.nchra_text;
            con_nchra.nchra_pages_num = objjobs.nchra_pages_num;
            con_nchra.nchra_attach = objjobs.nchra_attach;
            con_nchra.nachra_file_type = objjobs.nachra_file_type;
            con_nchra.is_file = objjobs.is_file;
            con_nchra.is_dep = objjobs.is_dep;

            con_nchra.update_nchra();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_nchra.nchra_id = id;
            con_nchra.delete_from_nchra();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet("id")]
        public List<nchra> Get(int id)
        {
            con_nchra.nchra_id = id;
            dataset1 = con_nchra.get_nchra_with_id();

            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new nchra()
                                 {
                                     nchra_id = Convert.ToInt32(rw["nchra_id"]),
                                     nchra_date = Convert.ToString(rw["nchra_date"]),
                                     nchra_sender = Convert.ToString(rw["nchra_sender"]),
                                     nchra_topic = Convert.ToString(rw["nchra_topic"]),
                                     nchra_text = Convert.ToString(rw["nchra_text"]),
                                     nchra_pages_num = Convert.ToInt32(rw["nchra_pages_num"]),
                                     nchra_attach = Convert.ToString(rw["nchra_attach"]),
                                     nachra_file_type = Convert.ToString(rw["nachra_file_type"]),
                                     is_file = Convert.ToInt32(rw["is_file"]),
                                     is_dep = Convert.ToInt32(rw["is_dep"])
                                 }).ToList();

            return convertedList;
        }
        [HttpPost]
        public JsonResult Post(nchra objjobs)
        {
            
            con_nchra.nchra_date = objjobs.nchra_date;
            con_nchra.nchra_sender = objjobs.nchra_sender;
            con_nchra.nchra_topic = objjobs.nchra_topic;
            con_nchra.nchra_text = objjobs.nchra_text;
            con_nchra.nchra_pages_num = objjobs.nchra_pages_num;
            con_nchra.nchra_attach = objjobs.nchra_attach;
            con_nchra.nachra_file_type = objjobs.nachra_file_type;
            con_nchra.is_file = objjobs.is_file;
            con_nchra.is_dep = objjobs.is_dep;

            var job_id = con_nchra.save_in_nchra();
            return new JsonResult(job_id);
        }
        //public List<master_jobs> Get(int id, string x)
        //{
        //    con_m_jobs.job_id = id;
        //    jobs = con_m_jobs.get_emp_def_with_job_id();

        //    var convertedList = (from rw in jobs.Tables[0].AsEnumerable()
        //                         select new master_jobs()
        //                         {
        //                             emp_id = Convert.ToInt32(rw["emp_id"]),
        //                             emp_name = Convert.ToString(rw["emp_name"])

        //                         }).ToList();

        //    return convertedList;
        //}
        //[HttpGet("privs")]
        //public List<job_details_def> Get(string privs)
        //{
        //    dataset1 = con_m_det_jobs.get_privilige_def();
        //    var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
        //                         select new job_details_def()
        //                         {
        //                             priv_id = Convert.ToInt32(rw["priv_id"]),
        //                             priv_name = Convert.ToString(rw["priv_name"])

        //                         }).ToList();

        //    return convertedList;
        //}


    }
}