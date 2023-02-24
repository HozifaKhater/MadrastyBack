using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class teacher_opinion_visit
    {
        public int ser { get; set; }
        public int takeem_id { get; set; }
        public int emp_id { get; set; }
        public int is_agree { get; set; }
        public string notes { get; set; } = string.Empty;
    }
}
