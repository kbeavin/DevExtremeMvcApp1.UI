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
    
    public partial class stops_eta
    {
        public int stp_number { get; set; }
        public int lgh_number { get; set; }
        public int ste_seconds_out { get; set; }
        public decimal ste_miles_out { get; set; }
        public System.DateTime ste_updated { get; set; }
        public int ckc_number { get; set; }
        public Nullable<System.DateTime> ste_original_earliest { get; set; }
        public Nullable<System.DateTime> ste_original_arrival { get; set; }
        public Nullable<System.DateTime> ste_original_departure { get; set; }
        public Nullable<System.DateTime> ste_updated_earliest { get; set; }
        public Nullable<System.DateTime> ste_updated_arrival { get; set; }
        public Nullable<System.DateTime> ste_updated_departure { get; set; }
        public Nullable<byte> ste_message_count { get; set; }
        public Nullable<System.DateTime> ste_original_latest { get; set; }
        public Nullable<System.DateTime> ste_updated_latest { get; set; }
    }
}
