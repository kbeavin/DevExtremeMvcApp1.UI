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
    
    public partial class optimization
    {
        public int opt_id { get; set; }
        public string opt_description { get; set; }
        public string opt_abbr { get; set; }
        public string opt_type { get; set; }
        public int opt_int_width { get; set; }
        public int opt_int_length { get; set; }
        public int opt_int_height { get; set; }
        public double opt_max_weight { get; set; }
        public string opt_billto { get; set; }
        public Nullable<int> opt_grp_id { get; set; }
    }
}
