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
    
    public partial class inout_chart_def
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inout_chart_def()
        {
            this.inout_chart_det = new HashSet<inout_chart_det>();
        }
    
        public string chart_def_number { get; set; }
        public string chart_def_type { get; set; }
        public string chart_def_collar { get; set; }
        public string chart_def_note { get; set; }
        public string chart_def_height { get; set; }
        public string chart_def_unit_of_measure { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inout_chart_det> inout_chart_det { get; set; }
    }
}
