using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Events
    {
        public int event_id { get; set; }

        public int dep_id { get; set; }

        public string dep_name { get; set; } = string.Empty;


        public string event_loc { get; set; } = string.Empty;

        public string event_date { get; set; } = string.Empty;

        public string event_name { get; set; } = string.Empty;

        public string event_site { get; set; } = string.Empty;

        public string event_invitees { get; set; } = string.Empty;


        public string event_objectives { get; set; } = string.Empty;


        public string event_desc { get; set; } = string.Empty;

        public string event_time { get; set; } = string.Empty;
    }
}
