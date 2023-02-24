using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface Iboard_typeService
    {
        Task<ServiceResponse> get_board_type();
        Task<ServiceResponse> get_board_type_with_id(int id);
        Task<ServiceResponse> save_in_board_type(board_type board_type);
        Task<ServiceResponse> update_board_type(board_type board_type);
        Task<ServiceResponse> delete_from_board_type(int id);
    }
}
