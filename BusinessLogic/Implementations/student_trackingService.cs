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
    public class student_trackingService : Istudent_trackingService
    {
        private readonly IDatabaseContext _db;

        public student_trackingService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_student_tracking(student_tracking student_tracking)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(student_tracking.class_id), student_tracking.class_id.ToString());
            pars.Add(nameof(student_tracking.date), student_tracking.date);
        
            var dalResponse = await _db.ExecuteQuery("get_student_tracking", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_update_student_tracking(student_tracking student_tracking)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(student_tracking.term_id), student_tracking.term_id.ToString());
            pars.Add(nameof(student_tracking.subject_id), student_tracking.subject_id.ToString());
            pars.Add(nameof(student_tracking.level_id), student_tracking.level_id.ToString());
            pars.Add(nameof(student_tracking.class_id), student_tracking.class_id.ToString());
            pars.Add(nameof(student_tracking.date), student_tracking.date);
            pars.Add(nameof(student_tracking.student_id), student_tracking.student_id.ToString());
            pars.Add(nameof(student_tracking.behavior), student_tracking.behavior);
            pars.Add(nameof(student_tracking.book), student_tracking.book);
            pars.Add(nameof(student_tracking.practice), student_tracking.practice);

            var dalResponse = await _db.ExecuteQuery("save_update_student_tracking", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> get_student_tracking_with_date_and_classid(student_tracking student_tracking)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(student_tracking.class_id), student_tracking.class_id.ToString());
            pars.Add(nameof(student_tracking.date), student_tracking.date);

            var dalResponse = await _db.ExecuteQuery("get_student_tracking_with_date_and_classid", pars);
            return new ServiceResponse(dalResponse);



        }
    }
}
