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
    
    public partial class estatScheduledOSReportOption
    {
        public int rpt_sched_id { get; set; }
        public string UserName { get; set; }
        public string Clientid { get; set; }
        public bool Cancelled { get; set; }
        public bool NewOrders { get; set; }
        public bool Dispatched { get; set; }
        public bool Inprogress { get; set; }
        public bool Completed { get; set; }
        public bool Invoiced { get; set; }
        public bool Transferred { get; set; }
        public bool DonotInvoice { get; set; }
        public string Reftype { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string TRReq { get; set; }
        public bool showbillto { get; set; }
        public bool showshipper { get; set; }
        public bool showconsignee { get; set; }
        public bool showstopordmiles { get; set; }
        public bool showtriploadmiles { get; set; }
        public bool showtripunloadmiles { get; set; }
        public bool showinvoicestatus { get; set; }
        public bool showmissingpaperwork { get; set; }
        public bool showcarrier { get; set; }
        public bool showord_hdrnumber { get; set; }
        public string excel { get; set; }
    }
}
