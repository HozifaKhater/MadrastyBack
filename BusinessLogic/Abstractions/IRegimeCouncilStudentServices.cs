using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;

namespace BusinessLogic.Abstractions
{
    public interface IRegimeCouncilStudentServices
    {
        Task<ServiceResponse> SaveRegimeCouncilStudent(RegimeCouncilStudent student);
        Task<ServiceResponse> UpdateRegimeCouncilStudent(RegimeCouncilStudent student);
        Task<ServiceResponse> DeleteRegimeCouncilStudent(int id);
        Task<ServiceResponse> GetRegimeCouncilStudents();
        Task<ServiceResponse> GetRegimeCouncilStudentById(int id);
    }
}
