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
    public class DepartmentService : IDepartmanetService
    {
        private readonly IDatabaseContext _db;

        public DepartmentService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveDepartment(Department department)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(department.Name), department.Name);
            pars.Add(nameof(department.Description), department.Description);

            var dalResponse = await _db.ExecuteQuery("",pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
