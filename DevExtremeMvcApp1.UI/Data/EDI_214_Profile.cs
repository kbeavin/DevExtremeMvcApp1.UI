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
    
    public partial class EDI_214_Profile
    {
        public int e214_id { get; set; }
        public string e214_cmp_id { get; set; }
        public string e214_level { get; set; }
        public string e214_ps_status { get; set; }
        public string e214_edi_status { get; set; }
        public string e214_status_table_version { get; set; }
        public string e214_triggering_activity { get; set; }
        public string e214_consolidationlevel { get; set; }
        public string e214_latenoreason_handling { get; set; }
        public Nullable<short> e214_sequence { get; set; }
        public Nullable<int> e214_stp_position { get; set; }
        public string automail { get; set; }
        public string shipper { get; set; }
        public string consignee { get; set; }
        public string thirdparty { get; set; }
        public string e214_ReplicateForEachDropFlag { get; set; }
        public string billto_role_flag { get; set; }
        public string shipper_role_flag { get; set; }
        public string consignee_role_flag { get; set; }
        public string orderby_role_flag { get; set; }
        public string notify_by_edi_flag { get; set; }
        public string notify_by_email_flag { get; set; }
        public string notify_by_fax_flag { get; set; }
        public Nullable<double> e214_wgt_qty { get; set; }
        public string e214_wgt_oper { get; set; }
        public Nullable<double> e214_count_qty { get; set; }
        public string e214_count_oper { get; set; }
        public Nullable<double> e214_volume_qty { get; set; }
        public string e214_volume_oper { get; set; }
        public string e214_trlreq_flag { get; set; }
        public string e214_latedeparture_handling { get; set; }
        public string e214_enforce_sequence { get; set; }
        public string e214_ref_from_drp { get; set; }
    }
}