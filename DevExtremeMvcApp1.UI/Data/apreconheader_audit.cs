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
    
    public partial class apreconheader_audit
    {
        public int header_number { get; set; }
        public int audit_id { get; set; }
        public string vendor_id { get; set; }
        public string ap_invoice_number { get; set; }
        public System.DateTime ap_invoice_date { get; set; }
        public decimal ap_total_invoice_amount { get; set; }
        public byte vendor_location { get; set; }
        public string rail_motor_flag { get; set; }
        public string header_status { get; set; }
        public string ap_source { get; set; }
        public string comments { get; set; }
        public string err_msg { get; set; }
        public string matched_to_extract { get; set; }
        public string audit_user { get; set; }
        public Nullable<System.DateTime> audit_dttm { get; set; }
        public string audit_action { get; set; }
    }
}