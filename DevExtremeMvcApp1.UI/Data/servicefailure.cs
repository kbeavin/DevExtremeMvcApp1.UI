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
    
    public partial class servicefailure
    {
        public int ord_hdrnumber { get; set; }
        public int sf_sequence_number { get; set; }
        public string trc_number { get; set; }
        public string trc_terminal { get; set; }
        public string mpp_id { get; set; }
        public string mpp_terminal { get; set; }
        public string trl_number { get; set; }
        public string trl_terminal { get; set; }
        public string cmp_id { get; set; }
        public System.DateTime sf_rescheduled_date { get; set; }
        public string sf_contacted_shipper { get; set; }
        public string sf_shipper_contact_name { get; set; }
        public Nullable<System.DateTime> sf_shipper_contact_date { get; set; }
        public string sf_contacted_consignee { get; set; }
        public string sf_consignee_contact_name { get; set; }
        public Nullable<System.DateTime> sf_consignee_contact_date { get; set; }
        public string sf_supervisor { get; set; }
        public int sft_cause_id { get; set; }
        public string sf_cause_description { get; set; }
        public int sft_effect_id { get; set; }
        public string sf_effect_description { get; set; }
        public string sf_investigator { get; set; }
        public string sf_corrective_action { get; set; }
        public string sf_product_release { get; set; }
        public System.DateTime sf_entereddate { get; set; }
        public string sf_updatedby { get; set; }
        public string sf_carrier_id { get; set; }
        public Nullable<System.DateTime> sf_incident_date { get; set; }
        public string sf_incident_location { get; set; }
        public string sf_incident_number { get; set; }
        public string sf_shipper_contact_format { get; set; }
        public string sf_consignee_contact_format { get; set; }
        public string sf_dangerous_hazardous { get; set; }
        public string old_id1 { get; set; }
        public string new_id1 { get; set; }
        public string old_id2 { get; set; }
        public string new_id2 { get; set; }
        public Nullable<System.DateTime> sf_shipper_rescheduled_date { get; set; }
        public Nullable<System.DateTime> sf_consignee_rescheduled_date { get; set; }
        public string sf_results_of_follow_up { get; set; }
        public string sf_name_of_qit_chairperson { get; set; }
        public Nullable<System.DateTime> sf_closure_date { get; set; }
        public string sf_deviation_type { get; set; }
        public Nullable<System.DateTime> sf_followed_up_date { get; set; }
        public string sf_followed_up { get; set; }
        public string sf_follow_up_required { get; set; }
    }
}