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
    
    public partial class ShiftSchedule
    {
        public int ss_id { get; set; }
        public string trc_number { get; set; }
        public string mpp_id { get; set; }
        public string trl_id { get; set; }
        public string ss_shift { get; set; }
        public string ss_shiftstatus { get; set; }
        public System.DateTime ss_date { get; set; }
        public System.DateTime ss_starttime { get; set; }
        public System.DateTime ss_endtime { get; set; }
        public string ss_terminal { get; set; }
        public string ss_fleet { get; set; }
        public string ss_comment { get; set; }
        public string ss_lastupdateby { get; set; }
        public Nullable<System.DateTime> ss_lastupdatedate { get; set; }
        public string car_id { get; set; }
        public Nullable<System.DateTime> ss_logindate { get; set; }
        public Nullable<System.DateTime> ss_logoutdate { get; set; }
        public string trl_id_2 { get; set; }
        public string ss_hometerminal { get; set; }
        public string ss_startcompany { get; set; }
        public string ss_shiftpriority { get; set; }
        public byte[] ss_timestamp { get; set; }
        public Nullable<bool> ss_skiptrigger { get; set; }
        public string ss_ReturnEMTMode { get; set; }
        public double ss_hoursplannedatlogin { get; set; }
        public double ss_hoursutilized { get; set; }
        public string ss_ivr_status { get; set; }
        public Nullable<System.DateTime> ss_tripsumrpt_last_rundate { get; set; }
    }
}