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
    
    public partial class PayDetailDispute
    {
        public int PayDetailDisputeId { get; set; }
        public Nullable<int> pyh_number { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string Status { get; set; }
        public string ReleasedBy { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string RateCode { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string RateUnit { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}