//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExtremeMvcApp1_UI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class opt_eta_pta_hos_segments
    {
        public long id { get; set; }
        public Nullable<System.DateTime> begin_segment_time { get; set; }
        public string driver_id { get; set; }
        public Nullable<decimal> duration_in_hours { get; set; }
        public Nullable<System.DateTime> end_of_last_break { get; set; }
        public Nullable<System.DateTime> end_of_last_reset { get; set; }
        public Nullable<System.DateTime> end_segment_time { get; set; }
        public Nullable<decimal> hours_driven_since_last_break { get; set; }
        public Nullable<decimal> hours_driver_since_last_reset { get; set; }
        public Nullable<decimal> hours_remaining_on_day_drive { get; set; }
        public Nullable<decimal> hours_remaining_on_day_duty { get; set; }
        public Nullable<decimal> hours_remaining_on_week { get; set; }
        public string rule_set { get; set; }
        public string segment_id { get; set; }
        public Nullable<int> stop_id { get; set; }
        public string truck_id { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public Nullable<decimal> weekly_hrs_worked_since_last_break_or_reset { get; set; }
        public string work_status { get; set; }
    }
}
