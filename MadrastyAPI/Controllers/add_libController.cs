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
    public class add_libController : ControllerBase
    {
        add_lib con_add_lib = new add_lib();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<add_lib> Get(int id)
        {
            con_add_lib.lib_id = id;
            dataset = con_add_lib.get_add_lib_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new add_lib()
                                 {
                                     lib_id = Convert.ToInt32(rw["lib_id"]),
                                     lib_book = Convert.ToInt32(rw["lib_book"]),
                                     lib_ref = Convert.ToInt32(rw["lib_ref"]),
                                     lib_book_name = Convert.ToString(rw["lib_book_name"]),
                                     lib_author_name = Convert.ToString(rw["lib_author_name"]),
                                     lib_date = Convert.ToString(rw["lib_date"]),
                                     lib_page_no = Convert.ToInt32(rw["lib_page_no"]),
                                     lib_rec_no = Convert.ToInt32(rw["lib_rec_no"]),
                                     lib_classification = Convert.ToString(rw["lib_classification"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<add_lib> Get()
        {
            dataset = con_add_lib.get_add_lib();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new add_lib()
                                 {
                                     lib_id = Convert.ToInt32(rw["lib_id"]),
                                     lib_book = Convert.ToInt32(rw["lib_book"]),
                                     lib_ref = Convert.ToInt32(rw["lib_ref"]),
                                     lib_book_name = Convert.ToString(rw["lib_book_name"]),
                                     lib_author_name = Convert.ToString(rw["lib_author_name"]),
                                     lib_date = Convert.ToString(rw["lib_date"]),
                                     lib_page_no = Convert.ToInt32(rw["lib_page_no"]),
                                     lib_rec_no = Convert.ToInt32(rw["lib_rec_no"]),
                                     lib_classification = Convert.ToString(rw["lib_classification"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(add_lib objadd_lib)
        {
            con_add_lib.lib_book = objadd_lib.lib_book;
            con_add_lib.lib_ref = objadd_lib.lib_ref;
            con_add_lib.lib_book_name = objadd_lib.lib_book_name;
            con_add_lib.lib_author_name = objadd_lib.lib_author_name;
            con_add_lib.lib_date = objadd_lib.lib_date;
            con_add_lib.lib_page_no = objadd_lib.lib_page_no;
            con_add_lib.lib_rec_no = objadd_lib.lib_rec_no;
            con_add_lib.lib_classification = objadd_lib.lib_classification;

            con_add_lib.save_in_add_lib();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(add_lib objadd_lib)
        {
            con_add_lib.lib_id = objadd_lib.lib_id;
            con_add_lib.lib_book = objadd_lib.lib_book;
            con_add_lib.lib_ref = objadd_lib.lib_ref;
            con_add_lib.lib_book_name = objadd_lib.lib_book_name;
            con_add_lib.lib_author_name = objadd_lib.lib_author_name;
            con_add_lib.lib_date = objadd_lib.lib_date;
            con_add_lib.lib_page_no = objadd_lib.lib_page_no;
            con_add_lib.lib_rec_no = objadd_lib.lib_rec_no;
            con_add_lib.lib_classification = objadd_lib.lib_classification;

            con_add_lib.update_add_lib();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_add_lib.lib_id = id;
            con_add_lib.delete_from_add_lib();
            return new JsonResult("deleted Successfully");


        }
    }
}