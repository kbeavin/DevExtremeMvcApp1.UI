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
    
    public partial class RMXML_W9
    {
        public int id { get; set; }
        public int TmwXmlImportLog_id { get; set; }
        public Nullable<int> RootElementID { get; set; }
        public Nullable<int> ParentLevel { get; set; }
        public Nullable<int> CurrentLevel { get; set; }
        public Nullable<int> W9ID { get; set; }
        public string TaxID { get; set; }
        public string CoName { get; set; }
        public string BusinessName { get; set; }
        public string CompanyType { get; set; }
        public string IsLimitedLiabCo { get; set; }
        public string LimitedLiabTaxClass { get; set; }
        public string IsExemptPayee { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ST { get; set; }
        public string Zip { get; set; }
        public string ContactName { get; set; }
        public string TINIsValid { get; set; }
        public string TINValidationReason { get; set; }
        public Nullable<System.DateTime> TINCheckedDate { get; set; }
        public string TINCheckedBy { get; set; }
        public string TaxIDEIN { get; set; }
        public string TaxIDSSN { get; set; }
        public string Tmw_SynchStatus { get; set; }
        public System.DateTime lastupdatedate { get; set; }
        public string lastupdateuser { get; set; }
        public string ExemptPayeeCode { get; set; }
        public string ExemptFATCAcode { get; set; }
    }
}
