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
    public class Student_transferService : IStudent_transferService
    {
        private readonly IDatabaseContext _db;
        public Student_transferService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_student_transfer()
        {
            var dalResponse = await _db.ExecuteQuery("get_student_transfer");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_student_transfer_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Student_transfer.student_trans_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_student_transfer_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_student_transfer(Student_transfer studentrans)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(studentrans.lev_id), studentrans.lev_id.ToString());
            pars.Add(nameof(studentrans.lev_name), studentrans.lev_name);
            pars.Add(nameof(studentrans.class_id), studentrans.class_id.ToString());
            pars.Add(nameof(studentrans.class_name), studentrans.class_name);
            pars.Add(nameof(studentrans.student_id), studentrans.student_id.ToString());
            pars.Add(nameof(studentrans.student_name), studentrans.student_name);
            pars.Add(nameof(studentrans.student_civilian_id), studentrans.student_civilian_id);
            pars.Add(nameof(studentrans.student_branch), studentrans.student_branch);
            pars.Add(nameof(studentrans.educational_area), studentrans.educational_area);
            pars.Add(nameof(studentrans.school_trans), studentrans.school_trans);
            pars.Add(nameof(studentrans.new_branch), studentrans.new_branch.ToString());
            pars.Add(nameof(studentrans.trans_date), studentrans.trans_date);
            pars.Add(nameof(studentrans.student_branch_id), studentrans.student_branch_id.ToString());
            pars.Add(nameof(studentrans.educational_area_id), studentrans.educational_area_id.ToString());
            pars.Add(nameof(studentrans.school_trans_id), studentrans.school_trans_id.ToString());

            var dalResponse = await _db.ExecuteQuery("save_in_student_transfer", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_student_transfer(Student_transfer studentrans)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(studentrans.student_trans_id), studentrans.student_trans_id.ToString());
            pars.Add(nameof(studentrans.lev_id), studentrans.lev_id.ToString());
            pars.Add(nameof(studentrans.lev_name), studentrans.lev_name);
            pars.Add(nameof(studentrans.class_id), studentrans.class_id.ToString());
            pars.Add(nameof(studentrans.class_name), studentrans.class_name);
            pars.Add(nameof(studentrans.student_id), studentrans.student_id.ToString());
            pars.Add(nameof(studentrans.student_name), studentrans.student_name);
            pars.Add(nameof(studentrans.student_civilian_id), studentrans.student_civilian_id);
            pars.Add(nameof(studentrans.student_branch), studentrans.student_branch);
            pars.Add(nameof(studentrans.educational_area), studentrans.educational_area);
            pars.Add(nameof(studentrans.school_trans), studentrans.school_trans);
            pars.Add(nameof(studentrans.new_branch), studentrans.new_branch.ToString());
            pars.Add(nameof(studentrans.trans_date), studentrans.trans_date);
            pars.Add(nameof(studentrans.student_branch_id), studentrans.student_branch_id.ToString());
            pars.Add(nameof(studentrans.educational_area_id), studentrans.educational_area_id.ToString());
            pars.Add(nameof(studentrans.school_trans_id), studentrans.school_trans_id.ToString());

            var dalResponse = await _db.ExecuteQuery("update_student_transfer", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_student_transfer(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Student_transfer.student_trans_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_student_transfer", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
