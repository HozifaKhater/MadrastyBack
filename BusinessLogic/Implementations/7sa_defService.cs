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
    public class _7sa_defService : I7sa_defService
    {
        private readonly IDatabaseContext _db;

        public _7sa_defService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_7sa_def()
        {
            var dalResponse = await _db.ExecuteQuery("get_7sa_def");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_7sa_def_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(_7sa_def.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_7sa_def_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_7sa_def(_7sa_def _7sa_def)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_7sa_def", _db.CreateListOfSqlParams(_7sa_def, "add", "ser"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_7sa_def(_7sa_def _7sa_def)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_in_7sa_def", _db.CreateListOfSqlParams(_7sa_def, "update", "ser"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_7sa_def(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(_7sa_def.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_7sa_def", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
