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
    
    public partial class MobileCommMessageMiddleTierProcessLog
    {
        public long MiddleTierProcessLogId { get; set; }
        public System.Guid MiddleTierProcessLogGuid { get; set; }
        public long ProcessLogId { get; set; }
        public long MessageId { get; set; }
        public string MiddleTierMethod { get; set; }
        public string MiddleTierData { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual MobileCommMessage MobileCommMessage { get; set; }
        public virtual MobileCommMessageProcessLog MobileCommMessageProcessLog { get; set; }
    }
}
