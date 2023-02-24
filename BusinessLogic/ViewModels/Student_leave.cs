using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Student_leave
    {
        public int leav_stu_id { get; set; }
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل اسم الطالب")]
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل الرقم المدنى")]
        public string student_civilian_id { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل الشعبه")]
        public int student_branch_id { get; set; }
        public string student_branch { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل سبب الترك")]
        public int leave_reason_id { get; set; }
        public string leave_reason { get; set; } = string.Empty;
        public string leave_date { get; set; } = string.Empty;

    }
}
