using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IStudent_leaveService
    {
        Task<ServiceResponse> delete_from_student_leave(int id);
        Task<ServiceResponse> get_student_leave();
        Task<ServiceResponse> get_student_leave_with_id(int id);
        Task<ServiceResponse> save_in_student_leave(Student_leave studentleave);
        Task<ServiceResponse> update_student_leave(Student_leave studentleave);
    }
}
