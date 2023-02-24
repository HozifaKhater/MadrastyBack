using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class messages
    {
        public string msg_id { get; set; } = string.Empty;
        public int from_emp_id { get; set; } 
        public string title { get; set; } = string.Empty;
        public string body { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string time { get; set; } = string.Empty;
        public int reply { get; set; }
        public int to_emp_id { get; set; }
        public string files { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string route { get; set; } = string.Empty;
        public int object_id { get; set; }

    }
}
