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
    
    public partial class UnitDistancebyLeg
    {
        public int udl_ID { get; set; }
        public string udl_unittype { get; set; }
        public string udl_unitid { get; set; }
        public int udl_lgh_number { get; set; }
        public decimal udl_distance { get; set; }
        public System.DateTime udl_start_date { get; set; }
        public Nullable<System.DateTime> udl_last_updated { get; set; }
        public string udl_last_updatedby { get; set; }
        public byte udl_stlstatus { get; set; }
        public byte udl_verified { get; set; }
    }
}
