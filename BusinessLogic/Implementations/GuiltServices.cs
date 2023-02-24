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
    public class GuiltServices : IGuiltServices
    {
        private readonly IDatabaseContext _db;
        public GuiltServices(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveGuilt(Guilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_guilts",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateGuilt(Guilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_guilt",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteGuilt(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Guilt.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_guilt", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetGuiltById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Guilt.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_guilt_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetGuiltByStudentId(int student_id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Guilt.student_id), student_id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_guilt_with_student_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetGuilts()
        {
            var dalResponse = await _db.ExecuteQuery("get_guilts");

            return new ServiceResponse(dalResponse);
        }

       
    }
}
