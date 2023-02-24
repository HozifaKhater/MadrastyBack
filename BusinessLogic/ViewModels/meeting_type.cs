using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class meeting_type
    {
        public int meeting_type_id { get; set; } 
        public string? meeting_type_name { get; set; } 
        public int is_meeting_date { get; set; }
        public string? meeting_date { get; set; }
        public int is_group_name { get; set; }
        public string? group_name { get; set; }
        public int is_start_time { get; set; }
        public string? start_time_label { get; set; }
        public int is_end_time { get; set; }
        public string? end_time_label { get; set; }
        public int is_group_number { get; set; }
        public string? group_number_label { get; set; }
        public int is_meeting_mem_no { get; set; }
        public string? meeting_mem_no_label { get; set; }
        public int is_meeting_loc { get; set; }
        public string? meeting_loc_label { get; set; }
        public int is_work_plan { get; set; }
        public string? work_plan_label { get; set; }
        public int is_recommendation { get; set; }
        public string? recommendation_label { get; set; }
        public int is_dep { get; set; }
        public string? dep_label { get; set; }
        public int is_subject { get; set; }
        public string? subject_label { get; set; }
        public int is_abscence { get; set; }
        public string? abscence_label { get; set; }
        public int is_course { get; set; }
        public string? course_label { get; set; }
        public int is_content { get; set; }
        public string? content_label { get; set; }

    }
}
