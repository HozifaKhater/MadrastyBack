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
    public class borrow_bookController : ControllerBase
    {
        borrow_book con_borr_book = new borrow_book();
        public DataSet dataset { get; set; }

        [HttpGet("id")]
        public List<borrow_book> Get(int id)
        {
            con_borr_book.borr_id = id;
            dataset = con_borr_book.get_borrow_book_with_id();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new borrow_book()
                                 {
                                     borr_id = Convert.ToInt32(rw["borr_id"]),
                                     borr_date = Convert.ToString(rw["borr_date"]),
                                     lib_book_name = Convert.ToString(rw["lib_book_name"]),
                                     borr_name = Convert.ToString(rw["borr_name"])


                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<borrow_book> Get()
        {
            dataset = con_borr_book.get_borrow_book();
            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new borrow_book()
                                 {
                                     borr_id = Convert.ToInt32(rw["borr_id"]),
                                     borr_date = Convert.ToString(rw["borr_date"]),
                                     lib_book_name = Convert.ToString(rw["lib_book_name"]),
                                     borr_name = Convert.ToString(rw["borr_name"])


                                 }).ToList();

            return convertedList;

        }

        [HttpPost]
        public JsonResult Post(borrow_book objborrow_book)
        {
            con_borr_book.borr_date = objborrow_book.borr_date;
            con_borr_book.lib_book_name = objborrow_book.lib_book_name;
            con_borr_book.borr_name = objborrow_book.borr_name;


            con_borr_book.save_in_borrow_book();
            return new JsonResult("Added Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_borr_book.borr_id = id;
            con_borr_book.delete_from_borrow_book();
            return new JsonResult("deleted Successfully");


        }

    }
}