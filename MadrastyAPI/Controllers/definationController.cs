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
    public class definationController : ControllerBase
    {
        CLS_connection con_abs = new CLS_connection();

        definition Definition = new definition();

        public DataSet dataset { get; set; }

        [HttpGet("scode")]
        public List<definition> Get(string scode)
        {
            con_abs.scode = scode;
            dataset = con_abs.get_defination_with_scode();

            var convertedList = (from rw in dataset.Tables[0].AsEnumerable()
                                 select new definition()
                                 {
                                     def_id = Convert.ToInt32(rw["def_id"]),
                                     def_name = Convert.ToString(rw["def_name"]),
                                     s_code = Convert.ToString(rw["s_code"]),
                                     s_code_arabic = Convert.ToString(rw["s_code_arabic"])

                                 }).ToList();

            return convertedList;
        }


        [HttpPost]
        public JsonResult Post(definition definition)
        {
            Definition.def_name = definition.def_name;
            Definition.s_code = definition.s_code;
            Definition.s_code_arabic = definition.s_code_arabic;

            Definition.save_in_definition();

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult updateDefinition(definition definition)
        {
            Definition.def_id = definition.def_id;
            Definition.def_name = definition.def_name;
            Definition.s_code = definition.s_code;
            Definition.s_code_arabic = definition.s_code_arabic;

            Definition.update_definition();

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Definition.def_id = id;

            Definition.delete_definition();

            return new JsonResult("deleted Successfully");
        }


        [HttpGet]
        public List<definition> GetDefinitions()
        {
            dataset = Definition.getDefinitions();

            var definitionsList = (from row in dataset.Tables[0].AsEnumerable()
                                   select new definition()
                                   {
                                       def_id = Convert.ToInt32(row["def_id"]),
                                       def_name = Convert.ToString(row["def_name"]),
                                       s_code = Convert.ToString(row["s_code"]),
                                       s_code_arabic = Convert.ToString(row["s_code_arabic"])

                                   }).ToList();

            return definitionsList;
        }


        [HttpGet("sCodeArabic")]
        public List<definition> GetDistinctScodes()
        {
            dataset = Definition.getDistinctScodes();

            var definitionsList = (from row in dataset.Tables[0].AsEnumerable()
                                   select new definition()
                                   {
                                       s_code = Convert.ToString(row["s_code"]),
                                       s_code_arabic = Convert.ToString(row["s_code_arabic"])

                                   }).ToList();

            return definitionsList;
        }



        [HttpGet("id")]
        public List<definition> Get(int id)
        {
            Definition.def_id = id;

            dataset = Definition.getDefinitionsWithID(id);

            var definitionList = (from row in dataset.Tables[0].AsEnumerable()
                                  select new definition()
                                  {
                                      def_id = Convert.ToInt32(row["def_id"]),
                                      def_name = Convert.ToString(row["def_name"]),
                                      s_code = Convert.ToString(row["s_code"]),
                                      s_code_arabic = Convert.ToString(row["s_code_arabic"])

                                  }).ToList();

            return definitionList;
        }
    }

}