using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ta7dier_master
    {
        public int ta7dier_id { get; set; }
        public int emp_id { get; set; }
        public string? emp_name { get; set; } = string.Empty;
        public int subject_id { get; set; }
        public string? subject_name { get; set; } = string.Empty;
        public int grade_id { get; set; }
        public string? grade_name { get; set; } = string.Empty;
        public string? ta7dier_date { get; set; } = string.Empty;
        public int ta7dier_week { get; set; }
        public int ta7dier_day { get; set; }
        public int ta7dier_state_id { get; set; }
        public string? state_name { get; set; } = string.Empty;
        public string? ta7dier_name { get; set; } = string.Empty;
        public string? ta7dier_body { get; set; } = string.Empty;
        public string? ta7dier_notes { get; set; } = string.Empty;
        public int ta7dier_supervision_state_id { get; set; }
        public string? ta7dier_supervision_state_name { get; set; } = string.Empty;
        public string? ta7dier_state_name { get; set; } = string.Empty;
        public string? ta7dier_file { get; set; } = string.Empty;
    }
}
