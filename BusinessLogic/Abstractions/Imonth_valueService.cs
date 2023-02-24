using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Imonth_valueService
    {
        Task<ServiceResponse> get_month_value();
        Task<ServiceResponse> get_month_value_with_id(int id);
        Task<ServiceResponse> save_in_month_value(month_value month_value);
        Task<ServiceResponse> update_month_value(month_value month_value);
        Task<ServiceResponse> delete_from_month_value(int id);
        Task<ServiceResponse> update_month_value_state(int id, int state);
        Task<ServiceResponse> get_month_value_for_dashboard();
    }
}
