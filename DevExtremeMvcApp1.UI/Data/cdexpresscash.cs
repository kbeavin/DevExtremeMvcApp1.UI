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
    
    public partial class cdexpresscash
    {
        public string cec_accountid { get; set; }
        public string cec_customerid { get; set; }
        public string cec_cardnumber { get; set; }
        public decimal cec_amount { get; set; }
        public string cec_pluslessfee { get; set; }
        public string cec_expresspaycash { get; set; }
        public string cec_tripnumber { get; set; }
        public string cec_misc { get; set; }
        public string cec_addsubtract { get; set; }
        public string cec_origination { get; set; }
        public System.DateTime cec_issuedate { get; set; }
        public string cec_issuedby { get; set; }
        public string cec_updatestatus { get; set; }
        public string cec_errormessage { get; set; }
        public string cec_loadcashtype { get; set; }
        public string cec_cdnrefnum { get; set; }
        public string cec_asgntype { get; set; }
        public string cec_asgnid { get; set; }
        public Nullable<System.DateTime> cec_responsedate { get; set; }
        public Nullable<decimal> cec_charge { get; set; }
        public string cec_comment { get; set; }
        public string pyt_itemcode { get; set; }
        public Nullable<int> pyd_number { get; set; }
        public int cec_trackingnum { get; set; }
    
        public virtual cashcard cashcard { get; set; }
        public virtual cdacctcode cdacctcode { get; set; }
        public virtual cdcustcode cdcustcode { get; set; }
    }
}
