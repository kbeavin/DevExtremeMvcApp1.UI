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
    
    public partial class Permit_Issuing_Authority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permit_Issuing_Authority()
        {
            this.Permit_Master = new HashSet<Permit_Master>();
            this.Permit_Route = new HashSet<Permit_Route>();
        }
    
        public int PIA_ID { get; set; }
        public string PIA_Type { get; set; }
        public string PIA_Name { get; set; }
        public string st_abbr { get; set; }
        public Nullable<int> cty_code { get; set; }
        public string cty_nmstct { get; set; }
        public string PIA_Contact { get; set; }
        public string PIA_ContactPhone { get; set; }
        public string PIA_ContactFax { get; set; }
        public string PIA_ContactEmail { get; set; }
        public string PIA_Website { get; set; }
        public string PIA_FTPAddress { get; set; }
        public string PIA_FTPLogin { get; set; }
        public string PIA_FTPPassword { get; set; }
        public string PIA_Contact2 { get; set; }
        public string PIA_Contact2Phone { get; set; }
        public string PIA_Contact2Fax { get; set; }
        public string PIA_Contact2Email { get; set; }
        public string PIA_Mail_Address1 { get; set; }
        public string PIA_Mail_Address2 { get; set; }
        public Nullable<int> PIA_Mail_City { get; set; }
        public string PIA_Mail_City_nmstct { get; set; }
        public string PIA_Mail_Zip { get; set; }
        public Nullable<int> pia_max_gvw { get; set; }
        public byte[] pia_timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permit_Master> Permit_Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permit_Route> Permit_Route { get; set; }
    }
}