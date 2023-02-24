using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IRestToRedoService
    {
        Task<ServiceResponse> SaveRestToRedo(rest_to_redo student);
        Task<ServiceResponse> UpdateRestToRedo(rest_to_redo student);
        Task<ServiceResponse> DeleteRestToRedo(int id);
        Task<ServiceResponse> GetRestToRedo();
        Task<ServiceResponse> GetRestToRedoById(int id);

    }
}
