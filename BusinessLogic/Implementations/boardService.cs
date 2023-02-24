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
    public class boardService : Iboard_service
    {
        private readonly IDatabaseContext _db;

        public boardService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> get_board()
        {
            var dalResponse = await _db.ExecuteQuery("get_board");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> get_board_with_id(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(board.board_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("get_board_with_id", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> save_in_board(board board)
        {
            var dalResponse = await _db.ExecuteNonQuery("save_in_board",
                _db.CreateListOfSqlParams(board, "add", "board_id"));

            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> update_board(board board)
        {
            var dalResponse = await _db.ExecuteNonQuery("update_board",
                _db.CreateListOfSqlParams(board, "update", "board_id"));

            return new ServiceResponse(dalResponse);

        }

        public async Task<ServiceResponse> delete_from_board(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(board.board_id), id.ToString());
            var dalResponse = await _db.ExecuteQuery("delete_from_board", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
