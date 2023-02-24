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
    public class EventsService : IEventsService
    {
        private readonly IDatabaseContext _db;
        public EventsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_events()
        {
            var dalResponse = await _db.ExecuteQuery("get_events");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_events_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Events.event_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_events_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_events(Events events)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(events.dep_id), events.dep_id.ToString());
            pars.Add(nameof(events.dep_name), events.dep_name);
            pars.Add(nameof(events.event_loc), events.event_loc);
            pars.Add(nameof(events.event_date), events.event_date);
            pars.Add(nameof(events.event_name), events.event_name);
            pars.Add(nameof(events.event_site), events.event_site);
            pars.Add(nameof(events.event_invitees), events.event_invitees);
            pars.Add(nameof(events.event_objectives), events.event_objectives);
            pars.Add(nameof(events.event_desc), events.event_desc);
            pars.Add(nameof(events.event_time), events.event_time);

            var dalResponse = await _db.ExecuteQuery("save_in_events", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_events(Events events)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(events.event_id), events.event_id.ToString());
            pars.Add(nameof(events.dep_id), events.dep_id.ToString());
            pars.Add(nameof(events.dep_name), events.dep_name);
            pars.Add(nameof(events.event_loc), events.event_loc);
            pars.Add(nameof(events.event_date), events.event_date);
            pars.Add(nameof(events.event_name), events.event_name);
            pars.Add(nameof(events.event_site), events.event_site);
            pars.Add(nameof(events.event_invitees), events.event_invitees);
            pars.Add(nameof(events.event_objectives), events.event_objectives);
            pars.Add(nameof(events.event_desc), events.event_desc);
            pars.Add(nameof(events.event_time), events.event_time);

            var dalResponse = await _db.ExecuteQuery("update_events", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_events(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Events.event_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_events", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
