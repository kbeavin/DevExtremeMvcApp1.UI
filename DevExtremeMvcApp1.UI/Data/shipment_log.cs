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
    
    public partial class shipment_log
    {
        public int sl_id { get; set; }
        public string sl_order { get; set; }
        public Nullable<int> sl_lgh_number { get; set; }
        public string sl_station { get; set; }
        public string sl_citystate { get; set; }
        public string sl_empname { get; set; }
        public string sl_transtype { get; set; }
        public string sl_trailer { get; set; }
        public Nullable<int> sl_pieces { get; set; }
        public Nullable<int> sl_overage { get; set; }
        public Nullable<int> sl_shortage { get; set; }
        public Nullable<int> sl_damaged { get; set; }
        public Nullable<System.DateTime> sl_datetime { get; set; }
        public string sl_filename { get; set; }
        public string sl_comment { get; set; }
        public string sl_updatedby { get; set; }
        public Nullable<System.DateTime> sl_updatedon { get; set; }
        public Nullable<System.DateTime> sl_createdate { get; set; }
        public string sl_createby { get; set; }
    }
}
