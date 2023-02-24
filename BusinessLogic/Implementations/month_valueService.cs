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
    public class month_valueService : Imonth_valueService
    {
        private readonly IDatabaseContext _db;

        public month_valueService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_month_value()
        {
            var dalResponse = await _db.ExecuteQuery("get_month_value");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_month_value_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(month_value.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_month_value_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_month_value(month_value month_value)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_month_value", _db.CreateListOfSqlParams(month_value, "add", "ser"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_month_value(month_value month_value)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_in_month_value", _db.CreateListOfSqlParams(month_value, "update", "ser"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_month_value(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(month_value.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_month_value", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> update_month_value_state(int id, int state)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(adverts.ser), id.ToString());
            pars.Add("state", state.ToString());
            var dalResponse = await _db.ExecuteQuery("update_month_value_state", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_month_value_for_dashboard()
        {
            var dalResponse = await _db.ExecuteQuery("get_month_value_for_dashboard");
            return new ServiceResponse(dalResponse);
        }

    }
}
