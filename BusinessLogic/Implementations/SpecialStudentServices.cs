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
    public class SpecialStudentServices : ISpecialStudentServices
    {
        private readonly IDatabaseContext _db;
        public SpecialStudentServices(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveSpecialStudent(SpecialStudent student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_special_students",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateSpecialStudent(SpecialStudent student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_special_students",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteSpecialStudent(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SpecialStudent.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_special_students", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSpecialStudentById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SpecialStudent.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_special_student_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSpecialStudents()
        {
            var dalResponse = await _db.ExecuteQuery("get_special_students");

            return new ServiceResponse(dalResponse);
        }

        
    }
}
