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
    
    public partial class CarrierHistoryDetail
    {
        public int chd_id { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
        public Nullable<int> ord_origincity { get; set; }
        public string ord_originstate { get; set; }
        public Nullable<int> ord_destcity { get; set; }
        public string ord_deststate { get; set; }
        public string Crh_Carrier { get; set; }
        public Nullable<decimal> lgh_pay { get; set; }
        public Nullable<decimal> lgh_accessorial { get; set; }
        public Nullable<decimal> lgh_fsc { get; set; }
        public Nullable<decimal> lgh_billed { get; set; }
        public Nullable<decimal> lgh_paid { get; set; }
        public Nullable<System.DateTime> lgh_enddate { get; set; }
        public Nullable<int> orders_late { get; set; }
        public Nullable<decimal> margin { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<decimal> lgh_invoiced { get; set; }
        public Nullable<decimal> lgh_prebilled { get; set; }
        public string chd_archive { get; set; }
    }
}
