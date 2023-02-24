using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class School_party
    {
       
        public int sch_party_id { get; set; }
        [Required(ErrorMessage = "ادخل القسم المسؤول")]
        public int dep_id { get; set; } 
        
        public string dep_name { get; set; } = string.Empty;

        [Required(ErrorMessage = "ادخل مناسبه الحفله")]
        public string party_occ { get; set; } = string.Empty;

        [Required(ErrorMessage = "ادخل تاريخ الحفله")]
        public string party_date { get; set; } = string.Empty;
     
        public int party_duration { get; set; }
        [Required(ErrorMessage = "ادخل مقر الحفله")]
        public string party_loc { get; set; } = string.Empty;
    
        public string party_sponsor { get; set; } = string.Empty;

   
        public string party_invitees { get; set; } = string.Empty;

 
        public string external_part { get; set; } = string.Empty;
  
        public string party_desc { get; set; } = string.Empty;
    }
}
