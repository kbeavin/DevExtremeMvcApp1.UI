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
    
    public partial class company_print_settings
    {
        public int cps_id { get; set; }
        public string cmp_id { get; set; }
        public Nullable<int> cps_print_invoice { get; set; }
        public string cps_print_printer { get; set; }
        public Nullable<int> cps_fax_invoice { get; set; }
        public string cps_fax_number { get; set; }
        public string cps_fax_printer { get; set; }
        public Nullable<int> cps_email_invoice { get; set; }
        public string cps_email_address1 { get; set; }
        public string cps_email_address2 { get; set; }
        public string cps_email_address3 { get; set; }
        public string cps_email_printer { get; set; }
        public string cps_email_subject { get; set; }
        public Nullable<int> cps_pdf_invoice { get; set; }
        public string cps_email_directory { get; set; }
        public string cps_work_directory { get; set; }
        public string cpd_email_bodytext { get; set; }
        public string cpd_fax_coverfile { get; set; }
        public string cpd_fax_subject { get; set; }
        public string cpd_fax_to { get; set; }
        public string cpd_clear_files { get; set; }
    }
}