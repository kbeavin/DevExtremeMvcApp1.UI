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
    
    public partial class CarrierCSALogHdr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarrierCSALogHdr()
        {
            this.CarrierCSALogDtls = new HashSet<CarrierCSALogDtl>();
        }
    
        public int id { get; set; }
        public string ProviderName { get; set; }
        public System.DateTime lastupdatedate { get; set; }
        public string lastupdateuser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarrierCSALogDtl> CarrierCSALogDtls { get; set; }
    }
}
