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
    
    public partial class pendingadvance
    {
        public int pa_id { get; set; }
        public Nullable<int> asgn_number { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public string pyt_itemcode { get; set; }
        public Nullable<decimal> pa_amount { get; set; }
        public Nullable<decimal> pa_fee { get; set; }
        public string pa_status { get; set; }
        public string pa_result { get; set; }
        public string tracking_number { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string crd_accountid { get; set; }
        public string crd_customerid { get; set; }
        public string crd_cardnumber { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> processed_date { get; set; }
        public Nullable<decimal> pa_payback { get; set; }
        public Nullable<decimal> pa_bond { get; set; }
        public Nullable<decimal> pa_pay { get; set; }
        public string pa_processing_message { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public Nullable<decimal> pa_advance_percent { get; set; }
    }
}
