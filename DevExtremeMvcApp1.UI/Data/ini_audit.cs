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
    
    public partial class ini_audit
    {
        public int audit_id { get; set; }
        public Nullable<System.DateTime> audit_created { get; set; }
        public string audit_createdby { get; set; }
        public string audit_user_id { get; set; }
        public string audit_file { get; set; }
        public string audit_section { get; set; }
        public string audit_item { get; set; }
        public string audit_oldvalue { get; set; }
        public string audit_newvalue { get; set; }
        public string audit_description { get; set; }
    }
}
