using  System.Data;
using  System.Dynamic;

namespace BusinessLogic.Responses
{
    public class ServiceResponse
    {
        public bool State { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<object> Data { get; set; }
        public ServiceResponse()
        {
            State = false;
            ErrorMessage = "Validation Error";
            Data = new List<object>();
        }
        public ServiceResponse(string error)
        {
            State = false;
            Data = new List<object>();
            ErrorMessage = error;
        } 
        
        public ServiceResponse(List<string> errors)
        {
            State = false;
            Data = new List<object>();
            ErrorMessages = errors;
        }

        public ServiceResponse(DALResponse response)
        {
            State = response.State;
            ErrorMessage = response.ErrorMessage;

            if (response.State)
            {
                Data = ConvertDataTable(response.Data);
            }
            //Data = JsonConvert.SerializeObject(response.Data);
            else
                Data = new List<object>();
        }

        private List<object> ConvertDataTable(DataTable dt)
        {
            List<object> data = new List<object>();
            foreach (DataRow row in dt.Rows)
            {
                object item = GetItem(row);
                data.Add(item);
            }
            return data;
        }
        private object GetItem(DataRow dr)
        {
            var temp = new ExpandoObject() as IDictionary<string, Object>;
            
            foreach (DataColumn column in dr.Table.Columns)
            {
                var colName = column.ColumnName;
                temp.Add(colName, dr[column.ColumnName].ToString() ?? "");
            }
            return temp;
        }
    }
}
