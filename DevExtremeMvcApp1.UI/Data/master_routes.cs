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
    
    public partial class master_routes
    {
        public int mr_id { get; set; }
        public string mr_name { get; set; }
        public Nullable<int> mov_number { get; set; }
        public Nullable<int> stp_number { get; set; }
        public Nullable<int> mr_sequence { get; set; }
        public Nullable<System.DateTime> mr_arrival { get; set; }
        public Nullable<System.DateTime> mr_departure { get; set; }
        public Nullable<System.DateTime> mr_earliest { get; set; }
        public Nullable<System.DateTime> mr_latest { get; set; }
        public Nullable<int> mr_leg { get; set; }
    }
}
