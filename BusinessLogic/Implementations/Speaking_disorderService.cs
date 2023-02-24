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
    public class Speaking_disorderService : ISpeaking_disorderService
    {
        private readonly IDatabaseContext _db;
        public Speaking_disorderService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_speaking_disorder()
        {
            var dalResponse = await _db.ExecuteQuery("get_speaking_disorder");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_first()
        {
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_first");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_second()
        {
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_second");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_first_with_speech_dis_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_first.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_first_with_speech_dis_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_second_with_speech_dis_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_second.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_second_with_speech_dis_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_first_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_first.speaking_details_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_first_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_details_second_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_second.psychol_visit_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_speaking_details_second_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_speaking_disorder_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Speaking_disorder.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_speaking_disorder_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_speaking_disorder(Speaking_disorder speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.lev_id), speaking_disorder.lev_id.ToString());
            pars.Add(nameof(speaking_disorder.lev_name), speaking_disorder.lev_name);
            pars.Add(nameof(speaking_disorder.class_id), speaking_disorder.class_id.ToString());
            pars.Add(nameof(speaking_disorder.class_name), speaking_disorder.class_name);
            pars.Add(nameof(speaking_disorder.student_id), speaking_disorder.student_id.ToString());
            pars.Add(nameof(speaking_disorder.student_name), speaking_disorder.student_name);
            pars.Add(nameof(speaking_disorder.nationality_id), speaking_disorder.nationality_id.ToString());
            pars.Add(nameof(speaking_disorder.nationality_name), speaking_disorder.nationality_name);
            pars.Add(nameof(speaking_disorder.phone_no), speaking_disorder.phone_no);
            pars.Add(nameof(speaking_disorder.birth_date), speaking_disorder.birth_date);
            pars.Add(nameof(speaking_disorder.work_start_date), speaking_disorder.work_start_date);
            pars.Add(nameof(speaking_disorder.behavioral_notes), speaking_disorder.behavioral_notes);
            pars.Add(nameof(speaking_disorder.dis_type), speaking_disorder.dis_type);

            var dalResponse = await _db.ExecuteQuery("save_in_speaking_disorder", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> update_speaking_disorder(Speaking_disorder speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.speech_dis_id), speaking_disorder.speech_dis_id.ToString());
            pars.Add(nameof(speaking_disorder.lev_id), speaking_disorder.lev_id.ToString());
            pars.Add(nameof(speaking_disorder.lev_name), speaking_disorder.lev_name);
            pars.Add(nameof(speaking_disorder.class_id), speaking_disorder.class_id.ToString());
            pars.Add(nameof(speaking_disorder.class_name), speaking_disorder.class_name);
            pars.Add(nameof(speaking_disorder.student_id), speaking_disorder.student_id.ToString());
            pars.Add(nameof(speaking_disorder.student_name), speaking_disorder.student_name);
            pars.Add(nameof(speaking_disorder.nationality_id), speaking_disorder.nationality_id.ToString());
            pars.Add(nameof(speaking_disorder.nationality_name), speaking_disorder.nationality_name);
            pars.Add(nameof(speaking_disorder.phone_no), speaking_disorder.phone_no);
            pars.Add(nameof(speaking_disorder.birth_date), speaking_disorder.birth_date);
            pars.Add(nameof(speaking_disorder.work_start_date), speaking_disorder.work_start_date);
            pars.Add(nameof(speaking_disorder.behavioral_notes), speaking_disorder.behavioral_notes);
            pars.Add(nameof(speaking_disorder.dis_type), speaking_disorder.dis_type);

            var dalResponse = await _db.ExecuteQuery("update_speaking_disorder", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_speaking_details_first(speaking_details_first speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.speech_dis_id), speaking_disorder.speech_dis_id.ToString());
            pars.Add(nameof(speaking_disorder.other_situations), speaking_disorder.other_situations);
            pars.Add(nameof(speaking_disorder.date), speaking_disorder.date);
            pars.Add(nameof(speaking_disorder.effort_results), speaking_disorder.effort_results);
            pars.Add(nameof(speaking_disorder.end_year_state), speaking_disorder.end_year_state);

            var dalResponse = await _db.ExecuteQuery("save_in_speaking_details_first", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_speaking_details_first(speaking_details_first speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.speaking_details_id), speaking_disorder.speaking_details_id.ToString());
            pars.Add(nameof(speaking_disorder.speech_dis_id), speaking_disorder.speech_dis_id.ToString());
            pars.Add(nameof(speaking_disorder.other_situations), speaking_disorder.other_situations);
            pars.Add(nameof(speaking_disorder.date), speaking_disorder.date);
            pars.Add(nameof(speaking_disorder.effort_results), speaking_disorder.effort_results);
            pars.Add(nameof(speaking_disorder.end_year_state), speaking_disorder.end_year_state);

            var dalResponse = await _db.ExecuteQuery("update_speaking_details_first", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_speaking_details_second(speaking_details_second speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.speech_dis_id), speaking_disorder.speech_dis_id.ToString());
            pars.Add(nameof(speaking_disorder.visit_date), speaking_disorder.visit_date);
            pars.Add(nameof(speaking_disorder.visit_results), speaking_disorder.visit_results);


            var dalResponse = await _db.ExecuteQuery("save_in_speaking_details_second", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_speaking_details_second(speaking_details_second speaking_disorder)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(speaking_disorder.psychol_visit_id), speaking_disorder.psychol_visit_id.ToString());
            pars.Add(nameof(speaking_disorder.speech_dis_id), speaking_disorder.speech_dis_id.ToString());
            pars.Add(nameof(speaking_disorder.visit_date), speaking_disorder.visit_date);
            pars.Add(nameof(speaking_disorder.visit_results), speaking_disorder.visit_results);

            var dalResponse = await _db.ExecuteQuery("update_speaking_details_second", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_speaking_disorder(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Speaking_disorder.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_speaking_disorder", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_speaking_details_first(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_first.speaking_details_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_speaking_details_first", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_speaking_details_second(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_second.psychol_visit_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_speaking_details_second", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_speaking_details_first_with_speech_dis_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_first.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_speaking_details_first_with_speech_dis_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_speaking_details_second_with_speech_dis_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speaking_details_second.speech_dis_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_speaking_details_second_with_speech_dis_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
