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
    
    public partial class legal_entity_postingperiod
    {
        public string lepp_le_id { get; set; }
        public short lepp_fiscalyear { get; set; }
        public string lepp_series { get; set; }
        public short lepp_period { get; set; }
        public Nullable<System.DateTime> lepp_period_startdate { get; set; }
        public Nullable<System.DateTime> lepp_period_enddate { get; set; }
        public Nullable<System.DateTime> lepp_use_postdate { get; set; }
        public Nullable<System.DateTime> lepp_period_cutoff { get; set; }
    }
}
