using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAccusedStudentsInGuiltService
    {
        Task<ServiceResponse> SaveAccusedStudentInGuilt(accused_student_in_guilt student);
        Task<ServiceResponse> UpdateAccusedStudentInGuilt(accused_student_in_guilt student);
        Task<ServiceResponse> DeleteAccusedStudentInGuilt(int id);
        Task<ServiceResponse> GetAccusedStudentsInGuilt();
        Task<ServiceResponse> GetAccusedStudentInGuiltById(int id);

    }
}
