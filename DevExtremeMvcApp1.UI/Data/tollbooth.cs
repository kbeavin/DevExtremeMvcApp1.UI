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
    
    public partial class tollbooth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tollbooth()
        {
            this.tolls = new HashSet<toll>();
            this.tollroute_booth_mapping = new HashSet<tollroute_booth_mapping>();
        }
    
        public int tb_ident { get; set; }
        public string tb_status { get; set; }
        public string tb_name { get; set; }
        public string tb_vendor_name { get; set; }
        public string cht_itemcode { get; set; }
        public string pyt_itemcode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<toll> tolls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tollroute_booth_mapping> tollroute_booth_mapping { get; set; }
    }
}
