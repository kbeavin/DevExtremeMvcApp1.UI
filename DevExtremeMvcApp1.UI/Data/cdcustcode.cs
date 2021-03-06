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
    
    public partial class cdcustcode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdcustcode()
        {
            this.cashcards = new HashSet<cashcard>();
            this.cdexpresscashes = new HashSet<cdexpresscash>();
            this.cdexpresschecks = new HashSet<cdexpresscheck>();
            this.cdfuelbills = new HashSet<cdfuelbill>();
        }
    
        public string cac_id { get; set; }
        public string ccc_id { get; set; }
        public string ccc_description { get; set; }
        public string plusless { get; set; }
        public string ccc_glnumber { get; set; }
        public string ccc_company { get; set; }
        public string ccc_skt_id { get; set; }
        public string ccc_revtype1 { get; set; }
        public int ccc_id_unique { get; set; }
        public Nullable<int> rowsec_rsrv_id { get; set; }
        public string brn_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cashcard> cashcards { get; set; }
        public virtual cdacctcode cdacctcode { get; set; }
        public virtual socketprofile socketprofile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdexpresscash> cdexpresscashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdexpresscheck> cdexpresschecks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdfuelbill> cdfuelbills { get; set; }
    }
}
