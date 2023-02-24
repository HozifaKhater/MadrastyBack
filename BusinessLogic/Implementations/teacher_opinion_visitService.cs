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
    public class teacher_opinion_visitService: Iteacher_opinion_visitService
    {
        private readonly IDatabaseContext _db;

        public teacher_opinion_visitService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_teacher_opinion_visit()
        {
            var dalResponse = await _db.ExecuteQuery("get_teacher_opinion_visit");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_teacher_opinion_visit_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(teacher_opinion_visit.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_teacher_opinion_visit_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(teacher_opinion_visit.takeem_id), teacher_opinion_visit.takeem_id.ToString());
            pars.Add(nameof(teacher_opinion_visit.emp_id), teacher_opinion_visit.emp_id.ToString());
            pars.Add(nameof(teacher_opinion_visit.is_agree), teacher_opinion_visit.is_agree.ToString());
            pars.Add(nameof(teacher_opinion_visit.notes), teacher_opinion_visit.notes);

            var dalResponse = await _db.ExecuteQuery("save_in_teacher_opinion_visit", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(teacher_opinion_visit.ser), teacher_opinion_visit.ser.ToString());
            pars.Add(nameof(teacher_opinion_visit.takeem_id), teacher_opinion_visit.takeem_id.ToString());
            pars.Add(nameof(teacher_opinion_visit.emp_id), teacher_opinion_visit.emp_id.ToString());
            pars.Add(nameof(teacher_opinion_visit.is_agree), teacher_opinion_visit.is_agree.ToString());
            pars.Add(nameof(teacher_opinion_visit.notes), teacher_opinion_visit.notes);

            var dalResponse = await _db.ExecuteQuery("update_teacher_opinion_visit", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_teacher_opinion_visit(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(teacher_opinion_visit.ser), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_teacher_opinion_visit", pars);
            return new ServiceResponse(dalResponse);
        }

    }
}
