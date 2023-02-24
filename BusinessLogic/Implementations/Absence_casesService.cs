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
    public class Absence_casesService : IAbsence_casesService
    {
        private readonly IDatabaseContext _db;
        public Absence_casesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_absence_cases()
        {
            var dalResponse = await _db.ExecuteQuery("get_absence_cases");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_absence_cases_details()
        {
            var dalResponse = await _db.ExecuteQuery("get_absence_cases_details");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_absence_cases_details_with_absence_cases_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absence_cases_details.absence_cases_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_absence_cases_details_with_absence_cases_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_absence_cases_details_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absence_cases_details.absence_details_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_absence_cases_details_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_absence_cases_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Absence_cases.absence_cases_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_absence_cases_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_absence_cases(Absence_cases absence_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(absence_cases.lev_id), absence_cases.lev_id.ToString());
            pars.Add(nameof(absence_cases.lev_name), absence_cases.lev_name);
            pars.Add(nameof(absence_cases.class_id), absence_cases.class_id.ToString());
            pars.Add(nameof(absence_cases.class_name), absence_cases.class_name);
            pars.Add(nameof(absence_cases.student_id), absence_cases.student_id.ToString());
            pars.Add(nameof(absence_cases.student_name), absence_cases.student_name);
            pars.Add(nameof(absence_cases.nationality_id), absence_cases.nationality_id.ToString());
            pars.Add(nameof(absence_cases.nationality_name), absence_cases.nationality_name);
            pars.Add(nameof(absence_cases.phone_no), absence_cases.phone_no);
            pars.Add(nameof(absence_cases.birth_date), absence_cases.birth_date);
            pars.Add(nameof(absence_cases.work_start_date), absence_cases.work_start_date);
            pars.Add(nameof(absence_cases.behavioral_notes), absence_cases.behavioral_notes);
            pars.Add(nameof(absence_cases.self_reasons), absence_cases.self_reasons);

            var dalResponse = await _db.ExecuteQuery("save_in_absence_cases", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> update_absence_cases(Absence_cases absence_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(absence_cases.absence_cases_id), absence_cases.absence_cases_id.ToString());
            pars.Add(nameof(absence_cases.lev_id), absence_cases.lev_id.ToString());
            pars.Add(nameof(absence_cases.lev_name), absence_cases.lev_name);
            pars.Add(nameof(absence_cases.class_id), absence_cases.class_id.ToString());
            pars.Add(nameof(absence_cases.class_name), absence_cases.class_name);
            pars.Add(nameof(absence_cases.student_id), absence_cases.student_id.ToString());
            pars.Add(nameof(absence_cases.student_name), absence_cases.student_name);
            pars.Add(nameof(absence_cases.nationality_id), absence_cases.nationality_id.ToString());
            pars.Add(nameof(absence_cases.nationality_name), absence_cases.nationality_name);
            pars.Add(nameof(absence_cases.phone_no), absence_cases.phone_no);
            pars.Add(nameof(absence_cases.birth_date), absence_cases.birth_date);
            pars.Add(nameof(absence_cases.work_start_date), absence_cases.work_start_date);
            pars.Add(nameof(absence_cases.behavioral_notes), absence_cases.behavioral_notes);
            pars.Add(nameof(absence_cases.self_reasons), absence_cases.self_reasons);

            var dalResponse = await _db.ExecuteQuery("update_absence_cases", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_absence_cases_details(absence_cases_details absence_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(absence_cases.absence_cases_id), absence_cases.absence_cases_id.ToString());
            pars.Add(nameof(absence_cases.other_situations), absence_cases.other_situations);
            pars.Add(nameof(absence_cases.date), absence_cases.date);
            pars.Add(nameof(absence_cases.effort_results), absence_cases.effort_results);
            pars.Add(nameof(absence_cases.end_year_state), absence_cases.end_year_state);

            var dalResponse = await _db.ExecuteQuery("save_in_absence_cases_details", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_absence_cases_details(absence_cases_details absence_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(absence_cases.absence_details_id), absence_cases.absence_details_id.ToString());
            pars.Add(nameof(absence_cases.absence_cases_id), absence_cases.absence_cases_id.ToString());
            pars.Add(nameof(absence_cases.other_situations), absence_cases.other_situations);
            pars.Add(nameof(absence_cases.date), absence_cases.date);
            pars.Add(nameof(absence_cases.effort_results), absence_cases.effort_results);
            pars.Add(nameof(absence_cases.end_year_state), absence_cases.end_year_state);

            var dalResponse = await _db.ExecuteQuery("update_absence_cases_details", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_absence_cases(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Absence_cases.absence_cases_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_absence_cases", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_absence_cases_details(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absence_cases_details.absence_details_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_absence_cases_details", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_absence_cases_details_with_absence_cases_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(absence_cases_details.absence_cases_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_absence_cases_details_with_absence_cases_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_gdwel_7ss_with_emp_id_current_7sa(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("emp_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_gdwel_7ss_with_emp_id_current_7sa", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_absence_student(absence_student absence_student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_absence_student",
                _db.CreateListOfSqlParams(absence_student, "add", "ser"));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_statistics_absenec_for_dashboard_abs(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("emp_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_statistics_absenec_for_dashboard_abs", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_statistics_absenec_for_dashboard_all_abs()
        {
            
          
            var dalResponse = await _db.ExecuteQuery("get_statistics_absenec_for_dashboard_all_abs");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_statistics_absenec_for_dashboard_att(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("emp_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_statistics_absenec_for_dashboard_att", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_statistics_absenec_for_dashboard_all_att()
        {


            var dalResponse = await _db.ExecuteQuery("get_statistics_absenec_for_dashboard_all_att");
            return new ServiceResponse(dalResponse);
        }
    }
}
