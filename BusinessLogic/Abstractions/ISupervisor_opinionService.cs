using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISupervisor_opinionService
    {
        Task<ServiceResponse> delete_from_supervisor_opinion(int id);
        Task<ServiceResponse> get_supervisor_opinion();
        Task<ServiceResponse> get_supervisor_opinion_with_id(int id);
        Task<ServiceResponse> save_in_supervisor_opinion(Supervisor_opinion supervisoropin);
        Task<ServiceResponse> update_supervisor_opinion(Supervisor_opinion supervisoropin);
    }
}
