using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class definition
    {
       
        public int def_id { get; set; }
 
        public string def_name { get; set; } = string.Empty;
        public string s_code { get; set; } = string.Empty;
        public string s_code_arabic { get; set; } = string.Empty;
    }
}
