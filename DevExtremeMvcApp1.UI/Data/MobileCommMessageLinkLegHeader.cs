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
    
    public partial class MobileCommMessageLinkLegHeader
    {
        public long LinkLegHeaderId { get; set; }
        public long MessageId { get; set; }
        public int lgh_number { get; set; }
    
        public virtual legheader legheader { get; set; }
        public virtual MobileCommMessage MobileCommMessage { get; set; }
    }
}
