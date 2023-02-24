using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Istudent_status_behaviour_reportService
    {
        Task<ServiceResponse> delete_from_student_status_behaviour_report(int id);
        Task<ServiceResponse> get_student_status_behaviour_report();
        Task<ServiceResponse> get_student_status_behaviour_report_with_id(int id);
        Task<ServiceResponse> save_in_student_status_behaviour_report(student_status_behaviour_report behave);
        Task<ServiceResponse> update_student_status_behaviour_report(student_status_behaviour_report behave);

    }
}
