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
    
    public partial class cdcheck_header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdcheck_header()
        {
            this.cdcheck_layout = new HashSet<cdcheck_layout>();
        }
    
        public int cdh_vendor { get; set; }
        public string cdh_vendorname { get; set; }
        public string cdh_vendorshortname { get; set; }
        public string cdh_licensekey { get; set; }
        public string cdh_match { get; set; }
        public string cdh_pyt_itemcode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdcheck_layout> cdcheck_layout { get; set; }
    }
}