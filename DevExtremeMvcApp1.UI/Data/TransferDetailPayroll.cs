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
    
    public partial class TransferDetailPayroll
    {
        public int TransferHeaderId { get; set; }
        public int PayHeaderId { get; set; }
        public Nullable<bool> Status { get; set; }
        public string StatusMessage { get; set; }
    
        public virtual TransferHeader TransferHeader { get; set; }
    }
}
