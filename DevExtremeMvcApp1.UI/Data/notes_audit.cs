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
    
    public partial class notes_audit
    {
        public int audit_id { get; set; }
        public System.DateTime audit_datetime { get; set; }
        public string audit_loguser { get; set; }
        public string audit_dbuser { get; set; }
        public string audit_application { get; set; }
        public string audit_type { get; set; }
        public int not_number { get; set; }
        public string not_text { get; set; }
        public string not_type { get; set; }
        public string not_urgent { get; set; }
        public Nullable<System.DateTime> not_senton { get; set; }
        public string not_sentby { get; set; }
        public Nullable<System.DateTime> not_expires { get; set; }
        public Nullable<int> not_forwardedfrom { get; set; }
        public string ntb_table { get; set; }
        public string nre_tablekey { get; set; }
        public Nullable<short> not_sequence { get; set; }
        public string last_updatedby { get; set; }
        public Nullable<System.DateTime> last_updatedatetime { get; set; }
        public string autonote { get; set; }
        public string not_text_large { get; set; }
        public string not_viewlevel { get; set; }
        public string ntb_table_copied_from { get; set; }
        public string nre_tablekey_copied_from { get; set; }
        public Nullable<int> not_number_copied_from { get; set; }
        public string not_tmsend { get; set; }
    }
}
