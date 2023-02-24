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
    public class PaymentRecieptService : IPaymentRecieptServices
    {
        private readonly IDatabaseContext _db;
        public PaymentRecieptService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SavePaymentReciept(payment_reciept reciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_payment_reciept",
                _db.CreateListOfSqlParams(reciept,"add","id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdatePaymentReciept(payment_reciept reciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_payment_reciept",
                _db.CreateListOfSqlParams(reciept, "update","id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeletePaymentReciept(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(payment_reciept.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_payment_reciept", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetPaymentReciept()
        {
            var dalResponse = await _db.ExecuteQuery("get_payment_reciept");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetPaymentRecieptById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(payment_reciept.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_payment_reciept_with_id", pars);
            return new ServiceResponse(dalResponse);
        }


    }
}
