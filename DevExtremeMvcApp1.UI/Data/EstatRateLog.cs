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
    
    public partial class EstatRateLog
    {
        public int erl_id { get; set; }
        public int ord_hdrnumber { get; set; }
        public string erl_comment { get; set; }
        public Nullable<decimal> erl_total_cost { get; set; }
        public Nullable<System.DateTime> erl_time { get; set; }
        public Nullable<int> erl_batch_id { get; set; }
        public string erl_createby { get; set; }
        public Nullable<System.DateTime> erl_createdt { get; set; }
        public string erl_lastupdateby { get; set; }
        public Nullable<System.DateTime> erl_lastupdatedt { get; set; }
    }
}
