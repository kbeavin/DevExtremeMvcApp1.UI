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
    
    public partial class edi_document_archive
    {
        public byte[] eda_archive_dttm { get; set; }
        public string eda_doctype { get; set; }
        public string eda_batch_datetime_id { get; set; }
        public string trp_id { get; set; }
        public Nullable<int> eda_batch_image_seq { get; set; }
        public string eda_docID { get; set; }
        public Nullable<System.DateTime> eda_extract_dttm { get; set; }
        public Nullable<short> eda_extract_count { get; set; }
        public Nullable<System.DateTime> eda_ack_dttm { get; set; }
        public string eda_ack_flag { get; set; }
        public string ord_number { get; set; }
        public string eda_image { get; set; }
        public int eda_id { get; set; }
        public string ivh_invoicenumber { get; set; }
        public Nullable<int> eda_batch_control { get; set; }
        public Nullable<int> eda_batch_doc_seq { get; set; }
        public string eda_selected { get; set; }
        public string eda_997_flag { get; set; }
        public Nullable<System.DateTime> eda_997_dttm { get; set; }
        public Nullable<int> eda_GS_control_number { get; set; }
        public Nullable<int> eda_ISA_control_number { get; set; }
        public string eda_ISA_receiver_id { get; set; }
        public Nullable<int> eda_ST_control_number { get; set; }
    }
}
