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
    public class Health_casesService : IHealth_casesService
    {
        private readonly IDatabaseContext _db;
        public Health_casesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_health_cases()
        {
            var dalResponse = await _db.ExecuteQuery("get_health_cases");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_health_cases_details()
        {
            var dalResponse = await _db.ExecuteQuery("get_health_cases_details");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_health_cases_details_with_health_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(health_cases_details.health_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_health_cases_details_with_health_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_health_cases_details_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(health_cases_details.health_det_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_health_cases_details_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_health_cases_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Health_cases.health_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_health_cases_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_health_cases(Health_cases health_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(health_cases.lev_id), health_cases.lev_id.ToString());
            pars.Add(nameof(health_cases.lev_name), health_cases.lev_name);
            pars.Add(nameof(health_cases.class_id), health_cases.class_id.ToString());
            pars.Add(nameof(health_cases.class_name), health_cases.class_name);
            pars.Add(nameof(health_cases.student_id), health_cases.student_id.ToString());
            pars.Add(nameof(health_cases.student_name), health_cases.student_name);
            pars.Add(nameof(health_cases.nationality_id), health_cases.nationality_id.ToString());
            pars.Add(nameof(health_cases.nationality), health_cases.nationality);
            pars.Add(nameof(health_cases.phone_no), health_cases.phone_no);
            pars.Add(nameof(health_cases.birth_date), health_cases.birth_date);
            pars.Add(nameof(health_cases.work_start_date), health_cases.work_start_date);
            pars.Add(nameof(health_cases.dis_status), health_cases.dis_status);
            pars.Add(nameof(health_cases.health_recomm), health_cases.health_recomm);
            pars.Add(nameof(health_cases.year_end_state), health_cases.year_end_state);

            var dalResponse = await _db.ExecuteQuery("save_in_health_cases", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> update_health_cases(Health_cases health_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(health_cases.health_id), health_cases.health_id.ToString());
            pars.Add(nameof(health_cases.lev_id), health_cases.lev_id.ToString());
            pars.Add(nameof(health_cases.lev_name), health_cases.lev_name);
            pars.Add(nameof(health_cases.class_id), health_cases.class_id.ToString());
            pars.Add(nameof(health_cases.class_name), health_cases.class_name);
            pars.Add(nameof(health_cases.student_id), health_cases.student_id.ToString());
            pars.Add(nameof(health_cases.student_name), health_cases.student_name);
            pars.Add(nameof(health_cases.nationality_id), health_cases.nationality_id.ToString());
            pars.Add(nameof(health_cases.nationality), health_cases.nationality);
            pars.Add(nameof(health_cases.phone_no), health_cases.phone_no);
            pars.Add(nameof(health_cases.birth_date), health_cases.birth_date);
            pars.Add(nameof(health_cases.work_start_date), health_cases.work_start_date);
            pars.Add(nameof(health_cases.dis_status), health_cases.dis_status);
            pars.Add(nameof(health_cases.health_recomm), health_cases.health_recomm);
            pars.Add(nameof(health_cases.year_end_state), health_cases.year_end_state);

            var dalResponse = await _db.ExecuteQuery("update_health_cases", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_health_cases_details(health_cases_details health_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(health_cases.health_id), health_cases.health_id.ToString());
            pars.Add(nameof(health_cases.other_situations), health_cases.other_situations);
            pars.Add(nameof(health_cases.date), health_cases.date);
            pars.Add(nameof(health_cases.effort_results), health_cases.effort_results);
            pars.Add(nameof(health_cases.end_year_state), health_cases.end_year_state);

            var dalResponse = await _db.ExecuteQuery("save_in_health_cases_details", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_health_cases_details(health_cases_details health_cases)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(health_cases.health_det_id), health_cases.health_det_id.ToString());
            pars.Add(nameof(health_cases.health_id), health_cases.health_id.ToString());
            pars.Add(nameof(health_cases.other_situations), health_cases.other_situations);
            pars.Add(nameof(health_cases.date), health_cases.date);
            pars.Add(nameof(health_cases.effort_results), health_cases.effort_results);
            pars.Add(nameof(health_cases.end_year_state), health_cases.end_year_state);

            var dalResponse = await _db.ExecuteQuery("update_health_cases_details", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_health_cases(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Health_cases.health_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_health_cases", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_health_cases_details(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(health_cases_details.health_det_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_health_cases_details", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_health_cases_details_with_health_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(health_cases_details.health_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_health_cases_details_with_health_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
