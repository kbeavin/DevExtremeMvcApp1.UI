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
    
    public partial class transcardexpense
    {
        public int tce_id { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public string pyt_itemcode { get; set; }
        public Nullable<System.DateTime> tce_date { get; set; }
        public Nullable<decimal> tce_amount { get; set; }
        public string tce_approval_code { get; set; }
        public string tce_cash_card { get; set; }
        public string tce_paydetail { get; set; }
    }
}
