using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface I7sa_defService
    {
        Task<ServiceResponse> get_7sa_def();
        Task<ServiceResponse> get_7sa_def_with_id(int id);
        Task<ServiceResponse> save_in_7sa_def(_7sa_def _7sa_def);
        Task<ServiceResponse> update_7sa_def(_7sa_def _7sa_def);
        Task<ServiceResponse> delete_from_7sa_def(int id);
    }
}
