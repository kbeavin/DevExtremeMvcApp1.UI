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
    
    public partial class WebSystemsLinkToken
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebSystemsLinkToken()
        {
            this.WebSystemsLinkLogs = new HashSet<WebSystemsLinkLog>();
        }
    
        public long TokenID { get; set; }
        public Nullable<long> UserID { get; set; }
        public string Token { get; set; }
        public string Active { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> DeactivatedDate { get; set; }
        public string ttsUserId { get; set; }
        public string SymmetricIv { get; set; }
        public string SymmetricKey { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
    
        public virtual WebSystemsLinkCredential WebSystemsLinkCredential { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebSystemsLinkLog> WebSystemsLinkLogs { get; set; }
    }
}
