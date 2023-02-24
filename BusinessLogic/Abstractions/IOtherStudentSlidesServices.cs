using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;

namespace BusinessLogic.Abstractions
{
    public interface IOtherStudentSlidesServices
    {
        Task<ServiceResponse> SaveOtherStudentSlides(OtherStudentSlides student);
        Task<ServiceResponse> UpdateOtherStudentSlides(OtherStudentSlides student);
        Task<ServiceResponse> DeleteOtherStudentSlides(int id);
        Task<ServiceResponse> GetOtherStudentSlides();
        Task<ServiceResponse> GetOtherStudentSlidesById(int id);
    }
}
