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
    
    public partial class edi_856_shipment_notice
    {
        public int esn_identity { get; set; }
        public string esn_tpid { get; set; }
        public string esn_mb { get; set; }
        public string esn_bm { get; set; }
        public string esn_po { get; set; }
        public string esn_cr { get; set; }
        public Nullable<int> esn_tmw { get; set; }
        public Nullable<System.DateTime> esn_856_tendered { get; set; }
        public Nullable<System.DateTime> esn_856_imported { get; set; }
        public Nullable<System.DateTime> esn_214_received { get; set; }
        public Nullable<System.DateTime> esn_214_warehoused { get; set; }
        public Nullable<System.DateTime> esn_214_delivered { get; set; }
        public string esn_skip_trigger { get; set; }
        public Nullable<System.DateTime> esn_214_loaded { get; set; }
        public string esn_grouping { get; set; }
    }
}
