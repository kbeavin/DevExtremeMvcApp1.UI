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
    
    public partial class tblDriver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDriver()
        {
            this.tblHistories = new HashSet<tblHistory>();
        }
    
        public int SN { get; set; }
        public string DriverID { get; set; }
        public Nullable<int> CurrentTruck { get; set; }
        public string DispSysDriverID { get; set; }
        public string Name { get; set; }
        public Nullable<int> CurrentDispatcher { get; set; }
        public Nullable<int> InBox { get; set; }
        public Nullable<int> OutBox { get; set; }
        public bool Retired { get; set; }
        public bool KeepHistory { get; set; }
        public bool InternetMailToDriver { get; set; }
        public bool InternetMailFromDriver { get; set; }
        public string MAPIProfile { get; set; }
        public string MAPIPassword { get; set; }
        public string InternetAlias { get; set; }
        public int UseAdminMailBox { get; set; }
        public string SMTPReplyAddress { get; set; }
        public string EmailFolderID { get; set; }
        public int AfterEmailSend { get; set; }
        public string SMTPLogin { get; set; }
        public string SMTPPassword { get; set; }
        public string EMailFolderName { get; set; }
        public string AlternateID { get; set; }
        public string DriverPassword { get; set; }
        public Nullable<int> DefaultCabUnit { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public Nullable<int> MaxDelayMins { get; set; }
        public Nullable<System.DateTime> DelayedUntil { get; set; }
        public Nullable<int> PositionsBox { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHistory> tblHistories { get; set; }
    }
}