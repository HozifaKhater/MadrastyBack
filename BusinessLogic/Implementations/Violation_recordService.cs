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
    public class Violation_recordService : IViolation_recordService
    {
        private readonly IDatabaseContext _db;
        public Violation_recordService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_violation_record()
        {
            var dalResponse = await _db.ExecuteQuery("get_violation_record");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_violation_record_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(violation_record.viol_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_violation_record_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_violation_record(violation_record viol)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(viol.lev_id), viol.lev_id.ToString());
            pars.Add(nameof(viol.lev_name), viol.lev_name);
            pars.Add(nameof(viol.class_id), viol.class_id.ToString());
            pars.Add(nameof(viol.class_name), viol.class_name);
            pars.Add(nameof(viol.student_id), viol.student_id.ToString());
            pars.Add(nameof(viol.student_name), viol.student_name);
            pars.Add(nameof(viol.viol_date), viol.viol_date);
            pars.Add(nameof(viol.violation_id), viol.violation_id.ToString());
            pars.Add(nameof(viol.violation_name), viol.violation_name);
            pars.Add(nameof(viol.procedure_id), viol.procedure_id.ToString());
            pars.Add(nameof(viol.procedure_name), viol.procedure_name);

            var dalResponse = await _db.ExecuteQuery("save_in_violation_record", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_violation_record(violation_record viol)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(viol.viol_id), viol.viol_id.ToString());
            pars.Add(nameof(viol.lev_id), viol.lev_id.ToString());
            pars.Add(nameof(viol.lev_name), viol.lev_name);
            pars.Add(nameof(viol.class_id), viol.class_id.ToString());
            pars.Add(nameof(viol.class_name), viol.class_name);
            pars.Add(nameof(viol.student_id), viol.student_id.ToString());
            pars.Add(nameof(viol.student_name), viol.student_name);
            pars.Add(nameof(viol.viol_date), viol.viol_date);
            pars.Add(nameof(viol.violation_id), viol.violation_id.ToString());
            pars.Add(nameof(viol.violation_name), viol.violation_name);
            pars.Add(nameof(viol.procedure_id), viol.procedure_id.ToString());
            pars.Add(nameof(viol.procedure_name), viol.procedure_name);

            var dalResponse = await _db.ExecuteQuery("update_violation_record", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_violation_record(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(violation_record.viol_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_violation_record", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
