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
    
    public partial class RMXML_PHMSA
    {
        public int id { get; set; }
        public int TmwXmlImportLog_id { get; set; }
        public Nullable<int> RootElementID { get; set; }
        public Nullable<int> ParentLevel { get; set; }
        public Nullable<int> CurrentLevel { get; set; }
        public Nullable<int> DotNumber { get; set; }
        public string MCNumber { get; set; }
        public string ContactName { get; set; }
        public string Mailing_Street { get; set; }
        public string Mailing_City { get; set; }
        public string Mailing_State { get; set; }
        public string Mailing_Zip { get; set; }
        public string Mailing_Country { get; set; }
        public string Physical_Street { get; set; }
        public string Physical_City { get; set; }
        public string Physical_State { get; set; }
        public string Physical_Zip { get; set; }
        public string Physical_Country { get; set; }
        public string HMCompanyID { get; set; }
        public string RailroadCode { get; set; }
        public string RegYearRaw { get; set; }
        public Nullable<System.DateTime> RegistrationExpiration { get; set; }
        public string RegistrationID { get; set; }
        public string Suspended { get; set; }
        public string IsValid { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> LastChecked { get; set; }
        public string Tmw_SynchStatus { get; set; }
        public System.DateTime lastupdatedate { get; set; }
        public string lastupdateuser { get; set; }
    }
}
