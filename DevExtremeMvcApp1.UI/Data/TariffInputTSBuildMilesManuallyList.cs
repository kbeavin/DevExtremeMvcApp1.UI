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
    
    public partial class TariffInputTSBuildMilesManuallyList
    {
        public int Id { get; set; }
        public int TariffInputTS_Id { get; set; }
        public string ord_number { get; set; }
        public Nullable<int> stp_number { get; set; }
        public string stp_event { get; set; }
        public string mile_typ_to_stop { get; set; }
        public string mile_typ_from_stop { get; set; }
        public string cmp_id { get; set; }
        public string cmp_name { get; set; }
        public Nullable<int> stp_city { get; set; }
        public string stp_zipcode { get; set; }
        public string ect_billable { get; set; }
        public Nullable<int> stp_mfh_sequence { get; set; }
        public string stp_loadstatus { get; set; }
        public string stp_type { get; set; }
        public Nullable<int> stp_sequence { get; set; }
        public Nullable<int> stopoffflag { get; set; }
        public Nullable<int> minsatstop { get; set; }
        public string allowdetention { get; set; }
        public Nullable<decimal> stp_ooa_mileage { get; set; }
        public Nullable<decimal> stp_ooa_stop { get; set; }
        public string stp_reasonlate { get; set; }
        public string stp_type1 { get; set; }
        public Nullable<decimal> stp_delayhours { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
        public Nullable<decimal> stp_ord_mileage { get; set; }
        public string ord_no_recalc_miles { get; set; }
        public Nullable<System.DateTime> stp_arrivaldate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    
        public virtual TariffInputT TariffInputT { get; set; }
    }
}
