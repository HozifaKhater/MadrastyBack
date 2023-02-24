using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class violation_record
    {
        public int viol_id { get; set; }
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        public int class_id { get; set; } 
        public string class_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل اسم الطالب")]
        public int student_id { get; set; } 
        public string student_name { get; set; } = string.Empty;
        public string viol_date { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل المخالفه")]
        public int violation_id { get; set; } 
        public string violation_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل الاجراء المتبع")]
        public int procedure_id { get; set; }
        public string procedure_name { get; set; } = string.Empty;
    }
}
