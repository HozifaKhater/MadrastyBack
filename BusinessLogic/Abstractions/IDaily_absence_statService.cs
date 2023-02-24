using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IDaily_absence_statService
    {
        Task<ServiceResponse> delete_from_daily_absence_stat(int id);
        Task<ServiceResponse> get_daily_absence_stat();
        Task<ServiceResponse> get_daily_absence_stat_with_id(int id);
        Task<ServiceResponse> save_in_daily_absence_stat(Daily_absence_stat dailystat);
        Task<ServiceResponse> update_daily_absence_stat(Daily_absence_stat dailystat);
    }
}
