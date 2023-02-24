using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IViolation_recordService
    {
        Task<ServiceResponse> delete_from_violation_record(int id);
        Task<ServiceResponse> get_violation_record();
        Task<ServiceResponse> get_violation_record_with_id(int id);
        Task<ServiceResponse> save_in_violation_record(violation_record viol);
        Task<ServiceResponse> update_violation_record(violation_record viol);
    }
}
