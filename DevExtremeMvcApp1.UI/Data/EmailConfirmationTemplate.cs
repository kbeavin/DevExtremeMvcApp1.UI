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
    
    public partial class EmailConfirmationTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailConfirmationTemplate()
        {
            this.EmailConfirmationTemplateCarriers = new HashSet<EmailConfirmationTemplateCarrier>();
        }
    
        public int ect_id { get; set; }
        public string ect_description { get; set; }
        public string ect_subject { get; set; }
        public string ect_body { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailConfirmationTemplateCarrier> EmailConfirmationTemplateCarriers { get; set; }
    }
}