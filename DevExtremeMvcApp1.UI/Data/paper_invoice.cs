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
    
    public partial class paper_invoice
    {
        public int id_num { get; set; }
        public int ord_hdrnumber { get; set; }
        public string pi_car_invnum { get; set; }
        public Nullable<System.DateTime> pi_car_invdate { get; set; }
        public string pi_desc { get; set; }
        public Nullable<decimal> pi_charge { get; set; }
        public string pi_comment { get; set; }
        public string pi_carrier { get; set; }
        public Nullable<int> pi_pyh_pyhnumber { get; set; }
        public Nullable<System.DateTime> pi_pw_date { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<System.DateTime> pi_date_created { get; set; }
        public string pi_createdby { get; set; }
        public Nullable<System.DateTime> pi_date_updated { get; set; }
        public string pi_updatedby { get; set; }
        public string pi_workflowstatus { get; set; }
    }
}