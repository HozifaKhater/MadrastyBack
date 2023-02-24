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
    public class SchoolServices : ISchoolServices
    {
        private readonly IDatabaseContext _db;
        public SchoolServices(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveSchool(School school)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_school_data",
                _db.CreateListOfSqlParams(school,"add", "school_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateSchool(School school)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_school_data", 
                _db.CreateListOfSqlParams(school,"update", "school_id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteSchool(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(School.school_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_school_data", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetAllSchools()
        {
            var dalResponse = await _db.ExecuteQuery("get_school_data");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSchoolById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(School.school_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_school_data_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        
    }
}
