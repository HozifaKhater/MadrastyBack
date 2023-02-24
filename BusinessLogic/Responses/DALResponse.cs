using  System.Data;

namespace BusinessLogic.Responses
{
    public class DALResponse
    {
        public bool State { get; set; }
        public string ErrorMessage { get; set; }
        public DataTable Data { get; set; }
        public DALResponse(DataTable data)
        {
            State = true;
            Data = data;
            ErrorMessage = "";
        }

        public DALResponse(string error)
        {
            State = false;
            Data = new DataTable();
            ErrorMessage = error;
        }
    }
}
