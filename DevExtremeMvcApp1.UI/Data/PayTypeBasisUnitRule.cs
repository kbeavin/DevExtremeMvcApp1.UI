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
    
    public partial class PayTypeBasisUnitRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayTypeBasisUnitRule()
        {
            this.paytypes = new HashSet<paytype>();
            this.PayTypeBasisUnitRuleInputSources = new HashSet<PayTypeBasisUnitRuleInputSource>();
        }
    
        public int Id { get; set; }
        public string RuleType { get; set; }
        public string BasisUnitRuleName { get; set; }
        public string PhysicalName { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paytype> paytypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayTypeBasisUnitRuleInputSource> PayTypeBasisUnitRuleInputSources { get; set; }
    }
}
