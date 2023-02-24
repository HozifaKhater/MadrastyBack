using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISpecialStudentServices
    {
        Task<ServiceResponse> SaveSpecialStudent(SpecialStudent student);
        Task<ServiceResponse> UpdateSpecialStudent(SpecialStudent student);
        Task<ServiceResponse> DeleteSpecialStudent(int id);
        Task<ServiceResponse> GetSpecialStudents();
        Task<ServiceResponse> GetSpecialStudentById(int id);
    }
}
