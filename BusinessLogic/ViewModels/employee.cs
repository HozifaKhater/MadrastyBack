using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class employee
    {
        public int job_id { get; set; }
        public int dep_id { get; set; }
        public string dep_name { get; set; } = string.Empty;
        public int emp_id { get; set; }
        public string emp_civilian_id { get; set; } = string.Empty;
        public string emp_sex { get; set; } = string.Empty; 
        public int emp_sex_id { get; set; }
        public string emp_name { get; set; } = string.Empty;
        public string emp_nationality { get; set; } = string.Empty;
        public int emp_nationality_id { get; set; }
        public string emp_marital_status { get; set; } = string.Empty;
        public int emp_marital_status_id { get; set; }
        public int emp_file_ser { get; set; }
        public string emp_dob { get; set; } = string.Empty;
        public int emp_age_year { get; set; }
        public int emp_age_month { get; set; }
        public int emp_age_day { get; set; }
        public string emp_pos_type { get; set; } = string.Empty;
        public int emp_pos_type_id { get; set; }
        public string emp_pos { get; set; } = string.Empty;
        public int emp_pos_id { get; set; }
        public string emp_dep { get; set; } = string.Empty;
        public int emp_dep_id { get; set; }
        public string emp_subject { get; set; } = string.Empty;
        public int emp_subject_id { get; set; }
        public string emp_div { get; set; } = string.Empty;
        public int emp_div_id { get; set; }
        public string emp_contract { get; set; } = string.Empty;
        public int emp_contract_id { get; set; }
        public string emp_employment_date { get; set; } = string.Empty;
        public string emp_educationa_qualification { get; set; } = string.Empty;
        public int emp_educationa_qualification_id { get; set; }
        public string emp_educationa_qualification_date { get; set; } = string.Empty;
        public string emp_educationa_qualification_country { get; set; } = string.Empty;
        public int emp_educationa_qualification_country_id { get; set; }
        public int emp_exp_out_country { get; set; }
        public int emp_exp_in_country_same_grade { get; set; }
        public int emp_exp_in_country_another_grade { get; set; }
        public int emp_exp_in_country_same_school { get; set; }
        public string emp_address { get; set; } = string.Empty;
        public string emp_email { get; set; } = string.Empty;
        public string emp_mob { get; set; } = string.Empty;
        public string emp_mob1 { get; set; } = string.Empty;
        public string emp_tel { get; set; } = string.Empty;
        public string emp_username { get; set; } = string.Empty;
        public string emp_password { get; set; } = string.Empty;
        public int in_class_priv { get; set; }
        public int dep_work { get; set; }
        public int school_id { get; set; }
    }
}
