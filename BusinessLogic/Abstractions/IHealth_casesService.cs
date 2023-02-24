using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IHealth_casesService
    {
        Task<ServiceResponse> delete_from_health_cases(int id);
        Task<ServiceResponse> delete_from_health_cases_details(int id);
        Task<ServiceResponse> delete_from_health_cases_details_with_health_id(int id);
        Task<ServiceResponse> get_health_cases();
        Task<ServiceResponse> get_health_cases_details();
        Task<ServiceResponse> get_health_cases_details_with_health_id(int id);
        Task<ServiceResponse> get_health_cases_details_with_id(int id);
        Task<ServiceResponse> get_health_cases_with_id(int id);
        Task<ServiceResponse> save_in_health_cases(Health_cases health_cases);
        Task<ServiceResponse> save_in_health_cases_details(health_cases_details health_cases);
        Task<ServiceResponse> update_health_cases(Health_cases health_cases);
        Task<ServiceResponse> update_health_cases_details(health_cases_details health_cases);
    }
}
