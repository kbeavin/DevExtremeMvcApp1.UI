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
    
    public partial class diplog
    {
        public int dl_identity { get; set; }
        public int tank_nbr { get; set; }
        public Nullable<System.DateTime> dl_date { get; set; }
        public Nullable<int> dl_dipreading { get; set; }
        public string dl_source { get; set; }
        public string dl_updatedby { get; set; }
        public Nullable<System.DateTime> dl_updatedon { get; set; }
        public Nullable<int> dl_delivervolume { get; set; }
        public Nullable<int> dl_salesvolume { get; set; }
    }
}