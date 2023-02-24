using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITa7dierService
    {
        Task<ServiceResponse> SaveTa7dier(ta7dier_master ta7dier);
        Task<ServiceResponse> UpdateTa7dier(ta7dier_master ta7dier);
        Task<ServiceResponse> DeleteTa7dier(int id);
        Task<ServiceResponse> GetTa7diers();
        Task<ServiceResponse> GetTa7dierById(int id);
        Task<ServiceResponse> GetTa7dierBySubjectId(int subject_id);
    }
}
