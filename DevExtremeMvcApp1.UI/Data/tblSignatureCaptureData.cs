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
    
    public partial class tblSignatureCaptureData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSignatureCaptureData()
        {
            this.tblSignatureCaptureImages = new HashSet<tblSignatureCaptureImage>();
        }
    
        public int SN { get; set; }
        public int stp_number { get; set; }
        public int msg_SN { get; set; }
        public string signatureid { get; set; }
        public string signaturename { get; set; }
        public Nullable<int> retrievecount { get; set; }
        public System.DateTime receiveddate { get; set; }
        public string vendor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSignatureCaptureImage> tblSignatureCaptureImages { get; set; }
    }
}
