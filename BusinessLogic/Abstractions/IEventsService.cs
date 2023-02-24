using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IEventsService
    {
        Task<ServiceResponse> delete_from_events(int id);
        Task<ServiceResponse> get_events();
        Task<ServiceResponse> get_events_with_id(int id);
        Task<ServiceResponse> save_in_events(Events events);
        Task<ServiceResponse> update_events(Events events);
    }
}
