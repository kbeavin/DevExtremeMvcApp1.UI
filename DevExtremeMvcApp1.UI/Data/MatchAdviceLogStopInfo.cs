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
    
    public partial class MatchAdviceLogStopInfo
    {
        public int malsi_id { get; set; }
        public int mal_id { get; set; }
        public int stp_number { get; set; }
        public Nullable<System.DateTime> ts_arrival { get; set; }
        public Nullable<System.DateTime> ts_departure { get; set; }
        public Nullable<System.DateTime> ts_earliest { get; set; }
        public Nullable<System.DateTime> ts_latest { get; set; }
        public Nullable<System.DateTime> ma_arrival { get; set; }
        public Nullable<System.DateTime> ma_departure { get; set; }
        public Nullable<System.DateTime> ma_earliest { get; set; }
        public Nullable<System.DateTime> ma_latest { get; set; }
        public string malsi_updateby { get; set; }
        public System.DateTime malsi_updatedate { get; set; }
        public Nullable<double> ts_miles { get; set; }
        public Nullable<double> ma_miles { get; set; }
        public string stp_event { get; set; }
        public string cmp_id { get; set; }
    }
}
