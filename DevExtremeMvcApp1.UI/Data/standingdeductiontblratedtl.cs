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
    
    public partial class standingdeductiontblratedtl
    {
        public int sdh_number { get; set; }
        public int sdd_number { get; set; }
        public decimal sdd_qty { get; set; }
        public decimal sdd_rate { get; set; }
        public string sdd_createdby { get; set; }
        public Nullable<System.DateTime> sdd_createddate { get; set; }
        public string sdd_updatedby { get; set; }
        public Nullable<System.DateTime> sdd_updateddate { get; set; }
    
        public virtual standingdeductiontblratehdr standingdeductiontblratehdr { get; set; }
    }
}
