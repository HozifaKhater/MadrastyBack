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
    public class departmentController : ControllerBase
    {
        department con_dep = new department();
        depart con_dep1 = new depart();
        public DataSet department { get; set; }
    public departmentController()
        {
        }

        public DataSet get_department_def
        {
            get { return con_dep.get_department_def(); }
           
        }
        public DataSet get_department_def_with_id
        {
            get { return con_dep.get_department_def_with_id(); }

        }
        [HttpGet]
        public List<depart> Get()
        {

            var convertedList = (from rw in get_department_def.Tables[0].AsEnumerable()
                                 select new depart()
                                 {
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_desc = Convert.ToString(rw["dep_desc"]),
                                     dep_supervisor_name = Convert.ToString(rw["dep_supervisor_name"]),
                                     dep_supervisor_id = Convert.ToInt32(rw["dep_supervisor_id"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }
                                 ).ToList();

            return convertedList;

        }
        [HttpGet("get_department_def_with_master_id")]
        public List<depart> get_department_def_with_master_id(int id)
        {
            con_dep.dep_id = id;
            department = con_dep.get_department_def_with_master_id();
            var convertedList = (from rw in department.Tables[0].AsEnumerable()
                                 select new depart()
                                 {
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_desc = Convert.ToString(rw["dep_desc"]),
                                     dep_supervisor_name = Convert.ToString(rw["dep_supervisor_name"]),
                                     dep_supervisor_id = Convert.ToInt32(rw["dep_supervisor_id"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }
                                 ).ToList();

            return convertedList;

        }
        [HttpGet("master")]
        public List<depart> GetMaster()
        {
            department = con_dep.get_master_departments();
            var convertedList = (from rw in department.Tables[0].AsEnumerable()
                                 select new depart()
                                 {
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_desc = Convert.ToString(rw["dep_desc"]),
                                     dep_supervisor_name = Convert.ToString(rw["dep_supervisor_name"]),
                                     dep_supervisor_id = Convert.ToInt32(rw["dep_supervisor_id"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;

        }
        [HttpGet("side")]
        public List<depart> Get(string master, string side)
        {
            department = con_dep.get_side_departments();
            var convertedList = (from rw in department.Tables[0].AsEnumerable()
                                 select new depart()
                                 {
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_desc = Convert.ToString(rw["dep_desc"]),
                                     dep_supervisor_name = Convert.ToString(rw["dep_supervisor_name"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;

        }
        [HttpGet("id")]
        public List<depart> Get(int id)
        {
            con_dep.dep_id = id;
            department = con_dep.get_department_def_with_id();

            var convertedList = (from rw in get_department_def_with_id.Tables[0].AsEnumerable()
                                 select new depart()
                                 {
                                     dep_id = Convert.ToInt32(rw["dep_id"]),
                                     dep_name = Convert.ToString(rw["dep_name"]),
                                     dep_desc = Convert.ToString(rw["dep_desc"]),
                                     dep_supervisor_name = Convert.ToString(rw["dep_supervisor_name"]),
                                     dep_supervisor_id = Convert.ToInt32(rw["dep_supervisor_id"]),
                                     parent_id = Convert.ToInt32(rw["parent_id"])
                                 }).ToList();

            return convertedList;
        }
        // JArray LineItem_array = new JArray();
        // DataTable test1 = get_department_def.Tables[0];


        //var arrray = get_department_def.Tables[0].Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToList();
        // //var empList = get_department_def.Tables[0].AsEnumerable().Select(dataRow => new Employee{ Name = dataRow.Field<string>("Name")}).ToList();
        // //List<department> listdepartment = get_department_def.Tables[0].AsEnumerable().ToList();
        // List<depart> listdepartment1 = new List<depart>();
        // for (int i = 0; i < arrray.Count; i += 1)
        // {

        //     con_dep1.dep_id = int.Parse(get_department_def.Tables[0].Rows[i]["dep_id"].ToString());
        //     con_dep1.dep_name = (string)get_department_def.Tables[0].Rows[i]["dep_name"];
        //     listdepartment1.Add(con_dep1);

        //     //JArray result = JArray.FromObject(listdepartment1);
        //     //test1 = listdepartment1
        //     // LineItem_array.Add((JObject.FromObject(con_dep1)));
        //     //test1 = listdepartment1.ToArray();
        //     //
        //     //test1.Append(con_dep);
        // }


        //test1 = con_dep.listdepartment.ToArray();

        [HttpPost]
        public JsonResult Post(department objdepartment)
        {
            con_dep.dep_name = objdepartment.dep_name;
            con_dep.dep_desc = objdepartment.dep_desc;
            con_dep.dep_supervisor_id = objdepartment.dep_supervisor_id;
            con_dep.dep_supervisor_name = objdepartment.dep_supervisor_name;
            con_dep.parent_id = objdepartment.parent_id;
            con_dep.save_in_department_def();
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(department objdepartment)
        {
            con_dep.dep_id = objdepartment.dep_id;
            con_dep.dep_name = objdepartment.dep_name;
            con_dep.dep_desc = objdepartment.dep_desc;
            con_dep.dep_supervisor_id = objdepartment.dep_supervisor_id;
            con_dep.dep_supervisor_name = objdepartment.dep_supervisor_name;
            con_dep.parent_id = objdepartment.parent_id;
            con_dep.update_department_def();
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            con_dep.dep_id = id;
            con_dep.delete_from_department_def();
            return new JsonResult("deleted Successfully");

            
        }
    }
}
