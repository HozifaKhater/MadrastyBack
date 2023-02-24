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
    public class Ta7dierService : ITa7dierService
    {
        private readonly IDatabaseContext _db;
        public Ta7dierService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveTa7dier(ta7dier_master ta7dier)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_ta7dier_master",
                _db.CreateListOfSqlParams(ta7dier, "add", "ta7dier_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateTa7dier(ta7dier_master ta7dier)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_ta7dier_master",
               _db.CreateListOfSqlParams(ta7dier, "update", "ta7dier_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteTa7dier(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dier_master.ta7dier_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_ta7dier_master", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetTa7dierById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dier_master.ta7dier_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_ta7dier_master_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetTa7diers()
        {
            var dalResponse = await _db.ExecuteQuery("get_ta7dier_master");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetTa7dierBySubjectId(int subject_id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dier_master.subject_id), subject_id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_ta7dier_master_with_subject_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
