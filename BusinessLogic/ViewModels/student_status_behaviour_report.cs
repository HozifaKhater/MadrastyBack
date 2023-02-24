using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class student_status_behaviour_report
    {
        public string id { get; set; } = string.Empty;
        public string lev_id { get; set; } = string.Empty;
        public string class_id { get; set; } = string.Empty;
        public string student_id { get; set; } = string.Empty;
        public string report { get; set; } = string.Empty;
        public string head_dep_opinion { get; set; } = string.Empty;
        public string supervisor_opinion { get; set; } = string.Empty;
        public string social_worker_opinion { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;

    }
}
