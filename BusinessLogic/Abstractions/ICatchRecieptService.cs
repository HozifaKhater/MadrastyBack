using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;

namespace BusinessLogic.Abstractions
{
    public interface ICatchRecieptService
    {
        Task<ServiceResponse> SaveCatchReciept(catch_reciept reciept);
        Task<ServiceResponse> UpdateCatchReciept(catch_reciept reciept);
        Task<ServiceResponse> DeleteCatchReciept(int id);
        Task<ServiceResponse> GetCatchReciept();
        Task<ServiceResponse> GetCatchRecieptById(int id);

    }
}
