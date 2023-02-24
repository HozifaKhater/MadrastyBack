using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Isignalir_connectionsService
    {
        Task<ServiceResponse> get_signalir_connections();
        //Task<ServiceResponse> get_swot_with_id(int id);
        Task<ServiceResponse> save_in_signalir_connections(string connection);
      //  Task<ServiceResponse> update_swot(swot swot);
        Task<ServiceResponse> delete_from_signalir_connections(string connection);
    }
}
