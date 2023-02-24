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
    public class RestToRedoService : IRestToRedoService
    {
        private readonly IDatabaseContext _db;
        public RestToRedoService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveRestToRedo(rest_to_redo student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_rest_to_redo",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateRestToRedo(rest_to_redo student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_rest_to_redo",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteRestToRedo(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(rest_to_redo.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_rest_to_redo", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetRestToRedo()
        {
            var dalResponse = await _db.ExecuteQuery("get_rest_to_redo");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetRestToRedoById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(rest_to_redo.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_from_rest_to_redo_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        
    }
}
