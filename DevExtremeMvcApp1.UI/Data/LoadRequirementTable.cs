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
    
    public partial class LoadRequirementTable
    {
        public int ord_hdrnumber { get; set; }
        public int lrq_sequence { get; set; }
        public string lrq_equip_type { get; set; }
        public string lrq_type { get; set; }
        public string lrq_not { get; set; }
        public string lrq_manditory { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> lrq_quantity { get; set; }
        public Nullable<int> stp_number { get; set; }
        public Nullable<int> fgt_number { get; set; }
        public string cmp_id { get; set; }
        public string def_id_type { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string lrq_default { get; set; }
        public string cmd_code { get; set; }
        public string def_required { get; set; }
        public Nullable<System.DateTime> lrq_expire_date { get; set; }
        public string def_cmp_billto { get; set; }
        public int loadrequirement_id { get; set; }
        public string lrq_field { get; set; }
        public string lrq_units { get; set; }
        public Nullable<System.DateTime> lrq_start_date { get; set; }
        public Nullable<System.DateTime> lrq_end_date { get; set; }
        public string lrq_windowday { get; set; }
        public Nullable<int> lrq_parent_id { get; set; }
        public Nullable<int> loadreqdefault_ident { get; set; }
    }
}