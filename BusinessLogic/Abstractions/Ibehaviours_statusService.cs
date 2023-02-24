using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Ibehaviours_statusService
    {
        Task<ServiceResponse> delete_from_behaviours_status(int id);
        Task<ServiceResponse> get_behaviours_status();
        Task<ServiceResponse> get_behaviours_status_with_id(int id);
        Task<ServiceResponse> save_in_behaviours_status(behaviours_status behaviours_status);
        Task<ServiceResponse> update_behaviours_status(behaviours_status behaviours_status);

        Task<ServiceResponse> delete_from_behaviours_status_details(int id);
        Task<ServiceResponse> get_behaviours_status_details();
        Task<ServiceResponse> get_behaviours_status_details_with_id(int id);
        Task<ServiceResponse> save_in_behaviours_status_details(behaviours_status_details behave);
        Task<ServiceResponse> update_behaviours_status_details(behaviours_status_details behave);

        Task<ServiceResponse> get_behaviours_status_details_with_student_id(int id);
        Task<ServiceResponse> get_behaviours_status_details_with_behaviour_status_id(int id);
    }
}
