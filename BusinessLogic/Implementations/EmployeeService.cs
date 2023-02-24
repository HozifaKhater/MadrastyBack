using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDatabaseContext _db;
        public EmployeeService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveEmployee(employee employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_emp_def",
                _db.CreateListOfSqlParams(employee, "add", "emp_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateEmployee(employee employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_emp_def",
                _db.CreateListOfSqlParams(employee, "add", "emp_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteEmployee(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employee.emp_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_emp_def", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetEmployeeById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employee.emp_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_emp_def_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetEmployees()
        {
            var dalResponse = await _db.ExecuteQuery("get_emp_def");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetEmployeeByDeptId(int dept_id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employee.dep_id), dept_id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_emp_def_with_dep_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetGoodStudents()
        {
            var dalResponse = await _db.ExecuteQuery("get_good_students");

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetNumberOfStudent()
        {
            var dalResponse = await _db.ExecuteQuery("get_all_students");

            return new ServiceResponse(dalResponse);
        }


    }
}
