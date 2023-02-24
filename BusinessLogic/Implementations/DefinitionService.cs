using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data.SqlClient;
using  System.Data;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public  class DefinitionService : IDefinitionService
    {
        private readonly IDatabaseContext _db;

        public DefinitionService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> save_in_definition(definition definition)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(definition.def_name), definition.def_name);
            pars.Add(nameof(definition.s_code), definition.s_code);
            pars.Add(nameof(definition.s_code_arabic), definition.s_code_arabic);
            var dalResponse = await _db.ExecuteQuery("save_in_definition", pars);
            return new ServiceResponse(dalResponse);

   
        }

        public async Task<ServiceResponse> getDefinitions()
        {
            var dalResponse = await _db.ExecuteQuery("get_definitions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> getDefinition_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(definition.def_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_definitions_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
