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
    
    public partial class CommonAuditLog
    {
        public int ID { get; set; }
        public string Application { get; set; }
        public string IsError { get; set; }
        public string KeyData1 { get; set; }
        public string KeyData2 { get; set; }
        public string LogMessage { get; set; }
        public System.DateTime LogDate { get; set; }
        public string UserId { get; set; }
    }
}
