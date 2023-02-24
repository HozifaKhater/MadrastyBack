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
    public class AccusedStudentInGuiltService : IAccusedStudentsInGuiltService
    {
        private readonly IDatabaseContext _db;
        public AccusedStudentInGuiltService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveAccusedStudentInGuilt(accused_student_in_guilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_accused_students_in_guilts",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateAccusedStudentInGuilt(accused_student_in_guilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_accused_students_in_guilts",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteAccusedStudentInGuilt(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(accused_student_in_guilt.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_accused_student_in_guilt", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetAccusedStudentsInGuilt()
        {
            var dalResponse = await _db.ExecuteQuery("get_accused_students_in_guilt");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetAccusedStudentInGuiltById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(accused_student_in_guilt.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_accused_student_in_guilt_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        
    }
}
