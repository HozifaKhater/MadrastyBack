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
    public class Ta7dierJoinEmployeeService : ITa7dierJoinEmployeeService
    {
        private readonly IDatabaseContext _db;
        public Ta7dierJoinEmployeeService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> GetTa7dierWithDeptAndSubj(Ta7dierJoinEmployee ta7Dier)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dier_master.subject_name), ta7Dier.ta7dier.subject_name);
            pars.Add(nameof(employee.dep_name), ta7Dier.employee.dep_name);

            var dalResponse = await _db.ExecuteQuery("get_t7deer_with_dept_and_subj", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
