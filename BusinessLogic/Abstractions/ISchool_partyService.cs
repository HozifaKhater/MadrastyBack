using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISchool_partyService
    {
        Task<ServiceResponse> delete_from_school_party(int id);
        Task<ServiceResponse> get_school_party();
        Task<ServiceResponse> get_school_party_with_id(int id);
        Task<ServiceResponse> save_in_school_party(School_party school_party);
        Task<ServiceResponse> update_school_party(School_party school_party);
    }
}
