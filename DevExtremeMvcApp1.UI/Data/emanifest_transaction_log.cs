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
    
    public partial class emanifest_transaction_log
    {
        public int etl_trans_id { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string etl_trans_doctype { get; set; }
        public string etl_trans_sender { get; set; }
        public Nullable<System.DateTime> etl_trans_date { get; set; }
        public string etl_trans_text { get; set; }
        public string etl_trans_user { get; set; }
        public Nullable<int> ttm_message_id { get; set; }
        public Nullable<int> autoprocess_id { get; set; }
    }
}