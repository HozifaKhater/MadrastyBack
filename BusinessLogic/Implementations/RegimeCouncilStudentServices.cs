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
    public class RegimeCouncilStudentServices : IRegimeCouncilStudentServices
    {
        private readonly IDatabaseContext _db;
        public RegimeCouncilStudentServices(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveRegimeCouncilStudent(RegimeCouncilStudent student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_regime_council_students",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateRegimeCouncilStudent(RegimeCouncilStudent student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_regime_council_students",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteRegimeCouncilStudent(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(RegimeCouncilStudent.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_regime_council_students", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetRegimeCouncilStudentById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(RegimeCouncilStudent.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_regime_council_student_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetRegimeCouncilStudents()
        {
            var dalResponse = await _db.ExecuteQuery("get_regime_council_students");

            return new ServiceResponse(dalResponse);
        }

       
    }
}
