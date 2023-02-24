using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Iteacher_opinion_visitService
    {
        Task<ServiceResponse> get_teacher_opinion_visit();
        Task<ServiceResponse> get_teacher_opinion_visit_with_id(int id);
        Task<ServiceResponse> save_in_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit);
        Task<ServiceResponse> update_teacher_opinion_visit(teacher_opinion_visit teacher_opinion_visit);
        Task<ServiceResponse> delete_from_teacher_opinion_visit(int id);
    }
}
