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
    
    public partial class FullGenLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FullGenLog()
        {
            this.FullGenDetailLogs = new HashSet<FullGenDetailLog>();
        }
    
        public int fgl_ident { get; set; }
        public string fgl_type { get; set; }
        public string fgl_event { get; set; }
        public System.DateTime fgl_date { get; set; }
        public string fgl_user_id { get; set; }
        public string fgl_branch { get; set; }
        public string fgl_billto { get; set; }
        public System.DateTime fgl_prior_close_date { get; set; }
        public System.DateTime fgl_process_through_date { get; set; }
        public Nullable<int> fgl_process_time_seconds { get; set; }
        public Nullable<int> fgl_totalitems_processed { get; set; }
        public string fgl_success { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FullGenDetailLog> FullGenDetailLogs { get; set; }
    }
}