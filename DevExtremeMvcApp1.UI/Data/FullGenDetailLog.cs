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
    
    public partial class FullGenDetailLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FullGenDetailLog()
        {
            this.RatingMessages = new HashSet<RatingMessage>();
        }
    
        public int fgdl_ident { get; set; }
        public int fgl_ident { get; set; }
        public string fgdl_Key_number { get; set; }
        public string fgdl_rated_flag { get; set; }
        public string fgdl_Key_type { get; set; }
    
        public virtual FullGenLog FullGenLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingMessage> RatingMessages { get; set; }
    }
}
