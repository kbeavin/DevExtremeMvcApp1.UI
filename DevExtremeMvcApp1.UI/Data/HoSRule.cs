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
    
    public partial class HoSRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoSRule()
        {
            this.SecondsGaineds = new HashSet<SecondsGained>();
        }
    
        public int HoSRuleId { get; set; }
        public string Category { get; set; }
        public string RuleName { get; set; }
        public Nullable<int> RuleHours { get; set; }
        public Nullable<int> RuleDays { get; set; }
        public Nullable<int> DrivingSecondsAvailable { get; set; }
        public Nullable<int> OnDutySecondsAvailable { get; set; }
        public Nullable<int> CycleResetHours { get; set; }
        public Nullable<System.DateTime> LastResetDate { get; set; }
        public Nullable<System.DateTime> USResetStartDate { get; set; }
        public Nullable<int> CycleTimeSecondsRemaining { get; set; }
        public Nullable<int> RemainingOnSecsUntilBreakRequired { get; set; }
        public Nullable<int> CycleTimeId { get; set; }
        public System.DateTime ModifiedLast { get; set; }
    
        public virtual CycleTime CycleTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecondsGained> SecondsGaineds { get; set; }
    }
}
