using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISonsOfMartyrsServices
    {
        Task<ServiceResponse> SaveSonOfMartyrs(SonOfMartyrs student);
        Task<ServiceResponse> UpdateSonOfMartyrs(SonOfMartyrs student);
        Task<ServiceResponse> DeleteSonOfMartyrs(int id);
        Task<ServiceResponse> GetSonsOfMartyrs();
        Task<ServiceResponse> GetSonOfMartyrsById(int id);

    }
}
