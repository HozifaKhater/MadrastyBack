using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Student_transfer
    {
        public int student_trans_id { get; set; }
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
        public string student_branch { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل المنطقه التعليميه")]
        public string educational_area { get; set; } = string.Empty;
        public string school_trans { get; set; } = string.Empty;
        public int new_branch { get; set; }
        public string trans_date { get; set; } = string.Empty;
        public int student_branch_id { get; set; }
        public int educational_area_id { get; set; }
        public int school_trans_id { get; set; }
    }
}
