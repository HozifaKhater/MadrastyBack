using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISpeaking_disorderService
    {
        Task<ServiceResponse> delete_from_speaking_disorder(int id);
        Task<ServiceResponse> delete_from_speaking_details_first(int id);
        Task<ServiceResponse> delete_from_speaking_details_second(int id);
        Task<ServiceResponse> delete_from_speaking_details_first_with_speech_dis_id(int id);
        Task<ServiceResponse> delete_from_speaking_details_second_with_speech_dis_id(int id);
        Task<ServiceResponse> get_speaking_disorder();
        Task<ServiceResponse> get_speaking_details_first();
        Task<ServiceResponse> get_speaking_details_second();
        Task<ServiceResponse> get_speaking_details_first_with_speech_dis_id(int id);
        Task<ServiceResponse> get_speaking_details_second_with_speech_dis_id(int id);
        Task<ServiceResponse> get_speaking_details_first_with_id(int id);
        Task<ServiceResponse> get_speaking_details_second_with_id(int id);
        Task<ServiceResponse> get_speaking_disorder_with_id(int id);
        Task<ServiceResponse> save_in_speaking_disorder(Speaking_disorder speaking_disorder);
        Task<ServiceResponse> save_in_speaking_details_first(speaking_details_first speaking_disorder);
        Task<ServiceResponse> save_in_speaking_details_second(speaking_details_second speaking_disorder);
        Task<ServiceResponse> update_speaking_disorder(Speaking_disorder speaking_disorder);
        Task<ServiceResponse> update_speaking_details_first(speaking_details_first speaking_disorder);
        Task<ServiceResponse> update_speaking_details_second(speaking_details_second speaking_disorder);
    }
}
