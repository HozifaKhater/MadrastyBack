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
    public class advertsService : IadvertsService
    {
        private readonly IDatabaseContext _db;

        public advertsService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_adverts()
        {
            var dalResponse = await _db.ExecuteQuery("get_adverts");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_adverts_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(adverts.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_adverts_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_adverts(adverts adverts)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_adverts", _db.CreateListOfSqlParams(adverts, "add", "ser"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_adverts(adverts adverts)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_in_adverts", _db.CreateListOfSqlParams(adverts, "update", "ser"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_adverts(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(adverts.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_adverts", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> update_adverts_state(int id, int state)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(adverts.ser), id.ToString());
            pars.Add("state", state.ToString());
            var dalResponse = await _db.ExecuteQuery("update_adverts_state", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_adverts_for_dashboard(int is_public, int dep_id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(adverts.is_public), is_public.ToString());
            pars.Add(nameof(adverts.dep_id), dep_id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_adverts_for_dashboard",pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
