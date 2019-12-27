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
    
    public partial class CycleTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CycleTime()
        {
            this.HoSRules = new HashSet<HoSRule>();
            this.SecondsWorkeds = new HashSet<SecondsWorked>();
        }
    
        public int CycleTimeId { get; set; }
        public string mpp_id { get; set; }
        public string version { get; set; }
        public string Type { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public string DriverId { get; set; }
        public string DriverName { get; set; }
        public string VehicleNumber { get; set; }
        public string ShippingInfo { get; set; }
        public string TrailerNumber { get; set; }
        public string CoDrivers { get; set; }
        public Nullable<System.DateTime> DataEndDate { get; set; }
        public Nullable<int> LastDutyStatus { get; set; }
        public string LastDutyStatusAddlInfo { get; set; }
        public Nullable<System.DateTime> LastDutyStatusChangeDate { get; set; }
        public string CurrentHoSRegulation { get; set; }
        public Nullable<int> DrivingSecondsToday { get; set; }
        public Nullable<int> OnDutySecondsToday { get; set; }
        public Nullable<int> sbSecondsToday { get; set; }
        public Nullable<int> OffDutySecondsToday { get; set; }
        public Nullable<int> DrivingSecsYesterday { get; set; }
        public Nullable<int> OnDutySecsYesterday { get; set; }
        public Nullable<int> sbSecsYesterday { get; set; }
        public Nullable<int> OffDutySecsYesterday { get; set; }
        public System.DateTime ModifiedLast { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSRule> HoSRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecondsWorked> SecondsWorkeds { get; set; }
    }
}