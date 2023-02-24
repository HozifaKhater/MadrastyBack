using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class work_plan
    {
        public string ser { get; set; } = string.Empty;
        public string work_plan_name { get; set; } = string.Empty;
        public string work_plan_id { get; set; } = string.Empty;
        public string program { get; set; } = string.Empty;
        public string fulfilment_date { get; set; } = string.Empty;
        public string result { get; set; } = string.Empty;
        public string non_fulfilment_reason { get; set; } = string.Empty;
        public string notes { get; set; } = string.Empty;

    }
}
