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
    
    public partial class RowSecColumn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RowSecColumn()
        {
            this.RowSecColumnValues = new HashSet<RowSecColumnValue>();
        }
    
        public int rsc_id { get; set; }
        public bool rsc_system_locked { get; set; }
        public int rst_id { get; set; }
        public string rsc_column_name { get; set; }
        public string labeldefinition_values { get; set; }
        public string labeldefinition_description { get; set; }
        public string rsc_description { get; set; }
        public bool rsc_selected { get; set; }
        public short rsc_sequence { get; set; }
        public string rsc_unknown_value { get; set; }
    
        public virtual RowSecTable RowSecTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RowSecColumnValue> RowSecColumnValues { get; set; }
    }
}
