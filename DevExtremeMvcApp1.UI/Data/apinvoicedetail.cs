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
    
    public partial class apinvoicedetail
    {
        public int apv_number { get; set; }
        public int apd_number { get; set; }
        public string apd_asgn_type { get; set; }
        public string apd_asgn_id { get; set; }
        public string apd_pto_id { get; set; }
        public decimal apd_amount { get; set; }
        public string apd_processed { get; set; }
        public string apd_createdby { get; set; }
        public System.DateTime apd_createddate { get; set; }
        public string apd_modifiedby { get; set; }
        public System.DateTime apd_modifieddate { get; set; }
        public Nullable<int> std_number { get; set; }
        public string sdm_itemcode { get; set; }
        public Nullable<int> pyd_number { get; set; }
        public string pyt_itemcode { get; set; }
        public string pyd_glnum { get; set; }
        public Nullable<decimal> apd_deductionthreshold { get; set; }
        public string apd_glnumber { get; set; }
        public Nullable<int> apd_glindex { get; set; }
    
        public virtual apinvoiceheader apinvoiceheader { get; set; }
    }
}
