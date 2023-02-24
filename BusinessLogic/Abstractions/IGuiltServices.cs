using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;

namespace BusinessLogic.Abstractions
{
    public interface IGuiltServices
    {
        Task<ServiceResponse> SaveGuilt(Guilt student);
        Task<ServiceResponse> UpdateGuilt(Guilt student);
        Task<ServiceResponse> DeleteGuilt(int id);
        Task<ServiceResponse> GetGuilts();
        Task<ServiceResponse> GetGuiltById(int id);
        Task<ServiceResponse> GetGuiltByStudentId(int id);
    }
}
