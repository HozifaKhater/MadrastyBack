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
    public class behaviours_statusService : Ibehaviours_statusService
    {
        private readonly IDatabaseContext _db;

        public behaviours_statusService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_behaviours_status()
        {
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_behaviours_status_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_behaviours_status(behaviours_status behaviours_status)
        {

            var dalResponse = await _db.ExecuteNonQuery("save_in_behaviours_status", _db.CreateListOfSqlParams(behaviours_status, "add", "id"));

            return new ServiceResponse(dalResponse);

        }
        public async Task<ServiceResponse> update_behaviours_status(behaviours_status behaviours_status)
        {

            var dalResponse = await _db.ExecuteNonQuery("update_behaviours_status", _db.CreateListOfSqlParams(behaviours_status, "update", "id"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_behaviours_status(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_behaviours_status", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_behaviours_status_details()
        {
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status_details");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_behaviours_status_details_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status_details.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status_details_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_behaviours_status_details(behaviours_status_details behaviours_status_details)
        {

            var dalResponse = await _db.ExecuteNonQuery("save_in_behaviours_status_details", _db.CreateListOfSqlParams(behaviours_status_details, "add", "ser"));

            return new ServiceResponse(dalResponse);

        }
        public async Task<ServiceResponse> update_behaviours_status_details(behaviours_status_details behaviours_status_details)
        {

            var dalResponse = await _db.ExecuteNonQuery("update_behaviours_status_details", _db.CreateListOfSqlParams(behaviours_status_details, "update", "ser"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_behaviours_status_details(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status_details.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_behaviours_status_details", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_behaviours_status_details_with_student_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status_details.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status_details_with_student_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_behaviours_status_details_with_behaviour_status_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviours_status_details.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_behaviours_status_details_with_behaviour_status_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
