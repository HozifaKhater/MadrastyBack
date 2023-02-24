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
    public class Student_leaveService : IStudent_leaveService
    {
        private readonly IDatabaseContext _db;
        public Student_leaveService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_student_leave()
        {
            var dalResponse = await _db.ExecuteQuery("get_student_leave");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_student_leave_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Student_leave.leav_stu_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_student_leave_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_student_leave(Student_leave studentleave)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(studentleave.lev_id), studentleave.lev_id.ToString());
            pars.Add(nameof(studentleave.lev_name), studentleave.lev_name);
            pars.Add(nameof(studentleave.class_id), studentleave.class_id.ToString());
            pars.Add(nameof(studentleave.class_name), studentleave.class_name);
            pars.Add(nameof(studentleave.student_id), studentleave.student_id.ToString());
            pars.Add(nameof(studentleave.student_name), studentleave.student_name);
            pars.Add(nameof(studentleave.student_civilian_id), studentleave.student_civilian_id);
            pars.Add(nameof(studentleave.student_branch_id), studentleave.student_branch_id.ToString());
            pars.Add(nameof(studentleave.student_branch), studentleave.student_branch);
            pars.Add(nameof(studentleave.leave_reason_id), studentleave.leave_reason_id.ToString());
            pars.Add(nameof(studentleave.leave_reason), studentleave.leave_reason);
            pars.Add(nameof(studentleave.leave_date), studentleave.leave_date);

            var dalResponse = await _db.ExecuteQuery("save_in_student_leave", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_student_leave(Student_leave studentleave)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(studentleave.leav_stu_id), studentleave.leav_stu_id.ToString());
            pars.Add(nameof(studentleave.lev_id), studentleave.lev_id.ToString());
            pars.Add(nameof(studentleave.lev_name), studentleave.lev_name);
            pars.Add(nameof(studentleave.class_id), studentleave.class_id.ToString());
            pars.Add(nameof(studentleave.class_name), studentleave.class_name);
            pars.Add(nameof(studentleave.student_id), studentleave.student_id.ToString());
            pars.Add(nameof(studentleave.student_name), studentleave.student_name);
            pars.Add(nameof(studentleave.student_civilian_id), studentleave.student_civilian_id);
            pars.Add(nameof(studentleave.student_branch_id), studentleave.student_branch_id.ToString());
            pars.Add(nameof(studentleave.student_branch), studentleave.student_branch);
            pars.Add(nameof(studentleave.leave_reason_id), studentleave.leave_reason_id.ToString());
            pars.Add(nameof(studentleave.leave_reason), studentleave.leave_reason);
            pars.Add(nameof(studentleave.leave_date), studentleave.leave_date);

            var dalResponse = await _db.ExecuteQuery("update_student_leave", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_student_leave(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Student_leave.leav_stu_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_student_leave", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
