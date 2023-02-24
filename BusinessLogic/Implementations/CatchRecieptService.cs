using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data;
using  System.Data.SqlClient;
using  System.Linq;
using  System.Reflection;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class CatchRecieptService : ICatchRecieptService
    {
        private readonly IDatabaseContext _db;
        public CatchRecieptService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveCatchReciept(catch_reciept reciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_catch_reciept",
                _db.CreateListOfSqlParams(reciept,"add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateCatchReciept(catch_reciept reciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_catch_reciept",
                _db.CreateListOfSqlParams(reciept,"update", "id"));
            
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteCatchReciept(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(catch_reciept.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_catch_reciept", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetCatchReciept()
        {
            var dalResponse = await _db.ExecuteQuery("get_catch_reciept");

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetCatchRecieptById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(catch_reciept.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_catch_reciept_with_id", pars);
            return new ServiceResponse(dalResponse);
        }


    }
}
