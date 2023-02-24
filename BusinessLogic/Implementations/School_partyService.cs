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
    public class School_partyService : ISchool_partyService
    {
        private readonly IDatabaseContext _db;
        public School_partyService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> get_school_party()
        {
            var dalResponse = await _db.ExecuteQuery("get_school_party");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_school_party_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(School_party.sch_party_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_school_party_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_school_party(School_party school_party)
        {
            var pars = new Dictionary<string, string>();

            pars.Add(nameof(school_party.dep_id), school_party.dep_id.ToString());
            pars.Add(nameof(school_party.dep_name), school_party.dep_name);
            pars.Add(nameof(school_party.party_occ), school_party.party_occ);
            pars.Add(nameof(school_party.party_date), school_party.party_date);
            pars.Add(nameof(school_party.party_duration), school_party.party_duration.ToString());
            pars.Add(nameof(school_party.party_loc), school_party.party_loc);
            pars.Add(nameof(school_party.party_sponsor), school_party.party_sponsor);
            pars.Add(nameof(school_party.party_invitees), school_party.party_invitees);
            pars.Add(nameof(school_party.external_part), school_party.external_part);
            pars.Add(nameof(school_party.party_desc), school_party.party_desc);

            var dalResponse = await _db.ExecuteQuery("save_in_school_party", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_school_party(School_party school_party)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(school_party.sch_party_id), school_party.sch_party_id.ToString());
            pars.Add(nameof(school_party.dep_id), school_party.dep_id.ToString());
            pars.Add(nameof(school_party.dep_name), school_party.dep_name);
            pars.Add(nameof(school_party.party_occ), school_party.party_occ);
            pars.Add(nameof(school_party.party_date), school_party.party_date);
            pars.Add(nameof(school_party.party_duration), school_party.party_duration.ToString());
            pars.Add(nameof(school_party.party_loc), school_party.party_loc);
            pars.Add(nameof(school_party.party_sponsor), school_party.party_sponsor);
            pars.Add(nameof(school_party.party_invitees), school_party.party_invitees);
            pars.Add(nameof(school_party.external_part), school_party.external_part);
            pars.Add(nameof(school_party.party_desc), school_party.party_desc);

            var dalResponse = await _db.ExecuteQuery("update_school_party", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_school_party(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(School_party.sch_party_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_school_party", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
