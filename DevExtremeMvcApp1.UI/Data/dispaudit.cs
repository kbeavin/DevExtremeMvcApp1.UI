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
    
    public partial class dispaudit
    {
        public Nullable<int> ord_hdrnumber { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_dt { get; set; }
        public Nullable<int> stp_number { get; set; }
        public Nullable<System.DateTime> old_req_pickup_dt { get; set; }
        public Nullable<System.DateTime> new_req_pickup_dt { get; set; }
        public Nullable<System.DateTime> old_req_delivery_dt { get; set; }
        public Nullable<System.DateTime> new_req_delivery_dt { get; set; }
        public Nullable<System.DateTime> old_dispatch_dt { get; set; }
        public Nullable<System.DateTime> new_dispatch_dt { get; set; }
        public Nullable<System.DateTime> old_actual_arrival_dt { get; set; }
        public Nullable<System.DateTime> new_actual_arrival_dt { get; set; }
        public string stp_event { get; set; }
        public string cty_nmstct { get; set; }
        public string cmp_name { get; set; }
        public int dispaudit_ident { get; set; }
    }
}