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
    
    public partial class carrier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carrier()
        {
            this.carrier_moreSettings = new HashSet<carrier_moreSettings>();
        }
    
        public string car_id { get; set; }
        public string car_name { get; set; }
        public string car_fedid { get; set; }
        public string car_address1 { get; set; }
        public string car_address2 { get; set; }
        public Nullable<int> cty_code { get; set; }
        public string car_zip { get; set; }
        public string pto_id { get; set; }
        public string car_scac { get; set; }
        public string car_contact { get; set; }
        public string car_type1 { get; set; }
        public string car_type2 { get; set; }
        public string car_type3 { get; set; }
        public string car_type4 { get; set; }
        public string car_misc1 { get; set; }
        public string car_misc2 { get; set; }
        public string car_misc3 { get; set; }
        public string car_misc4 { get; set; }
        public string car_phone1 { get; set; }
        public string car_phone2 { get; set; }
        public string car_phone3 { get; set; }
        public Nullable<System.DateTime> car_lastactivity { get; set; }
        public string car_actg_type { get; set; }
        public string car_iccnum { get; set; }
        public string car_contract { get; set; }
        public string car_otherid { get; set; }
        public string car_usecashcard { get; set; }
        public string car_status { get; set; }
        public string car_board { get; set; }
        public string car_updatedby { get; set; }
        public Nullable<System.DateTime> car_updateddate { get; set; }
        public Nullable<System.DateTime> car_createdate { get; set; }
        public Nullable<System.DateTime> car_exp1_date { get; set; }
        public Nullable<System.DateTime> car_exp2_date { get; set; }
        public Nullable<System.DateTime> car_terminationdt { get; set; }
        public string car_email { get; set; }
        public string car_service_location { get; set; }
        public string car_country { get; set; }
        public string car_gp_class { get; set; }
        public string car_currency { get; set; }
        public string car_agent { get; set; }
        public string car_trltype1 { get; set; }
        public string car_trltype2 { get; set; }
        public string car_trltype3 { get; set; }
        public string car_trltype4 { get; set; }
        public Nullable<int> car_ins_cargolimits { get; set; }
        public Nullable<int> car_ins_liabilitylimits { get; set; }
        public string car_ins_certificate { get; set; }
        public string car_ins_w9 { get; set; }
        public string car_ins_contract { get; set; }
        public Nullable<System.DateTime> car_exp1_enddate { get; set; }
        public Nullable<System.DateTime> car_exp2_enddate { get; set; }
        public string car_branch { get; set; }
        public string car_dotnum { get; set; }
        public Nullable<int> car_204flag { get; set; }
        public Nullable<int> car_210flag { get; set; }
        public Nullable<int> car_214flag { get; set; }
        public string car_rating { get; set; }
        public string car_quickentry { get; set; }
        public Nullable<byte> car_confirmprint { get; set; }
        public Nullable<byte> car_confirmfax { get; set; }
        public Nullable<byte> car_confirmemail { get; set; }
        public string car_confirmpathname { get; set; }
        public string car_411_monitored { get; set; }
        public string car_extequip_interval_warnlevel { get; set; }
        public Nullable<int> car_extequip_interval_hours { get; set; }
        public Nullable<int> car_extequip_interval_maxcount { get; set; }
        public Nullable<int> car_loads_offered { get; set; }
        public Nullable<int> car_loads_responded_to { get; set; }
        public Nullable<int> car_loads_not_responded_to { get; set; }
        public Nullable<int> car_loads_awarded { get; set; }
        public Nullable<int> car_loads_on_time { get; set; }
        public Nullable<int> car_confirm_ir_id { get; set; }
        public Nullable<int> car_confirm_irk_id { get; set; }
        public string car_confirm_type { get; set; }
        public string car_fgt_pay_terms { get; set; }
        public Nullable<short> car_hazmat { get; set; }
        public Nullable<System.DateTime> car_approval_dt { get; set; }
        public string car_sub_iccnum { get; set; }
        public Nullable<short> car_eft_flag { get; set; }
        public string car_web_address { get; set; }
        public string car_region_type { get; set; }
        public string car_manager { get; set; }
        public string car_tier_rating { get; set; }
        public string car_tenderloadby { get; set; }
        public Nullable<int> car_204validate { get; set; }
        public string car_CRMType { get; set; }
        public Nullable<int> rowsec_rsrv_id { get; set; }
        public string car_204tender { get; set; }
        public string car_204update { get; set; }
        public byte[] dw_timestamp { get; set; }
        public string car_CarrierWatch_monitored { get; set; }
        public string car_mt_type_loaded { get; set; }
        public string car_mt_type_empty { get; set; }
        public Nullable<int> car_204_cancel_new { get; set; }
        public string car_fuel_card_account_id { get; set; }
        public string car_fuel_card_pay_type { get; set; }
        public string car_report_url { get; set; }
        public Nullable<int> PayScheduleId { get; set; }
        public string car_dispatch_compute_on_save { get; set; }
        public string OriginDestinationOption { get; set; }
        public string external_type { get; set; }
        public Nullable<int> car_score { get; set; }
        public string car_preventrating { get; set; }
        public string car_req_cin { get; set; }
        public string car_fuel_card_carrier_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carrier_moreSettings> carrier_moreSettings { get; set; }
    }
}
