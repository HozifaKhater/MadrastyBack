using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Icalling_parentsService
    {
        Task<ServiceResponse> get_calling_parents();
        Task<ServiceResponse> get_calling_parents_with_id(int id);
        Task<ServiceResponse> save_in_calling_parents(calling_parents calling_parents);
        Task<ServiceResponse> update_calling_parents(calling_parents calling_parents);
        Task<ServiceResponse> delete_from_calling_parents(int id);
    }
}
