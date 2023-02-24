using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class calling_parents
    {
        public int ser { get; set; } 
        public string date { get; set; } = string.Empty;
        public string lev_name { get; set; } = string.Empty;
        public int lev_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string meeting_date { get; set; } = string.Empty;
        public string student_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string meeting_side_name { get; set; } = string.Empty;
        public int meeting_side_id { get; set; }

    }
}
