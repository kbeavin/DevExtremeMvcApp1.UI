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
    
    public partial class payschedulesdetail
    {
        public int psd_id { get; set; }
        public Nullable<System.DateTime> psd_date { get; set; }
        public string psd_status { get; set; }
        public int psh_id { get; set; }
        public string psd_batch_id { get; set; }
        public string psd_batch_status { get; set; }
        public Nullable<System.DateTime> psd_chkissuedate { get; set; }
        public Nullable<byte> psd_applicable_month { get; set; }
        public Nullable<int> psd_applicable_year { get; set; }
        public string SDM_ITEMCODE_Exclude_ind { get; set; }
        public string SDM_ITEMCODE_Exclude_List { get; set; }
    }
}