using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IPaymentRecieptServices
    {
        Task<ServiceResponse> SavePaymentReciept(payment_reciept reciept);
        Task<ServiceResponse> UpdatePaymentReciept(payment_reciept reciept);
        Task<ServiceResponse> DeletePaymentReciept(int id);
        Task<ServiceResponse> GetPaymentReciept();
        Task<ServiceResponse> GetPaymentRecieptById(int id);
    }
}
