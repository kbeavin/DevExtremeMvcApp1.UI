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
    
    public partial class carter_dd_Rules
    {
        public int ddrule_id { get; set; }
        public string DDRule_Name { get; set; }
        public string ddrule_proc { get; set; }
        public bool ddrule_isActive { get; set; }
        public Nullable<decimal> ddrule_interval { get; set; }
        public Nullable<decimal> ddrule_multiplier { get; set; }
        public bool ddrule_isStatic { get; set; }
        public Nullable<decimal> ddrule_staticvalue { get; set; }
        public bool ddrule_ManualOnly { get; set; }
    }
}
