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
    
    public partial class stops_billtomiles
    {
        public int sbtm_id { get; set; }
        public Nullable<int> stp_number { get; set; }
        public Nullable<int> billto_miles_mt_identity { get; set; }
        public int billto_miles_ord_hdrnumber { get; set; }
        public int billto_miles { get; set; }
        public System.DateTime sbtm_createdate { get; set; }
        public string sbtm_createby { get; set; }
        public Nullable<System.DateTime> sbtm_lastupdate { get; set; }
        public string sbtm_lastupdateby { get; set; }
        public Nullable<decimal> sbtm_tolls { get; set; }
        public Nullable<int> sbtm_tolls_mt_identity { get; set; }
    }
}
