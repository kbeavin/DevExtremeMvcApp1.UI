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
    
    public partial class cdfuelbill_pricecap
    {
        public int cdp_id { get; set; }
        public int cdp_vendor { get; set; }
        public string cdp_company { get; set; }
        public string cdp_terminal { get; set; }
        public string cdp_network_flag { get; set; }
        public decimal cdp_metric_admin_fee { get; set; }
        public decimal cdp_us_admin_fee { get; set; }
        public decimal cdp_metric_price_cap { get; set; }
        public decimal cdp_us_price_cap { get; set; }
    }
}
