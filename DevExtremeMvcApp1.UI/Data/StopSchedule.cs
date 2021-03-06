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
    
    public partial class StopSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StopSchedule()
        {
            this.StopSchedulesHistories = new HashSet<StopSchedulesHistory>();
        }
    
        public int sch_id { get; set; }
        public int stp_number { get; set; }
        public string sch_BillToContactMade { get; set; }
        public string sch_LocationContactMade { get; set; }
        public string sch_CreatedBy { get; set; }
        public System.DateTime sch_CreatedOn { get; set; }
        public string sch_LastUpdateBy { get; set; }
        public System.DateTime sch_LastUpdateOn { get; set; }
        public System.DateTime sch_DriverTargetDate { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<System.DateTime> sch_BillToContactMadeDate { get; set; }
        public Nullable<System.DateTime> sch_LocationContactMadeDate { get; set; }
        public Nullable<System.DateTime> sch_DriverTargetEndDate { get; set; }
        public Nullable<int> ce_id { get; set; }
        public string sch_contactname { get; set; }
        public string sch_reasoncode { get; set; }
        public string sch_comment { get; set; }
        public Nullable<int> ce_locationid { get; set; }
        public string sch_locationcontactname { get; set; }
        public string sch_BillToEmailAddress { get; set; }
        public string sch_BillToPhone1 { get; set; }
        public string sch_BillToPhone1Ext { get; set; }
        public string sch_BillToPhone2 { get; set; }
        public string sch_BillToPhone2Ext { get; set; }
        public string sch_BillToFaxNumber { get; set; }
        public string sch_LocationEmailAddress { get; set; }
        public string sch_LocationPhone1 { get; set; }
        public string sch_LocationPhone1Ext { get; set; }
        public string sch_LocationPhone2 { get; set; }
        public string sch_LocationPhone2Ext { get; set; }
        public string sch_LocationFaxNumber { get; set; }
        public string sch_AdHocBillToContact { get; set; }
        public string sch_AdHocLocationContact { get; set; }
        public string sch_reasonlatecode { get; set; }
        public string sch_ontime { get; set; }
        public string sch_lateTractor { get; set; }
        public string sch_lockScheduleDate { get; set; }
    
        public virtual stop stop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StopSchedulesHistory> StopSchedulesHistories { get; set; }
    }
}
