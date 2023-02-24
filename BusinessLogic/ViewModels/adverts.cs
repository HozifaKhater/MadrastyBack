using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class adverts
    {
        public int ser { get; set; }
        public string title { get; set; } = string.Empty;
        public string body { get; set; } = string.Empty;
        public int from_emp_id { get; set; }    
     
        public string start_date { get; set; } = string.Empty;
        public string end_date { get; set; } = string.Empty;
        public int is_public { get; set; }
        public int dep_id { get; set; }

    }
}
