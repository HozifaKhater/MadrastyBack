using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISchoolServices
    {
        Task<ServiceResponse> SaveSchool(School school);
        Task<ServiceResponse> UpdateSchool(School school);
        Task<ServiceResponse> DeleteSchool(int id);
        Task<ServiceResponse> GetAllSchools();
        Task<ServiceResponse> GetSchoolById(int id);
    }
}
