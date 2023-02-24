using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Imeeting_typeService
    {
        Task<ServiceResponse> get_meeting_type();
        Task<ServiceResponse> get_meeting_type_with_id(int id);
        Task<ServiceResponse> save_in_meeting_type(meeting_type meeting_type);
        Task<ServiceResponse> update_meeting_type(meeting_type meeting_type);
        Task<ServiceResponse> delete_from_meeting_type(int id);
    }
}
