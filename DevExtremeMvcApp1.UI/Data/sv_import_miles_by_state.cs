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
    
    public partial class sv_import_miles_by_state
    {
        public int imp_id { get; set; }
        public string dist_center { get; set; }
        public string driver_id { get; set; }
        public string unload_id { get; set; }
        public Nullable<System.DateTime> segment_start_date { get; set; }
        public Nullable<System.DateTime> segment_end_date { get; set; }
        public Nullable<System.DateTime> trip_date { get; set; }
        public string tractor_id { get; set; }
        public string trip_num { get; set; }
        public string state_code { get; set; }
        public Nullable<decimal> odometer { get; set; }
        public Nullable<decimal> tot_distance { get; set; }
        public Nullable<decimal> laden_distance { get; set; }
        public Nullable<decimal> fuel_used { get; set; }
        public string toll { get; set; }
        public Nullable<decimal> weight { get; set; }
        public string road { get; set; }
        public string source_id { get; set; }
    }
}