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
    
    public partial class toll_route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public toll_route()
        {
            this.tollroute_booth_mapping = new HashSet<tollroute_booth_mapping>();
        }
    
        public int tr_ident { get; set; }
        public int tr_origin_city { get; set; }
        public int tr_dest_city { get; set; }
        public string tr_loadstatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tollroute_booth_mapping> tollroute_booth_mapping { get; set; }
    }
}
