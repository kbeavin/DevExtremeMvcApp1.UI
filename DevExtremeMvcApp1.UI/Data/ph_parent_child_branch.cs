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
    
    public partial class ph_parent_child_branch
    {
        public int phpcb_id { get; set; }
        public Nullable<int> phpcb_parentPH { get; set; }
        public string phpcb_parentBranch { get; set; }
        public Nullable<int> phpcb_childPH { get; set; }
        public string phpcb_childBranch { get; set; }
    }
}