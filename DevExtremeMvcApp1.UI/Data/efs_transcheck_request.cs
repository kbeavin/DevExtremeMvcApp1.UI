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
    
    public partial class efs_transcheck_request
    {
        public int etr_id { get; set; }
        public string etr_asgn_type { get; set; }
        public string etr_asgn_id { get; set; }
        public decimal etr_amount { get; set; }
        public string etr_reasoncode { get; set; }
        public int lgh_number { get; set; }
        public int mov_number { get; set; }
        public int ord_hdrnumber { get; set; }
        public string etr_transcheckcode { get; set; }
        public string etr_comment { get; set; }
        public string etr_request_user { get; set; }
        public Nullable<System.DateTime> etr_request_time { get; set; }
    }
}
