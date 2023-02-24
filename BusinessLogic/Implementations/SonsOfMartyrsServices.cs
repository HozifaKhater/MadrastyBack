using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;

namespace BusinessLogic.Implementations
{
    public class SonsOfMartyrsServices : ISonsOfMartyrsServices
    {
        private readonly IDatabaseContext _db;
        public SonsOfMartyrsServices(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveSonOfMartyrs(SonOfMartyrs student)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_sons_of_martyrs",
                _db.CreateListOfSqlParams(student, "add", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateSonOfMartyrs(SonOfMartyrs student)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_sons_of_martyrs",
               _db.CreateListOfSqlParams(student, "update", "id"));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteSonOfMartyrs(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SonOfMartyrs.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_sons_of_martyrs", pars);

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSonsOfMartyrs()
        {
            var dalResponse = await _db.ExecuteQuery("get_sons_of_martyrs");

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSonOfMartyrsById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SonOfMartyrs.id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_sons_of_martyrs_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
