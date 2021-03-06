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
    
    public partial class WebSystemsLinkLog
    {
        public long LogID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> TokenID { get; set; }
        public string FunctionName { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> LogDateTime { get; set; }
        public string ttsUserId { get; set; }
        public string OperationId { get; set; }
        public string MessageType { get; set; }
        public string LogLevel { get; set; }
    
        public virtual WebSystemsLinkCredential WebSystemsLinkCredential { get; set; }
        public virtual WebSystemsLinkToken WebSystemsLinkToken { get; set; }
    }
}
