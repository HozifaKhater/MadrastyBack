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
    public class Supervisor_opinionService : ISupervisor_opinionService
    {
        private readonly IDatabaseContext _db;
        public Supervisor_opinionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_supervisor_opinion()
        {
            var dalResponse = await _db.ExecuteQuery("get_supervisor_opinion");
            return new ServiceResponse(dalResponse); 
        }
        public async Task<ServiceResponse> get_supervisor_opinion_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Supervisor_opinion.supervisor_opin_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_supervisor_opinion_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_supervisor_opinion(Supervisor_opinion supervisoropin)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(supervisoropin.lev_id), supervisoropin.lev_id.ToString());
            pars.Add(nameof(supervisoropin.lev_name), supervisoropin.lev_name);
            pars.Add(nameof(supervisoropin.class_id), supervisoropin.class_id.ToString());
            pars.Add(nameof(supervisoropin.class_name), supervisoropin.class_name);
            pars.Add(nameof(supervisoropin.dep_id), supervisoropin.dep_id.ToString());
            pars.Add(nameof(supervisoropin.dep_name), supervisoropin.dep_name);
            pars.Add(nameof(supervisoropin.student_id), supervisoropin.student_id.ToString());
            pars.Add(nameof(supervisoropin.student_name), supervisoropin.student_name);
            pars.Add(nameof(supervisoropin.super_opin_date), supervisoropin.super_opin_date);
            pars.Add(nameof(supervisoropin.behave_stat_rep), supervisoropin.behave_stat_rep);
            pars.Add(nameof(supervisoropin.dep_mang_opin), supervisoropin.dep_mang_opin);
            pars.Add(nameof(supervisoropin.supervisor_opin), supervisoropin.supervisor_opin);

            var dalResponse = await _db.ExecuteQuery("save_in_supervisor_opinion", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_supervisor_opinion(Supervisor_opinion supervisoropin)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(supervisoropin.supervisor_opin_id), supervisoropin.supervisor_opin_id.ToString());
            pars.Add(nameof(supervisoropin.lev_id), supervisoropin.lev_id.ToString());
            pars.Add(nameof(supervisoropin.lev_name), supervisoropin.lev_name);
            pars.Add(nameof(supervisoropin.class_id), supervisoropin.class_id.ToString());
            pars.Add(nameof(supervisoropin.class_name), supervisoropin.class_name);
            pars.Add(nameof(supervisoropin.dep_id), supervisoropin.dep_id.ToString());
            pars.Add(nameof(supervisoropin.dep_name), supervisoropin.dep_name);
            pars.Add(nameof(supervisoropin.student_id), supervisoropin.student_id.ToString());
            pars.Add(nameof(supervisoropin.student_name), supervisoropin.student_name);
            pars.Add(nameof(supervisoropin.super_opin_date), supervisoropin.super_opin_date);
            pars.Add(nameof(supervisoropin.behave_stat_rep), supervisoropin.behave_stat_rep);
            pars.Add(nameof(supervisoropin.dep_mang_opin), supervisoropin.dep_mang_opin);
            pars.Add(nameof(supervisoropin.supervisor_opin), supervisoropin.supervisor_opin);

            var dalResponse = await _db.ExecuteQuery("update_supervisor_opinion", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_supervisor_opinion(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Supervisor_opinion.supervisor_opin_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_supervisor_opinion", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
