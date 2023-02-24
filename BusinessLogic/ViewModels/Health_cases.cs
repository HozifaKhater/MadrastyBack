using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Health_cases
    {
        public int health_id { get; set; }
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public int nationality_id { get; set; } 
        public string nationality { get; set; } = string.Empty;
        public string phone_no { get; set; } = string.Empty; 
        public string birth_date { get; set; } = string.Empty;
        public string work_start_date { get; set; } = string.Empty;
        public string dis_status { get; set; } = string.Empty;
        public string health_recomm { get; set; } = string.Empty;
        public string year_end_state { get; set; } = string.Empty;
        public List<health_cases_details> health_cases_details { get; set; } = new List<health_cases_details>();
    }

    public class health_cases_details
    {
        public int health_det_id { get; set; }
        public int health_id { get; set; }
        public string other_situations { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string effort_results { get; set; } = string.Empty;
        public string end_year_state { get; set; } = string.Empty;
    }

}
