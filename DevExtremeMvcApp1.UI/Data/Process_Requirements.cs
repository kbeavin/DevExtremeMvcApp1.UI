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
    
    public partial class Process_Requirements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Process_Requirements()
        {
            this.rnr_masks = new HashSet<rnr_masks>();
        }
    
        public int prq_id { get; set; }
        public string prq_billto { get; set; }
        public string prq_reftype { get; set; }
        public string prq_reftable { get; set; }
        public string prq_required { get; set; }
        public string prq_210export { get; set; }
        public string prq_214export { get; set; }
        public string prq_210check { get; set; }
        public string prq_stopstatusfield { get; set; }
        public string prq_stopstatus { get; set; }
        public string prq_ordstatus { get; set; }
        public string prq_stoptype { get; set; }
        public string prq_activitytable { get; set; }
        public string prq_reftype_validatemask { get; set; }
        public string prq_cmp_role { get; set; }
        public string prq_terms { get; set; }
        public string prq_cmpid { get; set; }
        public string prq_invoicestatus { get; set; }
        public Nullable<int> prq_reftype_validatevalidateproc { get; set; }
        public string prq_optional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rnr_masks> rnr_masks { get; set; }
    }
}
