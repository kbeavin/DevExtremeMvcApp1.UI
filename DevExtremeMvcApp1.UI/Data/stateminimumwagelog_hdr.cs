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
    
    public partial class stateminimumwagelog_hdr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stateminimumwagelog_hdr()
        {
            this.stateminimumwagelog_dtl = new HashSet<stateminimumwagelog_dtl>();
        }
    
        public int smwlh_id { get; set; }
        public System.DateTime processed_pay_period { get; set; }
        public System.DateTime applicable_pay_period_begin { get; set; }
        public System.DateTime applicable_pay_period_end { get; set; }
        public string last_updateby { get; set; }
        public Nullable<System.DateTime> last_updatedate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stateminimumwagelog_dtl> stateminimumwagelog_dtl { get; set; }
    }
}
