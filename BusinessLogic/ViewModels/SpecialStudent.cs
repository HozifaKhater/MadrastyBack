using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SpecialStudent
    {
        public int id { get; set; }
        public int level_id { get; set; }
        public string level_name { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int sub_dep_id { get; set; }
        public string sub_dep_name { get; set; } = string.Empty;
        public string excellence_manifestations { get; set; } = string.Empty;
        public string suggested_development { get; set; } = string.Empty;
        public string result { get; set; } = string.Empty;


    }
}
