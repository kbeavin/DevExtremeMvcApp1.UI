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
    
    public partial class manifestheader
    {
        public int mfh_number { get; set; }
        public Nullable<int> stp_number_start { get; set; }
        public Nullable<int> stp_number_end { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> mov_number { get; set; }
        public string unit_type { get; set; }
        public string unit_id { get; set; }
        public string seal_number { get; set; }
        public string is_active { get; set; }
        public string cmp_id { get; set; }
        public string is_committed { get; set; }
        public string manifest_type { get; set; }
        public Nullable<int> recommended_door { get; set; }
        public Nullable<int> planned_ob_door { get; set; }
        public Nullable<int> route_id { get; set; }
        public string status { get; set; }
        public string mfh_validated { get; set; }
        public string has_notes { get; set; }
        public Nullable<int> stp_count { get; set; }
        public Nullable<int> stp_count_done { get; set; }
        public Nullable<int> pickups { get; set; }
        public Nullable<int> pickups_done { get; set; }
        public Nullable<int> deliveries { get; set; }
        public Nullable<int> deliveries_done { get; set; }
        public Nullable<int> ord_count { get; set; }
        public string remarks { get; set; }
        public Nullable<int> terminal_schedule_id { get; set; }
        public Nullable<int> avail_floor_space { get; set; }
        public Nullable<int> appian_batch { get; set; }
        public string mfh_misc1 { get; set; }
        public string mfh_misc2 { get; set; }
        public string mfh_misc3 { get; set; }
        public string mfh_misc4 { get; set; }
        public Nullable<int> linked_mfh_number { get; set; }
        public string linked_mfh_type { get; set; }
        public string recommended_zone { get; set; }
        public Nullable<int> trl_picks { get; set; }
        public Nullable<int> trl_picks_done { get; set; }
        public Nullable<int> trl_drops { get; set; }
        public Nullable<int> trl_drops_done { get; set; }
    }
}
