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
    
    public partial class TimeDetailExternalRecordKey
    {
        public int ID { get; set; }
        public int TimeDetailId { get; set; }
        public string ExternalRecordKey { get; set; }
    
        public virtual TimeDetail TimeDetail { get; set; }
    }
}