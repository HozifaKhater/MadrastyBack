using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class IndividualCases
    {
        public int id { get; set; }
        public int level_id { get; set; }
        public string level_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public int def_id { get; set; }
        public string s_code { get; set; } = string.Empty;
        public string case_type { get; set; } = string.Empty;
        public string date_of_file_opening { get; set; } = string.Empty;
        public string transfer_procedures { get; set; } = string.Empty;
        public string results { get; set; } = string.Empty;
    }
}
