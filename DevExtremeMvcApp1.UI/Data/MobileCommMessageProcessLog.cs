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
    
    public partial class MobileCommMessageProcessLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MobileCommMessageProcessLog()
        {
            this.MobileCommMessageMiddleTierProcessLogs = new HashSet<MobileCommMessageMiddleTierProcessLog>();
        }
    
        public System.Guid ProcessLogGuid { get; set; }
        public long MessageId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public long ProcessLogId { get; set; }
    
        public virtual MobileCommMessage MobileCommMessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobileCommMessageMiddleTierProcessLog> MobileCommMessageMiddleTierProcessLogs { get; set; }
    }
}