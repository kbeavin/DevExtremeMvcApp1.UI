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
    
    public partial class ltsl_stops
    {
        public int ord_hdrnumber { get; set; }
        public int stp_number { get; set; }
        public string cmp_id { get; set; }
        public string stp_region1 { get; set; }
        public string stp_region2 { get; set; }
        public string stp_region3 { get; set; }
        public int stp_city { get; set; }
        public string stp_state { get; set; }
        public Nullable<System.DateTime> stp_schdtearliest { get; set; }
        public Nullable<System.DateTime> stp_origschdt { get; set; }
        public Nullable<System.DateTime> stp_arrivaldate { get; set; }
        public Nullable<System.DateTime> stp_departuredate { get; set; }
        public string stp_reasonlate { get; set; }
        public Nullable<System.DateTime> stp_schdtlatest { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public Nullable<int> mfh_number { get; set; }
        public string stp_type { get; set; }
        public string stp_paylegpt { get; set; }
        public Nullable<int> shp_hdrnumber { get; set; }
        public Nullable<int> stp_sequence { get; set; }
        public string stp_region4 { get; set; }
        public Nullable<int> stp_lgh_sequence { get; set; }
        public string trl_id { get; set; }
        public Nullable<int> stp_mfh_sequence { get; set; }
        public string stp_event { get; set; }
        public string stp_mfh_position { get; set; }
        public string stp_lgh_position { get; set; }
        public string stp_mfh_status { get; set; }
        public string stp_lgh_status { get; set; }
        public Nullable<int> stp_ord_mileage { get; set; }
        public Nullable<int> stp_lgh_mileage { get; set; }
        public Nullable<int> stp_mfh_mileage { get; set; }
        public Nullable<int> mov_number { get; set; }
        public byte[] timestamp { get; set; }
        public string stp_loadstatus { get; set; }
        public Nullable<double> stp_weight { get; set; }
        public string stp_weightunit { get; set; }
        public string cmd_code { get; set; }
        public string stp_description { get; set; }
        public Nullable<short> stp_count { get; set; }
        public string stp_countunit { get; set; }
        public string cmp_name { get; set; }
        public string stp_comment { get; set; }
        public string stp_status { get; set; }
        public string stp_reftype { get; set; }
        public string stp_refnum { get; set; }
        public string stp_reasonlate_depart { get; set; }
        public string stp_screenmode { get; set; }
        public Nullable<byte> skip_trigger { get; set; }
        public Nullable<double> stp_volume { get; set; }
        public string stp_volumeunit { get; set; }
        public Nullable<int> stp_dispatched_sequence { get; set; }
    }
}