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
    
    public partial class partorder_header
    {
        public int poh_identity { get; set; }
        public string poh_branch { get; set; }
        public string poh_supplier { get; set; }
        public string poh_plant { get; set; }
        public string poh_dock { get; set; }
        public Nullable<int> poh_jittime { get; set; }
        public Nullable<int> poh_sequence { get; set; }
        public string poh_reftype { get; set; }
        public string poh_refnum { get; set; }
        public System.DateTime poh_datereceived { get; set; }
        public Nullable<System.DateTime> poh_pickupdate { get; set; }
        public Nullable<System.DateTime> poh_deliverdate { get; set; }
        public string poh_updatedby { get; set; }
        public Nullable<System.DateTime> poh_updatedon { get; set; }
        public string poh_comment { get; set; }
        public string poh_type { get; set; }
        public string poh_release { get; set; }
        public string poh_status { get; set; }
        public string poh_scanned { get; set; }
        public Nullable<int> poh_timelineid { get; set; }
        public string poh_direction { get; set; }
        public string poh_tlmod_reason { get; set; }
        public string poh_supplieralias { get; set; }
        public string poh_effective_basis { get; set; }
        public string poh_skiptrigger { get; set; }
        public string poh_checksheetstatus { get; set; }
        public Nullable<System.DateTime> poh_checksheetdate { get; set; }
        public Nullable<System.DateTime> poh_srf_recieve { get; set; }
        public string poh_upotype { get; set; }
        public string poh_uporoute { get; set; }
        public string poh_xdock_event { get; set; }
    }
}
