using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface I_IndividualCasesServices
    {
        Task<ServiceResponse> SaveIndividualCase(IndividualCases student);
        Task<ServiceResponse> UpdateIndividualCase(IndividualCases student);
        Task<ServiceResponse> DeleteIndividualCase(int id);
        Task<ServiceResponse> GetIndividualCases();
        Task<ServiceResponse> GetIndividualCaseById(int id);
    }
}
