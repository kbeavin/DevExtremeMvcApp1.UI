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
    
    public partial class leaseagreement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public leaseagreement()
        {
            this.leaseagreement_assets = new HashSet<leaseagreement_assets>();
        }
    
        public int la_recordid { get; set; }
        public string la_company { get; set; }
        public string la_leaseagreement { get; set; }
        public int la_leaseagreementrevision { get; set; }
        public string la_leaseagreementremark { get; set; }
        public System.DateTime la_effectiveon { get; set; }
        public System.DateTime la_expireson { get; set; }
        public string la_billingterms { get; set; }
        public string la_createdby { get; set; }
        public Nullable<System.DateTime> la_createdon { get; set; }
        public string la_updatedby { get; set; }
        public Nullable<System.DateTime> la_updatedon { get; set; }
    
        public virtual company company { get; set; }
        public virtual company company1 { get; set; }
        public virtual company company2 { get; set; }
        public virtual company company3 { get; set; }
        public virtual company company4 { get; set; }
        public virtual company company5 { get; set; }
        public virtual company company6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leaseagreement_assets> leaseagreement_assets { get; set; }
    }
}