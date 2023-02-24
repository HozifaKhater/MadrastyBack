using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IswotService
    {
        Task<ServiceResponse> get_swot();
        Task<ServiceResponse> get_swot_with_id(int id);
        Task<ServiceResponse> save_in_swot(swot swot);
        Task<ServiceResponse> update_swot(swot swot);
        Task<ServiceResponse> delete_from_swot(int id);
    }
}
