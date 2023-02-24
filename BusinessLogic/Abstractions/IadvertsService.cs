using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IadvertsService
    {
        Task<ServiceResponse> get_adverts();
        Task<ServiceResponse> get_adverts_with_id(int id);
        Task<ServiceResponse> save_in_adverts(adverts adverts);
        Task<ServiceResponse> update_adverts(adverts adverts);
        Task<ServiceResponse> delete_from_adverts(int id);
        Task<ServiceResponse> update_adverts_state(int id, int state);
        Task<ServiceResponse> get_adverts_for_dashboard(int is_public, int dep_id);
    }
}
