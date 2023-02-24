using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IDefinitionService
    {
        
        Task<ServiceResponse> save_in_definition(definition definition);
        Task<ServiceResponse> getDefinitions();
        Task<ServiceResponse> getDefinition_with_id(int id);

    }
}
