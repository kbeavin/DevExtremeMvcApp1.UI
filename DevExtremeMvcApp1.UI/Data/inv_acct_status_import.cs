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
    
    public partial class inv_acct_status_import
    {
        public int iasi_tran_id { get; set; }
        public System.DateTime iasi_creation_dt { get; set; }
        public string iasi_cre_by_id { get; set; }
        public Nullable<System.DateTime> iasi_processed_dt { get; set; }
        public short iasi_status { get; set; }
        public string iasi_error_msg { get; set; }
        public string iasi_invoice_number { get; set; }
        public string iasi_reject_reason_code { get; set; }
        public string iasi_reject_reason { get; set; }
        public Nullable<int> iasi_batch_id { get; set; }
    }
}
