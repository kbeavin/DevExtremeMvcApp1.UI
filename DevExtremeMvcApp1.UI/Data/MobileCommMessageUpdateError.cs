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
    
    public partial class MobileCommMessageUpdateError
    {
        public long ErrorId { get; set; }
        public long MessageId { get; set; }
        public string ErrorMessage { get; set; }
        public bool PreventUpdate { get; set; }
        public string ErrorType { get; set; }
        public string Source { get; set; }
        public System.DateTime ErrorDate { get; set; }
    
        public virtual MobileCommMessage MobileCommMessage { get; set; }
    }
}
