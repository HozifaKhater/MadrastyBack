using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Daily_absence_stat
    {
        public int absence_stat_id { get; set; }
        [Required(ErrorMessage = "ادخل الصف")]
        public int lev_id { get; set; }
        public string lev_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "ادخل الشعبه")]
        public string tch3eb { get; set; } = string.Empty;
        public int total_num { get; set; }
        public int attendance_num { get; set; }
        public int absence_num { get; set; }
        public int stu_att_score { get; set; }
        public int teach_total_num { get; set; }
        public int teach_attend { get; set; }
        public int teach_absence { get; set; }
        public int teach_att_score { get; set; }
        public int tch3eb_id { get; set; }

    }
}
