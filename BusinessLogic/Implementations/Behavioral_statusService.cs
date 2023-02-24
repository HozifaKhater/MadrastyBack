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
    public class Behavioral_statusService : IBehavioral_statusService
    {
        private readonly IDatabaseContext _db;
        public Behavioral_statusService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_behavioral_status()
        {
            var dalResponse = await _db.ExecuteQuery("get_behavioral_status");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_behavioral_status_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Behavioral_status.behave_stat_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_behavioral_status_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_behavioral_status(Behavioral_status behave)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(behave.lev_id), behave.lev_id.ToString());
            pars.Add(nameof(behave.lev_name), behave.lev_name);
            pars.Add(nameof(behave.class_id), behave.class_id.ToString());
            pars.Add(nameof(behave.class_name), behave.class_name);
            pars.Add(nameof(behave.student_id), behave.student_id.ToString());
            pars.Add(nameof(behave.student_name), behave.student_name);
            pars.Add(nameof(behave.behave_date), behave.behave_date);
            pars.Add(nameof(behave.behave_stat_rep), behave.behave_stat_rep);

            var dalResponse = await _db.ExecuteQuery("save_in_behavioral_status", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_behavioral_status(Behavioral_status behave)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(behave.behave_stat_id), behave.behave_stat_id.ToString());
            pars.Add(nameof(behave.lev_id), behave.lev_id.ToString());
            pars.Add(nameof(behave.lev_name), behave.lev_name);
            pars.Add(nameof(behave.class_id), behave.class_id.ToString());
            pars.Add(nameof(behave.class_name), behave.class_name);
            pars.Add(nameof(behave.student_id), behave.student_id.ToString());
            pars.Add(nameof(behave.student_name), behave.student_name);
            pars.Add(nameof(behave.behave_date), behave.behave_date);
            pars.Add(nameof(behave.behave_stat_rep), behave.behave_stat_rep);

            var dalResponse = await _db.ExecuteQuery("update_behavioral_status", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_behavioral_status(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Behavioral_status.behave_stat_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_behavioral_status", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
