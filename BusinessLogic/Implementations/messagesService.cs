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
    public class messagesService: ImessagesService
    {
        private readonly IDatabaseContext _db;

        public messagesService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_inbox(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("emp_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_inbox", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_message_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("msg_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_message_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_messages(messages messages)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(messages.from_emp_id), messages.from_emp_id.ToString());
            pars.Add(nameof(messages.title), messages.title.ToString());
            pars.Add(nameof(messages.body), messages.body.ToString());
            pars.Add(nameof(messages.reply), messages.reply.ToString());



            var dalResponse = await _db.ExecuteQuery("save_in_messages", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_messages_to_emp_id(messages messages)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(messages.msg_id), messages.msg_id.ToString());
            pars.Add(nameof(messages.to_emp_id), messages.to_emp_id.ToString());


            var dalResponse = await _db.ExecuteQuery("save_in_messages_to_emp_id", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> save_in_messages_files(messages messages)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(messages.msg_id), messages.msg_id.ToString());
            pars.Add(nameof(messages.files), messages.files.ToString());
            pars.Add(nameof(messages.type), messages.type.ToString());


            var dalResponse = await _db.ExecuteQuery("save_in_messages_files", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> get_message_with_to_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("to_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_message_with_to_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_messages_emails_to_emp_id_with_msg_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("msg_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_messages_emails_to_emp_id_with_msg_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_message_with_to_id_emails(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("to_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_message_with_to_id_emails", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_message_with_to_id_noti(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add("to_id", id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_message_with_to_id_noti", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
