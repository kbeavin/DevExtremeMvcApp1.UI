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
    
    public partial class socketprofile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public socketprofile()
        {
            this.cdcustcodes = new HashSet<cdcustcode>();
        }
    
        public string skt_id { get; set; }
        public string skt_desc { get; set; }
        public byte skt_addfamily { get; set; }
        public byte skt_type { get; set; }
        public byte skt_protocol { get; set; }
        public byte skt_namelength { get; set; }
        public string skt_ipaddress { get; set; }
        public Nullable<int> skt_port { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdcustcode> cdcustcodes { get; set; }
    }
}