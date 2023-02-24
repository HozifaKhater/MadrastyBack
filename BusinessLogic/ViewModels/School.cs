using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class School
    {
        public int school_id { get; set; }
        public string school_man { get; set; } = string.Empty;
        public string school_assis1 { get; set; } = string.Empty;
        public string school_assis2 { get; set; } = string.Empty;
        public string school_assis3 { get; set; } = string.Empty;
        public string school_assis4 { get; set; } = string.Empty;
        public string school_bdala { get; set; } = string.Empty;
        public string school_faks { get; set; } = string.Empty;
        public string school_addr { get; set; } = string.Empty;
        public string school_dir { get; set; } = string.Empty;
        public string school_logo { get; set; } = string.Empty;
        public string school_name { get; set; } = string.Empty;
        public int school_assis1_id { get; set; } 
        public int school_assis2_id { get; set; } 
        public int school_assis3_id { get; set; } 
        public int school_assis4_id { get; set; }
        public int school_man_id { get; set; }
    }
}
