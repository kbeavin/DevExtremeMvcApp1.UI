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
    
    public partial class RMXML_CarrierCoverage
    {
        public int id { get; set; }
        public int TmwXmlImportLog_id { get; set; }
        public Nullable<int> RootElementID { get; set; }
        public Nullable<int> ParentLevel { get; set; }
        public Nullable<int> CurrentLevel { get; set; }
        public string CoverageDescription { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string PolicyNumber { get; set; }
        public string Producer { get; set; }
        public string ProducerPhone { get; set; }
        public string ProducerFax { get; set; }
        public string ProducerEmail { get; set; }
        public string Underwriter { get; set; }
        public string Confidence { get; set; }
        public string RMISCertID { get; set; }
        public string RMISCovgID { get; set; }
        public Nullable<System.DateTime> LastCertUpdate { get; set; }
        public string ConfidenceMsg { get; set; }
        public string RMISImageID { get; set; }
        public string Tmw_SynchStatus { get; set; }
        public System.DateTime lastupdatedate { get; set; }
        public string lastupdateuser { get; set; }
        public string NAICCompanyNumber { get; set; }
        public string AMBestCompanyNumber { get; set; }
        public string ProducerAddress { get; set; }
        public string ProducerCity { get; set; }
        public string ProducerState { get; set; }
        public string ProducerZip { get; set; }
        public string UnderwriterRating { get; set; }
    }
}
