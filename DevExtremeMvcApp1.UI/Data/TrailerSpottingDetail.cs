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
    
    public partial class TrailerSpottingDetail
    {
        public int id_num { get; set; }
        public int ord_hdrnumber { get; set; }
        public Nullable<int> mov_number { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<int> stp_number { get; set; }
        public string tsd_status { get; set; }
        public Nullable<System.DateTime> tsd_begin_date { get; set; }
        public Nullable<System.DateTime> tsd_end_date { get; set; }
        public string tsd_stillspotted { get; set; }
        public Nullable<int> tsd_days { get; set; }
        public string tsd_mileage_charge { get; set; }
        public Nullable<int> tsd_mileage { get; set; }
        public string tsd_billto { get; set; }
        public string tsd_authorization_cmp { get; set; }
        public string tsd_authorization_person { get; set; }
        public string tsd_authorization_phone { get; set; }
        public string tsd_authorization_missing { get; set; }
        public string trl_id { get; set; }
        public string cancel_by { get; set; }
        public Nullable<System.DateTime> cancel_date { get; set; }
        public string tsd_remark { get; set; }
        public string tsd_manualadd { get; set; }
    }
}
