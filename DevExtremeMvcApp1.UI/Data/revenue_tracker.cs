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
    
    public partial class revenue_tracker
    {
        public int rvt_id { get; set; }
        public int ord_hdrnumber { get; set; }
        public int ivh_hdrnumber { get; set; }
        public string ivh_definition { get; set; }
        public System.DateTime rvt_date { get; set; }
        public string cht_itemcode { get; set; }
        public decimal rvt_amount { get; set; }
        public Nullable<int> tar_number { get; set; }
        public string cur_code { get; set; }
        public string rvt_isbackout { get; set; }
        public string ord_status { get; set; }
        public string ivh_invoicestatus { get; set; }
        public string rvt_updatedby { get; set; }
        public string rvt_updatesource { get; set; }
        public string rvt_appname { get; set; }
        public Nullable<double> rvt_quantity { get; set; }
        public Nullable<int> ivd_number { get; set; }
        public string rvt_rateby { get; set; }
        public Nullable<decimal> rvt_billmiles { get; set; }
        public Nullable<decimal> rvt_billemptymiles { get; set; }
    }
}