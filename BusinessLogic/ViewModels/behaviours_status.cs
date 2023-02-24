using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class behaviours_status
    {
        public string id { get; set; } = string.Empty;
        public string status_type { get; set; } = string.Empty;
        public string notes { get; set; } = string.Empty;
        public string reasons { get; set; } = string.Empty;
        public string lev_id { get; set; } = string.Empty;
        public string class_id { get; set; } = string.Empty;
        public string student_id { get; set; } = string.Empty;


    }
    public class behaviours_status_details
    {
        public string ser { get; set; } = string.Empty;
        public string behaviour_status_id { get; set; } = string.Empty;
        public string student_id { get; set; } = string.Empty;
        public string another_situations { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string efforts { get; set; } = string.Empty;
        public string end_year_situation { get; set; } = string.Empty;



    }
}
