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
    public class OtherStudentSlidesServices : IOtherStudentSlidesServices
    {
        private readonly IDatabaseContext _db;
        public OtherStudentSlidesServices(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveOtherStudentSlides(OtherStudentSlides student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_other_student_slides",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateOtherStudentSlides(OtherStudentSlides student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_other_student_slides",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteOtherStudentSlides(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(OtherStudentSlides.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_other_student_slides", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetOtherStudentSlides()
        {
            var dalResponse = await _db.ExecuteQuery("get_other_student_slides");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetOtherStudentSlidesById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(OtherStudentSlides.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_other_student_slides_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        
    }
}
