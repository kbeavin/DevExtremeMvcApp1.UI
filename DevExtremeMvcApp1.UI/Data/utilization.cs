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
    
    public partial class utilization
    {
        public int util_id { get; set; }
        public int lpa_id { get; set; }
        public string trc_number { get; set; }
        public int lgh_number { get; set; }
        public string trc_status { get; set; }
        public string util_code { get; set; }
        public System.DateTime util_start_date { get; set; }
        public Nullable<System.DateTime> util_end_date { get; set; }
        public System.DateTime update_date { get; set; }
    }
}
