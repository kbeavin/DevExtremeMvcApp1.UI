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
    
    public partial class tblHosAvailability
    {
        public int HosAvailSN { get; set; }
        public string mpp_id { get; set; }
        public System.DateTime CalculatedDate { get; set; }
        public string RuleSet { get; set; }
        public short Activity { get; set; }
        public Nullable<decimal> DriveHoursRemaining { get; set; }
        public Nullable<decimal> DutyHoursRemaining { get; set; }
        public Nullable<decimal> CumulativeDutyHoursRemaining { get; set; }
        public Nullable<decimal> HoursWithinCurrentActivity { get; set; }
        public Nullable<decimal> HoursInRest { get; set; }
        public Nullable<System.DateTime> LastCycleReset { get; set; }
        public Nullable<System.DateTime> NextRecommendedCycleReset { get; set; }
        public Nullable<decimal> HoursIn1Day { get; set; }
        public Nullable<decimal> HoursIn2Days { get; set; }
        public Nullable<decimal> USHoursUntilRestBreak { get; set; }
        public Nullable<System.DateTime> LastTimeUnderUSARules { get; set; }
        public Nullable<decimal> CNHoursUntil24HResetRequired { get; set; }
        public Nullable<decimal> CNHoursUntillShiftResetRequired { get; set; }
        public Nullable<decimal> CNHoursUntillOptimisticShiftResetRequired { get; set; }
        public Nullable<decimal> CNWorkLeftHours { get; set; }
        public Nullable<byte> CNDayOfDeferral { get; set; }
        public Nullable<decimal> CNDayQualifyingOffDutyHours { get; set; }
        public Nullable<decimal> CNDayDeferringOffDutyHours { get; set; }
        public Nullable<System.DateTime> LastTimeUnderCANRules { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual manpowerprofile manpowerprofile { get; set; }
    }
}
