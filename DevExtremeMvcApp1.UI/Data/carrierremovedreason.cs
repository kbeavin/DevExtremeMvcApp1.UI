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
    
    public partial class carrierremovedreason
    {
        public int crr_id { get; set; }
        public int lgh_number { get; set; }
        public string crr_prevcarrier { get; set; }
        public string crr_newcarrier { get; set; }
        public string crr_reason { get; set; }
        public string crr_note { get; set; }
        public string crr_user { get; set; }
        public Nullable<System.DateTime> crr_lastupdated { get; set; }
    }
}