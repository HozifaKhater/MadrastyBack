using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IStudent_transferService
    {
        Task<ServiceResponse> delete_from_student_transfer(int id);
        Task<ServiceResponse> get_student_transfer();
        Task<ServiceResponse> get_student_transfer_with_id(int id);
        Task<ServiceResponse> save_in_student_transfer(Student_transfer studentrans);
        Task<ServiceResponse> update_student_transfer(Student_transfer studentrans);
    }
}
