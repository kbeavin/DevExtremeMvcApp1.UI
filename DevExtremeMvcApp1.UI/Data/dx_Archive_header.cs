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
    
    public partial class dx_Archive_header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dx_Archive_header()
        {
            this.dx_Archive_detail = new HashSet<dx_Archive_detail>();
        }
    
        public long dx_Archive_header_id { get; set; }
        public string dx_importid { get; set; }
        public string dx_sourcename { get; set; }
        public System.DateTime dx_sourcedate { get; set; }
        public string dx_updated { get; set; }
        public Nullable<bool> dx_accepted { get; set; }
        public string dx_ordernumber { get; set; }
        public Nullable<int> dx_orderhdrnumber { get; set; }
        public Nullable<int> dx_movenumber { get; set; }
        public string dx_manifestnumber { get; set; }
        public Nullable<int> dx_batchref { get; set; }
        public string dx_doctype { get; set; }
        public string dx_docnumber { get; set; }
        public string dx_createdby { get; set; }
        public Nullable<System.DateTime> dx_createdate { get; set; }
        public string dx_updatedby { get; set; }
        public Nullable<System.DateTime> dx_updatedate { get; set; }
        public string dx_processed { get; set; }
        public string dx_trpid { get; set; }
        public Nullable<System.DateTime> dx_sourcedate_reference { get; set; }
        public string dx_billto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dx_Archive_detail> dx_Archive_detail { get; set; }
    }
}
