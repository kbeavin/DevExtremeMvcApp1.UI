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
    
    public partial class ini_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ini_group()
        {
            this.ini_xref_group_user = new HashSet<ini_xref_group_user>();
        }
    
        public int group_id { get; set; }
        public string group_name { get; set; }
        public System.DateTime created { get; set; }
        public string created_by { get; set; }
        public System.DateTime updated { get; set; }
        public string updated_by { get; set; }
        public string active { get; set; }
        public string comment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ini_xref_group_user> ini_xref_group_user { get; set; }
    }
}
