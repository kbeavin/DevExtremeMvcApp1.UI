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
    
    public partial class paperwork
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paperwork()
        {
            this.paperworkMiscs = new HashSet<paperworkMisc>();
        }
    
        public string abbr { get; set; }
        public string pw_received { get; set; }
        public int ord_hdrnumber { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<System.DateTime> pw_dt { get; set; }
        public string last_updatedby { get; set; }
        public Nullable<System.DateTime> last_updateddatetime { get; set; }
        public Nullable<int> lgh_number { get; set; }
        public string pw_imaged { get; set; }
        public int pw_ident { get; set; }
        public Nullable<int> Mov_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paperworkMisc> paperworkMiscs { get; set; }
    }
}
