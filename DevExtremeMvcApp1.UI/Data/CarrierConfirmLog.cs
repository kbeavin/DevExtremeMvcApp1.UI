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
    
    public partial class CarrierConfirmLog
    {
        public int ccl_id { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
        public int lgh_number { get; set; }
        public string ccl_reason { get; set; }
        public string ccl_senttype { get; set; }
        public string ccl_sentid { get; set; }
        public Nullable<decimal> ccl_amount { get; set; }
        public string ccl_user { get; set; }
        public Nullable<System.DateTime> ccl_lastupdated { get; set; }
    }
}