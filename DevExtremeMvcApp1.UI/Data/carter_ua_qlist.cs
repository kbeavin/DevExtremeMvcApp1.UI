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
    
    public partial class carter_ua_qlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carter_ua_qlist()
        {
            this.carter_ua_logsub = new HashSet<carter_ua_logsub>();
        }
    
        public int uaq_id { get; set; }
        public string uaq_text { get; set; }
        public Nullable<int> uaq_uaml_mlid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carter_ua_logsub> carter_ua_logsub { get; set; }
        public virtual carter_ua_masterlist carter_ua_masterlist { get; set; }
    }
}
