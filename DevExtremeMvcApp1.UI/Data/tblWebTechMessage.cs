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
    
    public partial class tblWebTechMessage
    {
        public int SN { get; set; }
        public string wt_vehicle_id { get; set; }
        public int message_type { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public System.DateTime receive_time { get; set; }
        public Nullable<System.DateTime> post_time { get; set; }
        public Nullable<int> post_result { get; set; }
        public string xml_data { get; set; }
    }
}