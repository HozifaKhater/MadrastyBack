using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class _7sa_def
    {
        public int ser { get; set; }
        [Required(ErrorMessage = "")]
        public string start_time { get; set; } = string.Empty;
        public string end_time { get; set; } = string.Empty;
      

    }
}
