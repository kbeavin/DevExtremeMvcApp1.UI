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
    
    public partial class Permit_Requirements
    {
        public int PR_ID { get; set; }
        public Nullable<int> PM_ID { get; set; }
        public Nullable<int> mov_number { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public string asgn_type { get; set; }
        public string PR_Default { get; set; }
        public string PR_Escort_Required { get; set; }
        public string PR_Escort_Type { get; set; }
        public Nullable<short> PR_Escort_Qty { get; set; }
        public string pr_comment { get; set; }
    
        public virtual Permit_Master Permit_Master { get; set; }
    }
}