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
    
    public partial class safetyClaim
    {
        public int scl_Ident { get; set; }
        public int srp_ID { get; set; }
        public string scl_number { get; set; }
        public string scl_suffix { get; set; }
        public string srp_number { get; set; }
        public string scl_description { get; set; }
        public string scl_claimItem { get; set; }
        public Nullable<double> scl_claimQuantity { get; set; }
        public string scl_claimUnit { get; set; }
        public string scl_claimRateUnit { get; set; }
        public Nullable<decimal> scl_claimRate { get; set; }
        public Nullable<decimal> scl_subtotal { get; set; }
        public Nullable<decimal> scl_totalCharge { get; set; }
    }
}
