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
    
    public partial class fuelticket
    {
        public int ftk_ticket_number { get; set; }
        public int ftk_cty_start { get; set; }
        public int ftk_cty_end { get; set; }
        public string drv_id { get; set; }
        public int ord_hdrnumber { get; set; }
        public System.DateTime ftk_created_on { get; set; }
        public string ftk_created_by { get; set; }
        public string ftk_updated_by { get; set; }
        public string trc_id { get; set; }
        public decimal ftk_liters { get; set; }
        public Nullable<decimal> ftk_cost { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string ftk_printed_by { get; set; }
        public Nullable<System.DateTime> ftk_printed_on { get; set; }
        public string ftk_reconciled_by { get; set; }
        public Nullable<System.DateTime> ftk_reconciled_on { get; set; }
        public string ftk_canceled_by { get; set; }
        public Nullable<System.DateTime> ftk_canceled_on { get; set; }
        public string ftk_invoice { get; set; }
    }
}