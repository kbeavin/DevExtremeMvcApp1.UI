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
    
    public partial class manpowerprofile_CA_OT_rules
    {
        public string mpp_id { get; set; }
        public string mpp_updatedby { get; set; }
        public Nullable<System.DateTime> mpp_updatedon { get; set; }
        public Nullable<decimal> mpp_day15_ot_min { get; set; }
        public Nullable<decimal> mpp_day15_ot_max { get; set; }
        public Nullable<decimal> mpp_day6_ot_min { get; set; }
        public Nullable<decimal> mpp_day6_ot_max { get; set; }
        public Nullable<decimal> mpp_day7_ot_min { get; set; }
        public Nullable<decimal> mpp_day7_ot_max { get; set; }
        public Nullable<decimal> mpp_day16_dblt_min { get; set; }
        public Nullable<decimal> mpp_day7_dblt_min { get; set; }
        public Nullable<decimal> mpp_day15_rt_min { get; set; }
        public string mpp_OT_state { get; set; }
        public Nullable<double> mpp_OT_miles { get; set; }
        public int mpp_OTRules_ID { get; set; }
        public Nullable<int> mpp_SetDefaultForState { get; set; }
    
        public virtual manpowerprofile manpowerprofile { get; set; }
    }
}
