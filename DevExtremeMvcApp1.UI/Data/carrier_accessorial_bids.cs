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
    
    public partial class carrier_accessorial_bids
    {
        public int cacb_identity { get; set; }
        public int ord_hdrnumber { get; set; }
        public int mov_number { get; set; }
        public Nullable<int> ca_id { get; set; }
        public Nullable<int> cb_id { get; set; }
        public string car_id { get; set; }
        public Nullable<int> lrq_identity { get; set; }
        public string lrq_equip_type { get; set; }
        public string lrq_type { get; set; }
        public Nullable<decimal> lrp_max_amt { get; set; }
        public Nullable<decimal> lrp_bid_amt { get; set; }
        public Nullable<int> tsr_number { get; set; }
        public Nullable<int> accessorial_tar_number { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string created_user { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public string modified_user { get; set; }
    }
}
