using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsence_casesService
    {
        Task<ServiceResponse> delete_from_absence_cases(int id);
        Task<ServiceResponse> delete_from_absence_cases_details(int id);
        Task<ServiceResponse> delete_from_absence_cases_details_with_absence_cases_id(int id);
        Task<ServiceResponse> get_absence_cases();
        Task<ServiceResponse> get_absence_cases_details();
        Task<ServiceResponse> get_absence_cases_details_with_absence_cases_id(int id);
        Task<ServiceResponse> get_absence_cases_details_with_id(int id);
        Task<ServiceResponse> get_absence_cases_with_id(int id);
        Task<ServiceResponse> save_in_absence_cases(Absence_cases absence_cases);
        Task<ServiceResponse> save_in_absence_cases_details(absence_cases_details absence_cases);
        Task<ServiceResponse> update_absence_cases(Absence_cases absence_cases);
        Task<ServiceResponse> update_absence_cases_details(absence_cases_details absence_cases);

        Task<ServiceResponse> get_gdwel_7ss_with_emp_id_current_7sa(int id);
        Task<ServiceResponse> save_in_absence_student(absence_student absence_student);
        Task<ServiceResponse> get_statistics_absenec_for_dashboard_abs(int id);
        Task<ServiceResponse> get_statistics_absenec_for_dashboard_all_abs();
        Task<ServiceResponse> get_statistics_absenec_for_dashboard_att(int id);
        Task<ServiceResponse> get_statistics_absenec_for_dashboard_all_att();
    }
}
