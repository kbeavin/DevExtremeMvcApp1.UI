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
    
    public partial class RecurringAdjustmentInterestSchedule
    {
        public int RecurringAdjustmentInterestScheduleId { get; set; }
        public int RecurringAdjustmentId { get; set; }
        public int ScheduleId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    
        public virtual RecurringAdjustmentInterest RecurringAdjustmentInterest { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
