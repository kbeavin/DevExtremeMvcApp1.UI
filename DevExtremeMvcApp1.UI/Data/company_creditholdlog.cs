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
    
    public partial class company_creditholdlog
    {
        public int ID { get; set; }
        public string cmp_id { get; set; }
        public System.DateTime LogDate { get; set; }
        public string UserID { get; set; }
        public string cmp_CreditHoldStatus { get; set; }
        public string cmp_CreditHoldComment { get; set; }
        public string CreditHoldOverrideType { get; set; }
        public string CreditHoldOverrideReason { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
    }
}
