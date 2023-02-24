using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json.Linq;
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
    public class financial__fund_expensesController : ControllerBase
    {
        financial__fund_expenses con_sub = new financial__fund_expenses();
        public DataSet subject { get; set; }
        [HttpGet("id")]
        public List<financial__fund_expenses> Get(int id)
        {
            con_sub.id = id;
            subject = con_sub.get_financial__fund_expenses_with_id();

            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new financial__fund_expenses()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     date = Convert.ToString(rw["date"]),
                                     price = Convert.ToDouble(rw["price"]),
                                     notes = Convert.ToString(rw["notes"])

                                 }).ToList();

            return convertedList;
        }
        [HttpGet]
        public List<financial__fund_expenses> Get()
        {
            subject = con_sub.get_financial__fund_expenses();
            var convertedList = (from rw in subject.Tables[0].AsEnumerable()
                                 select new financial__fund_expenses()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     type_name = Convert.ToString(rw["type_name"]),
                                     date = Convert.ToString(rw["date"]),
                                     price = Convert.ToDouble(rw["price"]),
                                     notes = Convert.ToString(rw["notes"])

                                 }).ToList();

            return convertedList;

        }
        [HttpPost]
        public JsonResult Post(financial__fund_expenses objsubject)
        {
            // con_sub.subject_id = objsubject.subject_id;
            con_sub.type_name = objsubject.type_name;
            con_sub.date = objsubject.date;
            con_sub.price = objsubject.price;
            con_sub.notes = objsubject.notes;


            con_sub.save_in_financial__fund_expenses();
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        public JsonResult Put(financial__fund_expenses objsubject)
        {
            con_sub.id = objsubject.id;
            con_sub.type_name = objsubject.type_name;
            con_sub.date = objsubject.date;
            con_sub.price = objsubject.price;
            con_sub.notes = objsubject.notes;


            con_sub.update_financial__fund_expenses();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_sub.id = id;
            con_sub.delete_from_financial__fund_expenses();
            return new JsonResult("deleted Successfully");


        }
    }
}