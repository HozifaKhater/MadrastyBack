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
    public class UserprivilegesService : IUserprivilegesService
    {
        private readonly IDatabaseContext _db;

        public UserprivilegesService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> save_in_emp_user_privliges(Userprivileges privileges)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(privileges.emp_id), privileges.emp_id.ToString());
            pars.Add(nameof(privileges.priv_name), privileges.priv_name);
            pars.Add(nameof(privileges.page_name), privileges.page_name);
            pars.Add(nameof(privileges.in_class_priv), privileges.in_class_priv.ToString());
            pars.Add(nameof(privileges.dep_work), privileges.dep_work.ToString());
            pars.Add(nameof(privileges.job_id), privileges.job_id.ToString());

            var dalResponse = await _db.ExecuteQuery("save_in_emp_user_privliges", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> save_in_users_with_menus(Userprivileges privileges)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(privileges.emp_name), privileges.emp_name);
            pars.Add(nameof(privileges.emp_id), privileges.emp_id.ToString());
            pars.Add(nameof(privileges.menu_route), privileges.menu_route);
            pars.Add(nameof(privileges.menu_id), privileges.menu_id.ToString());
            pars.Add(nameof(privileges.read), privileges.read.ToString());
            pars.Add(nameof(privileges.write), privileges.write.ToString());
            pars.Add(nameof(privileges.read_and_write), privileges.read_and_write.ToString());
            pars.Add(nameof(privileges.user_menu_name), privileges.user_menu_name);

            var dalResponse = await _db.ExecuteQuery("save_in_users_with_menus", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> get_emp_user_privliges()
        {
            var dalResponse = await _db.ExecuteQuery("get_emp_user_privliges");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_users_with_menus()
        {
            var dalResponse = await _db.ExecuteQuery("get_users_with_menus");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_emp_user_privliges_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.user_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_emp_user_privliges_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_users_with_menus_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_users_with_menus_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_emp_user_privliges_with_emp_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.emp_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_emp_user_privliges_with_emp_id", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> update_emp_user_privliges(Userprivileges privileges)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(privileges.user_id), privileges.user_id.ToString());
            pars.Add(nameof(privileges.emp_name), privileges.emp_name);
            pars.Add(nameof(privileges.emp_id), privileges.emp_id.ToString());
            pars.Add(nameof(privileges.menu_route), privileges.menu_route);
            pars.Add(nameof(privileges.menu_id), privileges.menu_id.ToString());
            pars.Add(nameof(privileges.read), privileges.read.ToString());
            pars.Add(nameof(privileges.write), privileges.write.ToString());
            pars.Add(nameof(privileges.read_and_write), privileges.read_and_write.ToString());
            pars.Add(nameof(privileges.user_menu_name), privileges.user_menu_name);

            var dalResponse = await _db.ExecuteQuery("update_emp_user_privliges", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> update_users_with_menus(Userprivileges privileges)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(privileges.id), privileges.id.ToString());
            pars.Add(nameof(privileges.emp_name), privileges.emp_name);
            pars.Add(nameof(privileges.emp_id), privileges.emp_id.ToString());
            pars.Add(nameof(privileges.menu_route), privileges.menu_route);
            pars.Add(nameof(privileges.menu_id), privileges.menu_id.ToString());
            pars.Add(nameof(privileges.read), privileges.read.ToString());
            pars.Add(nameof(privileges.write), privileges.write.ToString());
            pars.Add(nameof(privileges.read_and_write), privileges.read_and_write.ToString());
            pars.Add(nameof(privileges.user_menu_name), privileges.user_menu_name);

            var dalResponse = await _db.ExecuteQuery("update_users_with_menus", pars);
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_emp_user_privliges(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.user_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_emp_user_privliges", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> delete_from_emp_user_privliges_one_priv(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.user_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_emp_user_privliges_one_priv", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> delete_from_users_with_menus(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Userprivileges.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_users_with_menus", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
