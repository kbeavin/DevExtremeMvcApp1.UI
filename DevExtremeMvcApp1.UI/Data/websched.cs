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
    
    public partial class websched
    {
        public int rpt_sched_id { get; set; }
        public string login { get; set; }
        public int rpt_id { get; set; }
        public Nullable<int> rpt_period { get; set; }
        public bool rpt_active { get; set; }
        public string from_city { get; set; }
        public string from_st { get; set; }
        public string from_zip { get; set; }
        public string from_cust_id { get; set; }
        public string to_city { get; set; }
        public string to_st { get; set; }
        public string to_zip { get; set; }
        public string to_cust_id { get; set; }
        public string billto_cust_id { get; set; }
        public string rpt_RevType1 { get; set; }
        public string rpt_RevType2 { get; set; }
        public string rpt_RevType3 { get; set; }
        public string rpt_RevType4 { get; set; }
        public string rpt_TrcType1 { get; set; }
        public string rpt_TrcType2 { get; set; }
        public string rpt_TrcType3 { get; set; }
        public string rpt_TrcType4 { get; set; }
        public string rpt_DrvType1 { get; set; }
        public string rpt_DrvType2 { get; set; }
        public string rpt_DrvType3 { get; set; }
        public string rpt_DrvType4 { get; set; }
        public string rpt_email { get; set; }
        public int rpt_freq { get; set; }
        public string rpt_weekday { get; set; }
        public Nullable<int> rpt_nthday { get; set; }
        public string rpt_start_time { get; set; }
        public string rpt_stop_time { get; set; }
        public Nullable<System.DateTime> rpt_lastrun { get; set; }
        public Nullable<System.DateTime> rpt_nextrun { get; set; }
    
        public virtual webadmuser webadmuser { get; set; }
        public virtual webobject webobject { get; set; }
    }
}
