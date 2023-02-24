using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ImessagesService
    {
        Task<ServiceResponse> save_in_messages(messages messages);
        Task<ServiceResponse> save_in_messages_to_emp_id(messages messages);
        Task<ServiceResponse> get_inbox(int id);
        Task<ServiceResponse> get_message_with_id(int id);
        Task<ServiceResponse> save_in_messages_files(messages messages);
        Task<ServiceResponse> get_message_with_to_id(int id);
        Task<ServiceResponse> get_messages_emails_to_emp_id_with_msg_id(int id);
        Task<ServiceResponse> get_message_with_to_id_emails(int id);
        Task<ServiceResponse> get_message_with_to_id_noti(int id);
    }
}
