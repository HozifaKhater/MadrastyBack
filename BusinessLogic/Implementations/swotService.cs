using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data.SqlClient;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class swotService : IswotService
    {
        private readonly IDatabaseContext _db;

        public swotService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_swot()
        {
            var dalResponse = await _db.ExecuteQuery("get_swot");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_swot_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(swot.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_swot_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_swot(swot swot)
        {
            var pars = new Dictionary<string, string>();


            pars.Add(nameof(swot.dep_id), swot.dep_id.ToString());
            pars.Add(nameof(swot.dep_name), swot.dep_name);
            pars.Add(nameof(swot.strength), swot.strength);
            pars.Add(nameof(swot.weakness), swot.weakness);
            pars.Add(nameof(swot.chances), swot.chances);
            pars.Add(nameof(swot.risks), swot.risks);
            //var  pars= _db.create_stored_procedure_prams(swot);

            var dalResponse = await _db.ExecuteQuery("save_in_swot", pars) ;
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_swot(swot swot)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(swot.dep_id), swot.dep_id.ToString());
            pars.Add(nameof(swot.dep_name), swot.dep_name);
            pars.Add(nameof(swot.strength), swot.strength);
            pars.Add(nameof(swot.weakness), swot.weakness);
            pars.Add(nameof(swot.chances), swot.chances);
            pars.Add(nameof(swot.risks), swot.risks);
            var dalResponse = await _db.ExecuteQuery("update_swot", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_swot(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(swot.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_swot", pars);
            return new ServiceResponse(dalResponse);
        }

    }
}
