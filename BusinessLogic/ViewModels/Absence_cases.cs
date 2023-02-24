using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Absence_cases
    {
        public int absence_cases_id { get; set; }
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
        public string self_reasons { get; set; } = string.Empty;
        public List<absence_cases_details> absence_cases_details { get; set; } = new List<absence_cases_details>();
    }
    public class absence_cases_details
    {
        public int absence_details_id { get; set; }
        public int absence_cases_id { get; set; }
        public string other_situations { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string effort_results { get; set; } = string.Empty;
        public string end_year_state { get; set; } = string.Empty;
    }
    public class absence_student
    {
        public int ser { get; set; }
        public int _7essa_id { get; set; }
        public int student_id { get; set; }
        public int flag { get; set; }
        public string reason { get; set; } = string.Empty;
    }
    }
