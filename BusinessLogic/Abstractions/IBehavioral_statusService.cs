using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBehavioral_statusService
    {
        Task<ServiceResponse> delete_from_behavioral_status(int id);
        Task<ServiceResponse> get_behavioral_status();
        Task<ServiceResponse> get_behavioral_status_with_id(int id);
        Task<ServiceResponse> save_in_behavioral_status(Behavioral_status behave);
        Task<ServiceResponse> update_behavioral_status(Behavioral_status behave);
    }
}
