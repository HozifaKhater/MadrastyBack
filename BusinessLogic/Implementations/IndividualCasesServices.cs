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
    public class IndividualCasesServices : I_IndividualCasesServices
    {
        private readonly IDatabaseContext _db;
        public IndividualCasesServices(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> SaveIndividualCase(IndividualCases student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_indevidual_cases",
               _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateIndividualCase(IndividualCases student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_indevidual_cases",
                _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteIndividualCase(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(IndividualCases.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_individual_cases", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetIndividualCaseById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(IndividualCases.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_individual_cases_with_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetIndividualCases()
        {
            var dalResponse = await _db.ExecuteQuery("get_individual_cases");

            return new ServiceResponse(dalResponse);
        }

       
    }
}
