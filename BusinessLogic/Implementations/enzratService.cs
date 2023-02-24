using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class enzratService : IenzratService
    {
        private readonly IDatabaseContext _db;

        public enzratService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_enzrat()
        {
            var dalResponse = await _db.ExecuteQuery("get_enzrat");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_enzrat_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(enzrat.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_enzrat_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_enzrat(enzrat enzrat)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_enzrat", _db.CreateListOfSqlParams(enzrat, "add", "ser"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_enzrat(enzrat enzrat)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_in_enzrat", _db.CreateListOfSqlParams(enzrat, "update", "ser"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_enzrat(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(enzrat.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_enzrat", pars);
            return new ServiceResponse(dalResponse);
        }
   
      
    }
}
