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
    
    public partial class TelemetryPermission
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public bool Permission { get; set; }
        public bool Prompted { get; set; }
        public string TelemetryItems { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public string ApplicationVersion { get; set; }
    }
}