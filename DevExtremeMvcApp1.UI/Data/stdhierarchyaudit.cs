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
    
    public partial class stdhierarchyaudit
    {
        public int stha_id { get; set; }
        public int sth_id { get; set; }
        public string stha_action { get; set; }
        public Nullable<System.DateTime> stha_update_dt { get; set; }
        public string stha_update_by { get; set; }
        public string stha_update_field { get; set; }
        public string stha_original_value { get; set; }
        public string stha_new_value { get; set; }
    }
}