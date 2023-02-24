using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Iwork_planService
    {
        Task<ServiceResponse> get_work_plan();
        Task<ServiceResponse> get_work_plan_with_id(int id);
        Task<ServiceResponse> save_in_work_plan(work_plan work_plan);
        Task<ServiceResponse> update_work_plan(work_plan work_plan);
        Task<ServiceResponse> delete_from_work_plan(int id);
    }
}
