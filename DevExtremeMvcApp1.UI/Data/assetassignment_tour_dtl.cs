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
    
    public partial class assetassignment_tour_dtl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assetassignment_tour_dtl()
        {
            this.paydetails = new HashSet<paydetail>();
        }
    
        public int atd_id { get; set; }
        public int ath_id { get; set; }
        public int asgn_number { get; set; }
        public int lgh_number { get; set; }
        public string last_updateby { get; set; }
        public Nullable<System.DateTime> last_updatedate { get; set; }
    
        public virtual assetassignment assetassignment { get; set; }
        public virtual assetassignment_tour_hdr assetassignment_tour_hdr { get; set; }
        public virtual legheader legheader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paydetail> paydetails { get; set; }
    }
}