using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class payment_reciept
    {
        public int id { get; set; }
        public int serial_number { get; set; }
        public string title { get; set; } = string.Empty;
        public string date_of_reciept { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string school_name { get; set; } = string.Empty;
        public int center_number { get; set; }
        public int dinar_value { get; set; }
        public int fels_value { get; set; }
        public string client_name { get; set; } = string.Empty;
        public string total_in_arabic { get; set; } = string.Empty;
        public string cash_or_check { get; set; } = string.Empty;
        public string bank_name { get; set; } = string.Empty;
        public string details { get; set; } = string.Empty;
        public string identity_number { get; set; }
        public int emp_id { get; set; }

    }
}
