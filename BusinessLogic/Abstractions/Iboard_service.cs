using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Iboard_service
    {
        Task<ServiceResponse> get_board();
        Task<ServiceResponse> get_board_with_id(int id);
        Task<ServiceResponse> save_in_board(board board);
        Task<ServiceResponse> update_board(board board);
        Task<ServiceResponse> delete_from_board(int id);
    }
}
