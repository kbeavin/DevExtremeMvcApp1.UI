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
    
    public partial class legdetail
    {
        public int lgd_number { get; set; }
        public int lgh_number { get; set; }
        public Nullable<int> lgd_startcity { get; set; }
        public string lgd_startstate { get; set; }
        public Nullable<int> lgd_endcity { get; set; }
        public string lgd_endstate { get; set; }
        public string lgd_startregion { get; set; }
        public string lgd_endregion { get; set; }
        public System.DateTime lgd_startdate { get; set; }
        public Nullable<System.DateTime> lgd_enddate { get; set; }
        public Nullable<int> lgd_odometerstart { get; set; }
        public Nullable<int> lgd_odometerend { get; set; }
        public Nullable<int> lgd_startlegnumber { get; set; }
        public Nullable<int> lgd_endlegnumber { get; set; }
        public string lgd_mileagetype { get; set; }
        public byte[] timestamp { get; set; }
    }
}
