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
    
    public partial class TimeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeDetail()
        {
            this.TimeDetailExternalRecordKeys = new HashSet<TimeDetailExternalRecordKey>();
            this.TimeDetailxPayDetails = new HashSet<TimeDetailxPayDetail>();
        }
    
        public int TimeDetailId { get; set; }
        public string MappedTimeLogActivityLabelAbbr { get; set; }
        public string asgn_id { get; set; }
        public System.DateTime ActivityStart { get; set; }
        public System.DateTime ActivityEnd { get; set; }
        public decimal Duration { get; set; }
        public short TimeSourceSystemId { get; set; }
        public bool Approved { get; set; }
        public bool Overridden { get; set; }
        public string Comment { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeDetailExternalRecordKey> TimeDetailExternalRecordKeys { get; set; }
        public virtual TimeSourceSystem TimeSourceSystem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeDetailxPayDetail> TimeDetailxPayDetails { get; set; }
    }
}
