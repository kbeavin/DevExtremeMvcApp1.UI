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
    
    public partial class invoicedetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invoicedetail()
        {
            this.DedicatedRateAllocations = new HashSet<DedicatedRateAllocation>();
            this.InvoiceDetailTaxes = new HashSet<InvoiceDetailTax>();
            this.InvoiceDetailTaxes1 = new HashSet<InvoiceDetailTax>();
        }
    
        public Nullable<int> ivh_hdrnumber { get; set; }
        public int ivd_number { get; set; }
        public Nullable<int> stp_number { get; set; }
        public string ivd_description { get; set; }
        public string cht_itemcode { get; set; }
        public Nullable<double> ivd_quantity { get; set; }
        public Nullable<decimal> ivd_rate { get; set; }
        public Nullable<decimal> ivd_charge { get; set; }
        public string ivd_taxable1 { get; set; }
        public string ivd_taxable2 { get; set; }
        public string ivd_taxable3 { get; set; }
        public string ivd_taxable4 { get; set; }
        public string ivd_unit { get; set; }
        public string cur_code { get; set; }
        public Nullable<System.DateTime> ivd_currencydate { get; set; }
        public string ivd_glnum { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
        public string ivd_type { get; set; }
        public string ivd_rateunit { get; set; }
        public string ivd_billto { get; set; }
        public Nullable<double> ivd_itemquantity { get; set; }
        public Nullable<int> ivd_subtotalptr { get; set; }
        public Nullable<decimal> ivd_allocatedrev { get; set; }
        public Nullable<int> ivd_sequence { get; set; }
        public string ivd_invoicestatus { get; set; }
        public Nullable<int> mfh_hdrnumber { get; set; }
        public string ivd_refnum { get; set; }
        public string cmd_code { get; set; }
        public string cmp_id { get; set; }
        public Nullable<double> ivd_distance { get; set; }
        public string ivd_distunit { get; set; }
        public Nullable<double> ivd_wgt { get; set; }
        public string ivd_wgtunit { get; set; }
        public Nullable<decimal> ivd_count { get; set; }
        public string ivd_countunit { get; set; }
        public Nullable<int> evt_number { get; set; }
        public string ivd_reftype { get; set; }
        public Nullable<double> ivd_volume { get; set; }
        public string ivd_volunit { get; set; }
        public string ivd_orig_cmpid { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<decimal> ivd_payrevenue { get; set; }
        public Nullable<short> ivd_sign { get; set; }
        public Nullable<decimal> ivd_length { get; set; }
        public string ivd_lengthunit { get; set; }
        public Nullable<decimal> ivd_width { get; set; }
        public string ivd_widthunit { get; set; }
        public Nullable<decimal> ivd_height { get; set; }
        public string ivd_heightunit { get; set; }
        public string ivd_exportstatus { get; set; }
        public string cht_basisunit { get; set; }
        public string ivd_remark { get; set; }
        public Nullable<int> tar_number { get; set; }
        public string tar_tariffnumber { get; set; }
        public string tar_tariffitem { get; set; }
        public string ivd_fromord { get; set; }
        public string ivd_zipcode { get; set; }
        public Nullable<short> ivd_quantity_type { get; set; }
        public string cht_class { get; set; }
        public string ivd_mileagetable { get; set; }
        public Nullable<short> ivd_charge_type { get; set; }
        public string ivd_trl_rent { get; set; }
        public Nullable<System.DateTime> ivd_trl_rent_start { get; set; }
        public Nullable<System.DateTime> ivd_trl_rent_end { get; set; }
        public Nullable<short> ivd_rate_type { get; set; }
        public string last_updateby { get; set; }
        public Nullable<System.DateTime> last_updatedate { get; set; }
        public string cht_lh_min { get; set; }
        public string cht_lh_rev { get; set; }
        public string cht_lh_stl { get; set; }
        public string cht_lh_rpt { get; set; }
        public Nullable<int> cht_rollintolh { get; set; }
        public string cht_lh_prn { get; set; }
        public Nullable<int> fgt_number { get; set; }
        public Nullable<int> ivd_paylgh_number { get; set; }
        public string ivd_tariff_type { get; set; }
        public string ivd_taxid { get; set; }
        public Nullable<decimal> ivd_ordered_volume { get; set; }
        public Nullable<decimal> ivd_ordered_loadingmeters { get; set; }
        public Nullable<decimal> ivd_ordered_count { get; set; }
        public Nullable<decimal> ivd_ordered_weight { get; set; }
        public Nullable<decimal> ivd_loadingmeters { get; set; }
        public string ivd_loadingmeters_unit { get; set; }
        public string ivd_revtype1 { get; set; }
        public string ivd_hide { get; set; }
        public Nullable<decimal> ivd_baserate { get; set; }
        public Nullable<decimal> ivd_rawcharge2 { get; set; }
        public Nullable<decimal> ivd_oradjustment { get; set; }
        public Nullable<decimal> ivd_cbadjustment { get; set; }
        public Nullable<decimal> ivd_fsc { get; set; }
        public string ivd_splitbillratetype { get; set; }
        public Nullable<decimal> ivd_rawcharge { get; set; }
        public Nullable<int> ivd_bolid { get; set; }
        public Nullable<decimal> ivd_shared_wgt { get; set; }
        public string ivd_ARTaxAuth { get; set; }
        public Nullable<decimal> ivd_tollcost { get; set; }
        public string ivd_paid_indicator { get; set; }
        public Nullable<decimal> ivd_paid_amount { get; set; }
        public Nullable<decimal> ivd_miscmoney1 { get; set; }
        public Nullable<double> ivd_actual_quantity { get; set; }
        public string ivd_actual_unit { get; set; }
        public Nullable<decimal> ivd_tax_basis { get; set; }
        public string ivd_billable_flag { get; set; }
        public string ivd_post_invoice { get; set; }
        public Nullable<double> ivd_loaded_distance { get; set; }
        public Nullable<double> ivd_empty_distance { get; set; }
        public string fgt_supplier { get; set; }
        public string ivd_showas_cmpid { get; set; }
        public string ivd_ord_number { get; set; }
        public Nullable<int> ivd_leaseassetid { get; set; }
        public string ivd_MaskFromRating { get; set; }
        public Nullable<int> ivd_car_key { get; set; }
        public Nullable<double> ivd_allocated_quantity { get; set; }
        public Nullable<decimal> ivd_allocated_rate { get; set; }
        public Nullable<decimal> ivd_allocated_charge { get; set; }
        public Nullable<int> ivd_allocated_ivd_number { get; set; }
        public Nullable<int> dbsd_id_tariff { get; set; }
        public string ivd_allocation_type { get; set; }
        public Nullable<double> ivd_allocated_qty { get; set; }
        public Nullable<int> ivd_reconcile_tariff { get; set; }
        public string ivd_comment { get; set; }
        public Nullable<System.DateTime> ivd_transdate { get; set; }
        public Nullable<int> ivd_ico_pyd_number_parent { get; set; }
        public string ivd_description_type { get; set; }
        public byte[] dw_timestamp { get; set; }
        public Nullable<double> ivd_rated_qty { get; set; }
        public Nullable<decimal> ivd_rated_rate { get; set; }
        public Nullable<int> dbst_rollinto_tar { get; set; }
        public string ivd_customer_char1 { get; set; }
        public string ivd_branch { get; set; }
        public string ivd_delays { get; set; }
        public Nullable<double> ivd_rate_factor { get; set; }
        public Nullable<System.DateTime> ivd_billdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedRateAllocation> DedicatedRateAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailTax> InvoiceDetailTaxes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailTax> InvoiceDetailTaxes1 { get; set; }
    }
}