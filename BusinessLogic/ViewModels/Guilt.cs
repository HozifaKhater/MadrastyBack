using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Guilt
    {
        public int id { get; set; }
        public string guilt { get; set; } = string.Empty;
        public string date_of_guilt { get; set; } = string.Empty;
        public string details_of_guilt { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;

    }
}
