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
    
    public partial class laneauction_messagelog
    {
        public int lam_identity { get; set; }
        public int lam_batch_nbr { get; set; }
        public string lam_transaction_type { get; set; }
        public string lam_item { get; set; }
        public string lam_item_msg { get; set; }
        public string lam_itemkey { get; set; }
        public string lam_IWE { get; set; }
        public string lam_user_id { get; set; }
        public Nullable<System.DateTime> lam_create_date { get; set; }
        public string ord_number { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
        public Nullable<int> mov_number { get; set; }
        public Nullable<int> ca_id { get; set; }
        public Nullable<int> tariffkeybid_tar_number { get; set; }
        public Nullable<int> tariffkey_tar_number { get; set; }
    }
}