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
    
    public partial class carter_ua_masterlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carter_ua_masterlist()
        {
            this.carter_ua_log = new HashSet<carter_ua_log>();
            this.carter_ua_qlist = new HashSet<carter_ua_qlist>();
        }
    
        public int uaml_mlid { get; set; }
        public Nullable<int> uaml_ttsgroup { get; set; }
        public string uaml_mlname { get; set; }
        public string uaml_release { get; set; }
        public string uaml_refnum { get; set; }
        public string uaml_reftype { get; set; }
        public int uaml_uaa_id { get; set; }
    
        public virtual carter_ua_applist carter_ua_applist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carter_ua_log> carter_ua_log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carter_ua_qlist> carter_ua_qlist { get; set; }
    }
}
