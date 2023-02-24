using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class work_planService : Iwork_planService
    {
        private readonly IDatabaseContext _db;

        public work_planService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_work_plan()
        {
            var dalResponse = await _db.ExecuteQuery("get_work_plan");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_work_plan_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(work_plan.work_plan_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_work_plan_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_work_plan(work_plan work_plan)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_work_plan", _db.CreateListOfSqlParams(work_plan, "add", "ser"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_work_plan(work_plan work_plan)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_in_work_plan", _db.CreateListOfSqlParams(work_plan, "update", "ser"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_work_plan(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(work_plan.work_plan_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_work_plan", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
