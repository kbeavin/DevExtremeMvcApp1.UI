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
    
    public partial class PayTypeBasisUnitRuleInputSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayTypeBasisUnitRuleInputSource()
        {
            this.PayTypeBasisUnitRuleArgs = new HashSet<PayTypeBasisUnitRuleArg>();
        }
    
        public int Id { get; set; }
        public int PayTypeBasisUnitRule_Id { get; set; }
        public int TariffInputSource_Id { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    
        public virtual PayTypeBasisUnitRule PayTypeBasisUnitRule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayTypeBasisUnitRuleArg> PayTypeBasisUnitRuleArgs { get; set; }
        public virtual TariffInputSource TariffInputSource { get; set; }
    }
}
