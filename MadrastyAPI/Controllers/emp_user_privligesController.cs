using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class emp_user_privligesController : ControllerBase
    {
        emp_user_privliges con_emp_priv = new emp_user_privliges();

        public DataSet dataset1 { get; set; }
        [HttpPost]
        public JsonResult Post(emp_user_privliges objjobs)
        {
            con_emp_priv.emp_id = objjobs.emp_id;
            con_emp_priv.priv_name = objjobs.priv_name;
            con_emp_priv.page_name = objjobs.page_name;
            con_emp_priv.in_class_priv = objjobs.in_class_priv;
            con_emp_priv.dep_work = objjobs.dep_work;
            con_emp_priv.job_id = objjobs.job_id;

            con_emp_priv.save_in_emp_user_privliges();
            return new JsonResult("Added Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_emp_priv.emp_id = id;
            con_emp_priv.delete_from_emp_user_privliges();
            return new JsonResult("deleted Successfully");


        }
        [HttpDelete("emp_id")]
        public JsonResult Delete(string emp_id)
        {
            con_emp_priv.job_id = Convert.ToInt32(emp_id);
            con_emp_priv.delete_from_emp_user_privliges_one_priv();
            return new JsonResult("deleted Successfully");


        }
        [HttpGet]
        public List<emp_user_privliges> Get()
        {
            dataset1 = con_emp_priv.get_emp_user_privliges();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new emp_user_privliges()
                                 {
                                     user_id = Convert.ToInt32(rw["user_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"]),
                                     page_name = Convert.ToString(rw["page_name"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"]),
                                     job_id = Convert.ToInt32(rw["job_id"]),
                                     job_name = Convert.ToString(rw["job_name"]),
                                      emp_name = Convert.ToString(rw["emp_name"])
                                 }).ToList();

            return convertedList;
        }
        [HttpGet("emp_id")]
        public List<emp_user_privliges> Get(int id)
        {
            con_emp_priv.emp_id = id;
            dataset1 = con_emp_priv.get_emp_user_privliges_with_emp_id();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new emp_user_privliges()
                                 {
                                     user_id = Convert.ToInt32(rw["user_id"]),
                                     emp_id = Convert.ToInt32(rw["emp_id"]),
                                     priv_name = Convert.ToString(rw["priv_name"]),
                                     page_name = Convert.ToString(rw["page_name"]),
                                     in_class_priv = Convert.ToInt32(rw["in_class_priv"]),
                                     dep_work = Convert.ToInt32(rw["dep_work"]),
                                     job_id = Convert.ToInt32(rw["job_id"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet("get_priv_pages")]
        public List<emp_user_privliges> get_priv_pages(int id, int job_id)
        {
            con_emp_priv.emp_id = id;
            con_emp_priv.job_id = job_id;
            dataset1 = con_emp_priv.get_priv_pages();
            var convertedList = (from rw in dataset1.Tables[0].AsEnumerable()
                                 select new emp_user_privliges()
                                 {
                                     ser = Convert.ToInt32(rw["ser"]),                                   
                                     page_name = Convert.ToString(rw["page_name"]),
                                     priv_name = Convert.ToString(rw["priv_name"]),
                                     read = Convert.ToInt32(rw["read"]),
                                     read_and_write = Convert.ToInt32(rw["read_and_write"]),
                                     write = Convert.ToInt32(rw["write"])

                                 }).ToList();

            return convertedList;
        }
        [HttpPost("save_update_emp_user_privliges")]
        public JsonResult save_update_emp_user_privliges(emp_user_privliges objjobs)
        {
            con_emp_priv.emp_id = objjobs.emp_id;
            con_emp_priv.priv_name = objjobs.priv_name;
            con_emp_priv.page_name = objjobs.page_name;
            con_emp_priv.in_class_priv = objjobs.in_class_priv;
            con_emp_priv.dep_work = objjobs.dep_work;
            con_emp_priv.job_id = objjobs.job_id;
            con_emp_priv.read = objjobs.read;
            con_emp_priv.read_and_write = objjobs.read_and_write;
            con_emp_priv.write = objjobs.write;

            con_emp_priv.save_update_emp_user_privliges();
            return new JsonResult("Added Successfully");
        }
    }

}
