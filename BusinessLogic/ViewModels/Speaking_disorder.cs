using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Speaking_disorder
    {
        public int speech_dis_id { get; set; }
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public int nationality_id { get; set; }
        public string nationality_name { get; set; } = string.Empty;
        public string phone_no { get; set; } = string.Empty;
        public string birth_date { get; set; } = string.Empty;
        public string work_start_date { get; set; } = string.Empty;
        public string behavioral_notes { get; set; } = string.Empty;
        public string dis_type { get; set; } = string.Empty;
        public List<speaking_details_first> speaking_details_first { get; set; } = new List<speaking_details_first>();
        public List<speaking_details_second> speaking_details_second { get; set; } = new List<speaking_details_second>();
    }

    public class speaking_details_first
    {
        public int speaking_details_id { get; set; }
        public int speech_dis_id { get; set; }
        public string other_situations { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string effort_results { get; set; } = string.Empty;
        public string end_year_state { get; set; } = string.Empty;
    }
    public class speaking_details_second
    {
        public int psychol_visit_id { get; set; }
        public int speech_dis_id { get; set; }
        public string visit_date { get; set; } = string.Empty;
        public string visit_results { get; set; } = string.Empty;

    }
}
