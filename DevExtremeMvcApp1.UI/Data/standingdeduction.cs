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
    
    public partial class standingdeduction
    {
        public int std_number { get; set; }
        public string sdm_itemcode { get; set; }
        public string std_description { get; set; }
        public Nullable<decimal> std_balance { get; set; }
        public Nullable<decimal> std_startbalance { get; set; }
        public Nullable<decimal> std_endbalance { get; set; }
        public Nullable<decimal> std_deductionrate { get; set; }
        public Nullable<decimal> std_reductionrate { get; set; }
        public string std_status { get; set; }
        public Nullable<System.DateTime> std_issuedate { get; set; }
        public Nullable<System.DateTime> std_closedate { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public string std_priority { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<System.DateTime> std_lastdeddate { get; set; }
        public Nullable<System.DateTime> std_lastreddate { get; set; }
        public Nullable<System.DateTime> std_lastcompdate { get; set; }
        public Nullable<System.DateTime> std_lastcalcdate { get; set; }
        public Nullable<decimal> std_lastdedqty { get; set; }
        public Nullable<decimal> std_lastredqty { get; set; }
        public Nullable<decimal> std_lastcompqty { get; set; }
        public Nullable<decimal> std_lastcalcqty { get; set; }
        public Nullable<System.DateTime> std_priordeddate { get; set; }
        public Nullable<System.DateTime> std_priorreddate { get; set; }
        public Nullable<System.DateTime> std_priorcompdate { get; set; }
        public Nullable<System.DateTime> std_priorcalcdate { get; set; }
        public Nullable<decimal> std_priordedqty { get; set; }
        public Nullable<decimal> std_priorredqty { get; set; }
        public Nullable<decimal> std_priorcompqty { get; set; }
        public Nullable<decimal> std_priorcalcqty { get; set; }
        public Nullable<decimal> std_priorbalance { get; set; }
        public Nullable<int> std_gst { get; set; }
        public string std_refnumtype { get; set; }
        public string std_refnum { get; set; }
        public Nullable<System.DateTime> std_purchase_date { get; set; }
        public string std_purchase_tax_state { get; set; }
        public string std_RemitToVendorID { get; set; }
        public string std_sequential_loan { get; set; }
    }
}
