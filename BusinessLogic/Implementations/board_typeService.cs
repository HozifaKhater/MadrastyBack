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
    public class board_typeService : Iboard_typeService
    {
        private readonly IDatabaseContext _db;

        public board_typeService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_board_type()
        {
            var dalResponse = await _db.ExecuteQuery("get_board_type");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_board_type_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(board_type.board_type_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_board_type_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_board_type(board_type board_type)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_board_type",
                _db.CreateListOfSqlParams(board_type, "add", "board_type_id"));

            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_board_type(board_type board_type)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_board_type",
                _db.CreateListOfSqlParams(board_type, "update", "board_type_id"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_board_type(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(board_type.board_type_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_board_type", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
