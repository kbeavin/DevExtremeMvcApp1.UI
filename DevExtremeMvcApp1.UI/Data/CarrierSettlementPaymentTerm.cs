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
    
    public partial class CarrierSettlementPaymentTerm
    {
        public int id { get; set; }
        public int csptbt_id { get; set; }
        public string termCode { get; set; }
        public Nullable<bool> enabled { get; set; }
        public Nullable<bool> isDefault { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual CarrierSettlementPaymentTerms_BillTo CarrierSettlementPaymentTerms_BillTo { get; set; }
    }
}