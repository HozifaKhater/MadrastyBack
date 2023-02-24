using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IenzratService
    {
        Task<ServiceResponse> get_enzrat();
        Task<ServiceResponse> get_enzrat_with_id(int id);
        Task<ServiceResponse> save_in_enzrat(enzrat enzrat);
        Task<ServiceResponse> update_enzrat(enzrat enzrat);
        Task<ServiceResponse> delete_from_enzrat(int id);
       
    }
}
