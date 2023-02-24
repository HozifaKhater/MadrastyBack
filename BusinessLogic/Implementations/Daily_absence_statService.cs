using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data.SqlClient;
using  System.Data;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class Daily_absence_statService : IDaily_absence_statService
    {
        private readonly IDatabaseContext _db;
        public Daily_absence_statService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_daily_absence_stat()
        {
            var dalResponse = await _db.ExecuteQuery("get_daily_absence_stat");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_daily_absence_stat_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Daily_absence_stat.absence_stat_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_daily_absence_stat_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_daily_absence_stat(Daily_absence_stat dailystat)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(dailystat.lev_id), dailystat.lev_id.ToString());
            pars.Add(nameof(dailystat.lev_name), dailystat.lev_name);
            pars.Add(nameof(dailystat.tch3eb), dailystat.tch3eb);
            pars.Add(nameof(dailystat.total_num), dailystat.total_num.ToString());
            pars.Add(nameof(dailystat.attendance_num), dailystat.attendance_num.ToString());
            pars.Add(nameof(dailystat.absence_num), dailystat.absence_num.ToString());
            pars.Add(nameof(dailystat.stu_att_score), dailystat.stu_att_score.ToString());
            pars.Add(nameof(dailystat.teach_total_num), dailystat.teach_total_num.ToString());
            pars.Add(nameof(dailystat.teach_attend), dailystat.teach_attend.ToString());
            pars.Add(nameof(dailystat.teach_absence), dailystat.teach_absence.ToString());
            pars.Add(nameof(dailystat.teach_att_score), dailystat.teach_att_score.ToString());
            pars.Add(nameof(dailystat.tch3eb_id), dailystat.tch3eb_id.ToString());

            var dalResponse = await _db.ExecuteQuery("save_in_daily_absence_stat", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_daily_absence_stat(Daily_absence_stat dailystat)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(dailystat.absence_stat_id), dailystat.absence_stat_id.ToString());
            pars.Add(nameof(dailystat.lev_id), dailystat.lev_id.ToString());
            pars.Add(nameof(dailystat.lev_name), dailystat.lev_name);
            pars.Add(nameof(dailystat.tch3eb), dailystat.tch3eb);
            pars.Add(nameof(dailystat.total_num), dailystat.total_num.ToString());
            pars.Add(nameof(dailystat.attendance_num), dailystat.attendance_num.ToString());
            pars.Add(nameof(dailystat.absence_num), dailystat.absence_num.ToString());
            pars.Add(nameof(dailystat.stu_att_score), dailystat.stu_att_score.ToString());
            pars.Add(nameof(dailystat.teach_total_num), dailystat.teach_total_num.ToString());
            pars.Add(nameof(dailystat.teach_attend), dailystat.teach_attend.ToString());
            pars.Add(nameof(dailystat.teach_absence), dailystat.teach_absence.ToString());
            pars.Add(nameof(dailystat.teach_att_score), dailystat.teach_att_score.ToString());
            pars.Add(nameof(dailystat.tch3eb_id), dailystat.tch3eb_id.ToString());

            var dalResponse = await _db.ExecuteQuery("update_daily_absence_stat", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_daily_absence_stat(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Daily_absence_stat.absence_stat_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_daily_absence_stat", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
