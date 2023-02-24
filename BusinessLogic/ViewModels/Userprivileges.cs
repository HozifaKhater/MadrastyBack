using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Userprivileges
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string emp_name { get; set; } = string.Empty;
        [Required]
        public int emp_id { get; set; }

        [Required]
        public string menu_route { get; set; } = string.Empty;
        [Required]
        public int menu_id { get; set; }
        [Required]
        public int read { get; set; }
        [Required]
        public int write { get; set; }
        [Required]
        public int read_and_write { get; set; }

        [Required]
        public string user_menu_name { get; set; } = string.Empty;

        [Required]
        public int user_id { get; set; }
        [Required]
        public string priv_name { get; set; } = string.Empty;
        [Required]
        public string page_name { get; set; } = string.Empty;
        [Required]
        public int in_class_priv { get; set; }
        [Required]
        public int dep_work { get; set; }
        [Required]
        public int job_id { get; set; }

    }
}
