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
    
    public partial class driverobservation
    {
        public string mpp_id { get; set; }
        public System.DateTime dro_observationdt { get; set; }
        public Nullable<int> dro_city { get; set; }
        public string dro_state { get; set; }
        public string dro_code { get; set; }
        public Nullable<short> dro_points { get; set; }
        public string dro_seatbelt { get; set; }
        public string dro_uniform { get; set; }
        public string dro_security { get; set; }
        public string dro_description { get; set; }
        public string dro_observedby { get; set; }
        public string dro_headlight { get; set; }
        public string dro_drivercomments { get; set; }
        public byte[] timestamp { get; set; }
        public string road_conditions { get; set; }
    }
}
