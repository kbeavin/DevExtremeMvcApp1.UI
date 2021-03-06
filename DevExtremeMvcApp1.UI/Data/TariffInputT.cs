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
    
    public partial class TariffInputT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TariffInputT()
        {
            this.TariffInputTSBuildMilesManuallyLists = new HashSet<TariffInputTSBuildMilesManuallyList>();
            this.TariffInputTSFreightBreakLists = new HashSet<TariffInputTSFreightBreakList>();
            this.TariffInputTSLists = new HashSet<TariffInputTSList>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> dtm_billdate_dt { get; set; }
        public Nullable<System.DateTime> dtm_idt_start_date { get; set; }
        public string str_billto { get; set; }
        public string str_trailer { get; set; }
        public string str_revtype1 { get; set; }
        public string str_revtype2 { get; set; }
        public string str_revtype3 { get; set; }
        public string str_revtype4 { get; set; }
        public string str_cmdcode { get; set; }
        public string str_originpoint { get; set; }
        public Nullable<decimal> dec_origincity { get; set; }
        public string str_destpoint { get; set; }
        public Nullable<decimal> dec_destcity { get; set; }
        public Nullable<decimal> dec_weight { get; set; }
        public string str_wgtunit { get; set; }
        public Nullable<decimal> dec_pieces { get; set; }
        public string str_countunit { get; set; }
        public Nullable<decimal> dec_volume { get; set; }
        public string str_volunit { get; set; }
        public string str_cht_itemcode { get; set; }
        public Nullable<decimal> dec_routemiles { get; set; }
        public string str_distunit { get; set; }
        public string str_orderedby { get; set; }
        public Nullable<decimal> dec_length { get; set; }
        public Nullable<decimal> dec_width { get; set; }
        public Nullable<decimal> dec_height { get; set; }
        public string str_company { get; set; }
        public string str_carrier { get; set; }
        public string str_triptype { get; set; }
        public Nullable<decimal> dec_mtmiles { get; set; }
        public Nullable<decimal> dec_ldmiles { get; set; }
        public string str_loadstatus { get; set; }
        public string str_team { get; set; }
        public string str_cartype { get; set; }
        public string str_tractor { get; set; }
        public Nullable<decimal> dec_mileagetable { get; set; }
        public string str_drvtype1 { get; set; }
        public string str_drvtype2 { get; set; }
        public string str_drvtype3 { get; set; }
        public string str_drvtype4 { get; set; }
        public string str_trctype1 { get; set; }
        public string str_trctype2 { get; set; }
        public string str_trctype3 { get; set; }
        public string str_trctype4 { get; set; }
        public string str_itemcode { get; set; }
        public string str_driver { get; set; }
        public string str_pytitemcode { get; set; }
        public Nullable<decimal> dec_ii_billedmiles { get; set; }
        public Nullable<decimal> dec_ii_stopsoffpaycount { get; set; }
        public string str_is_ord_trl_type1 { get; set; }
        public Nullable<System.DateTime> dtm_idt_senioritydate { get; set; }
        public Nullable<decimal> dec_ii_chargeablestopoffs { get; set; }
        public string str_trltype1 { get; set; }
        public string str_trltype2 { get; set; }
        public string str_trltype3 { get; set; }
        public string str_trltype4 { get; set; }
        public Nullable<decimal> dec_ir_ooamileage { get; set; }
        public Nullable<decimal> dec_il_ooastops { get; set; }
        public Nullable<decimal> dec_il_carryins1 { get; set; }
        public Nullable<decimal> dec_il_carryins2 { get; set; }
        public string str_is_originpointonleg { get; set; }
        public Nullable<decimal> dec_il_origincityonleg { get; set; }
        public string str_is_destpointonleg { get; set; }
        public Nullable<decimal> dec_il_destcityonleg { get; set; }
        public string str_ib_orderfixedformiles { get; set; }
        public string str_is_terms { get; set; }
        public string str_is_ord_trctype4 { get; set; }
        public string str_is_mastercompany { get; set; }
        public string str_is_ord_trl_type2 { get; set; }
        public string str_is_ord_trl_type3 { get; set; }
        public string str_is_ord_trl_type4 { get; set; }
        public string str_is_shipper { get; set; }
        public Nullable<decimal> dec_idec_revenuepermile { get; set; }
        public Nullable<decimal> dec_l_hub_miles { get; set; }
        public Nullable<decimal> dec_ii_custdoc { get; set; }
        public string str_s_shipper { get; set; }
        public string str_s_consignee { get; set; }
        public string str_s_stopcmpid { get; set; }
        public Nullable<decimal> dec_idc_loadingmeters { get; set; }
        public Nullable<decimal> dec_idc_ordered_loadingmeters { get; set; }
        public string str_is_loadingmetersunit { get; set; }
        public Nullable<decimal> dec_idc_orderedweight { get; set; }
        public Nullable<decimal> dec_idc_orderedvolume { get; set; }
        public Nullable<decimal> dec_l_mt_hub_miles { get; set; }
        public Nullable<decimal> dec_l_ld_hub_miles { get; set; }
        public Nullable<decimal> dec_sd_mileage_adj_pct { get; set; }
        public string str_originzip { get; set; }
        public string str_destzip { get; set; }
        public Nullable<decimal> dec_il_ord_hdrnumber { get; set; }
        public Nullable<decimal> dec_r_mt_cust_miles { get; set; }
        public Nullable<decimal> dec_r_ld_cust_miles { get; set; }
        public Nullable<decimal> dec_idec_drtodmiles { get; set; }
        public string str_is_trlconfiguration { get; set; }
        public string str_ib_donotapplylhmins { get; set; }
        public string str_origin_service_area { get; set; }
        public string str_origin_service_zone { get; set; }
        public string str_origin_service_center { get; set; }
        public string str_origin_service_region { get; set; }
        public string str_dest_service_area { get; set; }
        public string str_dest_service_zone { get; set; }
        public string str_dest_service_center { get; set; }
        public string str_dest_service_region { get; set; }
        public string str_is_lghtype2 { get; set; }
        public string str_is_lghtype3 { get; set; }
        public string str_is_lghtype4 { get; set; }
        public Nullable<decimal> dec_il_lghnumber { get; set; }
        public string str_s_thirdparty { get; set; }
        public string str_s_thirdpartytype { get; set; }
        public Nullable<decimal> dec_idc_profit { get; set; }
        public Nullable<decimal> dec_i_segments { get; set; }
        public string str_orig_county { get; set; }
        public string str_dest_county { get; set; }
        public string str_s_origin_ord { get; set; }
        public string str_s_dest_ord { get; set; }
        public string str_billto_othertype1 { get; set; }
        public string str_billto_othertype2 { get; set; }
        public string str_s_masterordernumber { get; set; }
        public Nullable<System.DateTime> dtm_idt_avgfuelprice_date { get; set; }
        public Nullable<decimal> dec_sl_lghnumber { get; set; }
        public string str_drv_payto { get; set; }
        public string str_trc_owner { get; set; }
        public string str_trl_owner { get; set; }
        public string str_car_payto { get; set; }
        public string str_is_mpp_terminal { get; set; }
        public string str_is_trc_terminal { get; set; }
        public string str_is_trl_terminal { get; set; }
        public Nullable<decimal> dec_ii_drp_count { get; set; }
        public Nullable<decimal> dec_ii_pup_count { get; set; }
        public string str_is_primary_driver { get; set; }
        public string str_s_freightpickupcmpid { get; set; }
        public string str_s_trailer2 { get; set; }
        public string str_is_ord_unit { get; set; }
        public Nullable<decimal> dec_sdec_quantity { get; set; }
        public Nullable<decimal> dec_idec_odmiles { get; set; }
        public Nullable<decimal> dec_ii_instatemiles { get; set; }
        public string str_ib_useodmiles { get; set; }
        public string str_ib_useinstatemiles { get; set; }
        public Nullable<decimal> dec_sdec_routemiles_total { get; set; }
        public Nullable<decimal> dec_sdec_mtmiles_total { get; set; }
        public Nullable<decimal> dec_sdec_ldmiles_total { get; set; }
        public Nullable<decimal> dec_carrier_service_days { get; set; }
        public string str_s_stp_type { get; set; }
        public string str_s_calc_dlaycm { get; set; }
        public string str_s_calc_dlayst { get; set; }
        public string str_s_timeunit { get; set; }
        public string str_s_invoiceby { get; set; }
        public Nullable<decimal> dec_l_stp_number { get; set; }
        public Nullable<decimal> dec_fgt_number { get; set; }
        public string str_s_route { get; set; }
        public string str_s_chassis { get; set; }
        public string str_s_chassis2 { get; set; }
        public string str_s_dolly { get; set; }
        public string str_s_dolly2 { get; set; }
        public string str_s_trailer3 { get; set; }
        public string str_s_trailer4 { get; set; }
        public Nullable<decimal> dec_idc_gross_profit_margin { get; set; }
        public string str_s_dbs_type { get; set; }
        public Nullable<decimal> dec_sdc_ordtotalweight { get; set; }
        public string str_sb_onlycarriercontractedrates { get; set; }
        public string str_is_trl_company { get; set; }
        public string str_is_trl_fleet { get; set; }
        public string str_is_trl_division { get; set; }
        public string str_is_trc_company { get; set; }
        public string str_is_trc_fleet { get; set; }
        public string str_is_trc_division { get; set; }
        public string str_is_drv_company { get; set; }
        public string str_is_drv_fleet { get; set; }
        public string str_is_drv_division { get; set; }
        public string str_is_drv_domicile { get; set; }
        public string str_is_drv_teamleader { get; set; }
        public string str_is_pallet_type { get; set; }
        public Nullable<decimal> dec_il_pallet_count { get; set; }
        public string str_carrier_service_level { get; set; }
        public string str_ratemode { get; set; }
        public Nullable<decimal> str_dbh_id { get; set; }
        public Nullable<decimal> str_dbs_id { get; set; }
        public Nullable<decimal> dec_loaded_volume { get; set; }
        public string str_s_dbs_group { get; set; }
        public string str_mpp_branch { get; set; }
        public string str_mpp2_branch { get; set; }
        public string str_trc_branch { get; set; }
        public string str_trl_branch { get; set; }
        public string str_tpr_branch { get; set; }
        public string str_car_branch { get; set; }
        public string str_ord_branch { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TariffInputTSBuildMilesManuallyList> TariffInputTSBuildMilesManuallyLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TariffInputTSFreightBreakList> TariffInputTSFreightBreakLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TariffInputTSList> TariffInputTSLists { get; set; }
    }
}
