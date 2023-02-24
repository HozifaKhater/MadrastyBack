using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Istudent_trackingService
    {
        Task<ServiceResponse> get_student_tracking(student_tracking student_tracking);
        Task<ServiceResponse> get_student_tracking_with_date_and_classid(student_tracking student_tracking);  
        Task<ServiceResponse> save_update_student_tracking(student_tracking student_tracking);
    }
}
