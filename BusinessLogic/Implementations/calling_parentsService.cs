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
    public class calling_parentsService : Icalling_parentsService
    {
        private readonly IDatabaseContext _db;

        public calling_parentsService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_calling_parents()
        {
            var dalResponse = await _db.ExecuteQuery("get_calling_parents");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_calling_parents_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(calling_parents.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_calling_parents_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_calling_parents(calling_parents calling_parents)
        {

            var dalResponse = await _db.ExecuteNonQuery("save_in_calling_parents", _db.CreateListOfSqlParams(calling_parents, "add","ser"));

            return new ServiceResponse(dalResponse);

        }
        public async Task<ServiceResponse> update_calling_parents(calling_parents calling_parents)
        {

            var dalResponse = await _db.ExecuteNonQuery("update_calling_parents", _db.CreateListOfSqlParams(calling_parents, "update", "ser"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_calling_parents(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(calling_parents.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_calling_parents", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
