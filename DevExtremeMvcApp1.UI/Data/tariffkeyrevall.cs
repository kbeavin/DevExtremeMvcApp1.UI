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
    
    public partial class tariffkeyrevall
    {
        public int tkr_id { get; set; }
        public string tkr_drop_stop { get; set; }
        public string tkr_pickup_stop { get; set; }
        public string tkr_split_first_segment_origin { get; set; }
        public string tkr_split_first_segment_dest { get; set; }
        public string tkr_ord_revtype1 { get; set; }
        public string tkr_ord_revtype2 { get; set; }
        public string tkr_ord_revtype3 { get; set; }
        public string tkr_ord_revtype4 { get; set; }
        public string tkr_eventcode { get; set; }
        public string tkr_event_loadstatus { get; set; }
        public int thr_id { get; set; }
        public System.DateTime tkr_created_date { get; set; }
        public string tkr_created_user { get; set; }
        public System.DateTime tkr_modified_date { get; set; }
        public string tkr_modified_user { get; set; }
        public Nullable<System.DateTime> tkr_startdate { get; set; }
        public Nullable<System.DateTime> tkr_enddate { get; set; }
    }
}