using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITa7dierJoinEmployeeService
    {
        Task<ServiceResponse> GetTa7dierWithDeptAndSubj(Ta7dierJoinEmployee ta7Dier);
    }
}
