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
    public class meeting_typeService : Imeeting_typeService
    {
        private readonly IDatabaseContext _db;

        public meeting_typeService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_meeting_type()
        {
            var dalResponse = await _db.ExecuteQuery("get_meeting_type");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_meeting_type_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(meeting_type.meeting_type_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_meeting_type_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_meeting_type(meeting_type meeting_type)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_meeting_type", _db.CreateListOfSqlParams(meeting_type, "add","meeting_type_id"));
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_meeting_type(meeting_type meeting_type)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_meeting_type", _db.CreateListOfSqlParams(meeting_type, "update", "meeting_type_id"));
            return new ServiceResponse(dalResponse);


        }

        public async Task<ServiceResponse> delete_from_meeting_type(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(meeting_type.meeting_type_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_meeting_type", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
