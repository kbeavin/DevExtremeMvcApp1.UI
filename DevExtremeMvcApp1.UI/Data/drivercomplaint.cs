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
    
    public partial class drivercomplaint
    {
        public string mpp_id { get; set; }
        public System.DateTime drc_datereceived { get; set; }
        public System.DateTime drc_dateoccured { get; set; }
        public string drc_company { get; set; }
        public Nullable<int> drc_city { get; set; }
        public string drc_location { get; set; }
        public string drc_state { get; set; }
        public string drc_description { get; set; }
        public string drc_drivercomments { get; set; }
        public string drc_receivedby { get; set; }
        public string drc_handledby { get; set; }
        public string drc_code { get; set; }
        public byte[] timestamp { get; set; }
        public string drc_source { get; set; }
    }
}