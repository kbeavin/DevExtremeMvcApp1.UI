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
    
    public partial class purchase_transport_cost_log
    {
        public int ptcl_id { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<System.DateTime> ptcl_start_date { get; set; }
        public string car_id { get; set; }
        public string ptcl_updatedby { get; set; }
        public Nullable<System.DateTime> ptcl_updatedate { get; set; }
        public Nullable<decimal> ptcl_billing_linehaul { get; set; }
        public Nullable<decimal> ptcl_billing_total { get; set; }
        public Nullable<decimal> ptcl_pay_linehaul { get; set; }
        public Nullable<decimal> ptcl_pay_fsc { get; set; }
        public Nullable<decimal> ptcl_pay_total { get; set; }
        public Nullable<int> ptc_id { get; set; }
        public Nullable<decimal> ptc_linehaul { get; set; }
        public string ptc_locked { get; set; }
        public Nullable<decimal> ptc_amtover { get; set; }
        public string ptc_amtover_basis { get; set; }
        public Nullable<decimal> ptc_minmargin { get; set; }
        public string ptc_minmargin_basis { get; set; }
        public string ptc_minmargin_locked { get; set; }
        public Nullable<System.DateTime> ptc_date { get; set; }
        public string ptc_mode { get; set; }
        public string ptc_override_id { get; set; }
        public string ptc_override_reason { get; set; }
    }
}
