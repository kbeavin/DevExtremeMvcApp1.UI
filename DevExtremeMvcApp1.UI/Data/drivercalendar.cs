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
    
    public partial class drivercalendar
    {
        public int drc_id { get; set; }
        public string mpp_id { get; set; }
        public int drc_sequence { get; set; }
        public Nullable<System.DateTime> drc_week { get; set; }
        public Nullable<int> drc_week1_dow { get; set; }
        public Nullable<System.DateTime> drc_week1_starttime { get; set; }
        public Nullable<decimal> drc_week1_hours { get; set; }
        public string drc_week1_type { get; set; }
        public Nullable<int> drc_week2_dow { get; set; }
        public Nullable<System.DateTime> drc_week2_starttime { get; set; }
        public Nullable<decimal> drc_week2_hours { get; set; }
        public string drc_week2_type { get; set; }
        public Nullable<int> drc_bid_dow { get; set; }
        public Nullable<System.DateTime> drc_bid_starttime { get; set; }
        public Nullable<decimal> drc_bid_hours { get; set; }
        public string drc_bid_type { get; set; }
        public string drc_week1_store { get; set; }
        public string drc_week1_route { get; set; }
        public string drc_week2_store { get; set; }
        public string drc_week2_route { get; set; }
        public string drc_bid_store { get; set; }
        public string drc_bid_route { get; set; }
    }
}
