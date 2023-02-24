using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Supervisor_opinion
    {
        public int supervisor_opin_id { get; set; }
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public string super_opin_date { get; set; } = string.Empty;
        public string behave_stat_rep { get; set; } = string.Empty;
        public string dep_mang_opin { get; set; } = string.Empty;
        public string supervisor_opin { get; set; } = string.Empty;
    }
}
