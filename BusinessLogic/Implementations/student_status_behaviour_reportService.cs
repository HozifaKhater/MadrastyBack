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
    public class student_status_behaviour_reportService : Istudent_status_behaviour_reportService
    {
        private readonly IDatabaseContext _db;

        public student_status_behaviour_reportService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_student_status_behaviour_report()
        {
            var dalResponse = await _db.ExecuteQuery("get_student_status_behaviour_report");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_student_status_behaviour_report_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(student_status_behaviour_report.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_student_status_behaviour_report_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_student_status_behaviour_report(student_status_behaviour_report student_status_behaviour_report)
        {

            var dalResponse = await _db.ExecuteNonQuery("save_in_student_status_behaviour_report", _db.CreateListOfSqlParams(student_status_behaviour_report, "add", "id"));

            return new ServiceResponse(dalResponse);

        }
        public async Task<ServiceResponse> update_student_status_behaviour_report(student_status_behaviour_report student_status_behaviour_report)
        {

            var dalResponse = await _db.ExecuteNonQuery("update_student_status_behaviour_report", _db.CreateListOfSqlParams(student_status_behaviour_report, "update", "id"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_student_status_behaviour_report(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(student_status_behaviour_report.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_student_status_behaviour_report", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
