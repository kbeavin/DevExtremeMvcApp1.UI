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
    
    public partial class tariffcompaniesheader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tariffcompaniesheader()
        {
            this.tariffcompaniesdetails = new HashSet<tariffcompaniesdetail>();
        }
    
        public int tch_id { get; set; }
        public string tch_name { get; set; }
        public string tch_type { get; set; }
        public string tch_stopexcludeflag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tariffcompaniesdetail> tariffcompaniesdetails { get; set; }
    }
}