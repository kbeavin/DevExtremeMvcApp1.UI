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
    
    public partial class tblFolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFolder()
        {
            this.tblMessages_PreTMSplit = new HashSet<tblMessages_PreTMSplit>();
        }
    
        public int SN { get; set; }
        public Nullable<int> Parent { get; set; }
        public string Name { get; set; }
        public Nullable<int> Owner { get; set; }
        public bool IsPublic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMessages_PreTMSplit> tblMessages_PreTMSplit { get; set; }
    }
}
