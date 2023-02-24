using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IUserprivilegesService
    {
        Task<ServiceResponse> delete_from_emp_user_privliges(int id);
        Task<ServiceResponse> delete_from_emp_user_privliges_one_priv(int id);
        Task<ServiceResponse> delete_from_users_with_menus(int id);
        Task<ServiceResponse> get_emp_user_privliges();
        Task<ServiceResponse> get_emp_user_privliges_with_emp_id(int id);
        Task<ServiceResponse> get_emp_user_privliges_with_id(int id);
        Task<ServiceResponse> get_users_with_menus();
        Task<ServiceResponse> get_users_with_menus_with_id(int id);
        Task<ServiceResponse> save_in_emp_user_privliges(Userprivileges privileges);
        Task<ServiceResponse> save_in_users_with_menus(Userprivileges privileges);
        Task<ServiceResponse> update_emp_user_privliges(Userprivileges privileges);
        Task<ServiceResponse> update_users_with_menus(Userprivileges privileges);
    }
}
