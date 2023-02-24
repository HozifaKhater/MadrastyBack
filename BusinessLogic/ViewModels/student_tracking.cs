using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class student_tracking
    {
        public int ser { get; set; }
        public int term_id { get; set; }
        public int subject_id { get; set; }
        public int level_id { get; set; }
        public int class_id { get; set; }
        public string date { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string behavior { get; set; } = string.Empty;
        public string book { get; set; } = string.Empty;
        public string practice { get; set; } = string.Empty;
    }
}
