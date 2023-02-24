using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IEmployeeService
    {
        Task<ServiceResponse> SaveEmployee(employee employee);
        Task<ServiceResponse> UpdateEmployee(employee employee);
        Task<ServiceResponse> DeleteEmployee(int id);
        Task<ServiceResponse> GetEmployees();
        Task<ServiceResponse> GetEmployeeById(int id);
        Task<ServiceResponse> GetEmployeeByDeptId(int deptId);
        Task<ServiceResponse> GetGoodStudents();
        Task<ServiceResponse> GetNumberOfStudent();
    }
}
