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
    public class signalir_connectionsService : Isignalir_connectionsService
    {
        private readonly IDatabaseContext _db;

        public signalir_connectionsService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> save_in_signalir_connections(string connection)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(signalir_connections.connection_id),  connection.ToString());
            var dalResponse = await _db.ExecuteQuery("save_in_signalir_connections", pars);
            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> delete_from_signalir_connections(string connection)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(signalir_connections.connection_id),  connection.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_signalir_connections", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> get_signalir_connections()
        {
            var dalResponse = await _db.ExecuteQuery("get_signalir_connections");
            return new ServiceResponse(dalResponse);
        }
    }
}
