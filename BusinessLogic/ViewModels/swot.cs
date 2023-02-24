using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class swot
    {
        public int ser { get; set; }
        public int dep_id { get; set; }
      
        
        public string dep_name { get; set; } = string.Empty;
        public string strength { get; set; } = string.Empty;
        public string weakness { get; set; } = string.Empty;
        public string chances { get; set; } = string.Empty;
        public string risks { get; set; } = string.Empty;

    }
}
