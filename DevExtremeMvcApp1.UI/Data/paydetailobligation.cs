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
    
    public partial class paydetailobligation
    {
        public int pdo_ident { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public string pyt_itemcode { get; set; }
        public Nullable<decimal> pyd_amount { get; set; }
        public Nullable<int> pyh_number { get; set; }
        public Nullable<System.DateTime> pyh_payperiod { get; set; }
        public int pyd_number { get; set; }
        public Nullable<int> std_number { get; set; }
        public Nullable<System.DateTime> pdo_processingdt { get; set; }
        public Nullable<System.DateTime> pyd_updatedon { get; set; }
        public Nullable<System.DateTime> pdo_createdon { get; set; }
        public string pdo_createdby { get; set; }
    }
}