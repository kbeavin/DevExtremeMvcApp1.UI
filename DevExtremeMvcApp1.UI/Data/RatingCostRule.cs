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
    
    public partial class RatingCostRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RatingCostRule()
        {
            this.RatingCostDetail_RatingRule = new HashSet<RatingCostDetail_RatingRule>();
            this.RatingRuleActions = new HashSet<RatingRuleAction>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
        public int tar_number { get; set; }
        public bool CreateInvoiceDetail { get; set; }
        public bool CreatePayDetail { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingCostDetail_RatingRule> RatingCostDetail_RatingRule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingRuleAction> RatingRuleActions { get; set; }
    }
}