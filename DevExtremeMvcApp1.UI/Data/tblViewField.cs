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
    
    public partial class tblViewField
    {
        public int SN { get; set; }
        public Nullable<int> ViewNumber { get; set; }
        public string FieldName { get; set; }
        public bool IsRepeating { get; set; }
        public Nullable<int> FieldNumber { get; set; }
        public Nullable<short> FileNumber { get; set; }
        public Nullable<short> Required { get; set; }
        public string BusinessRule { get; set; }
        public Nullable<short> VerifyFile { get; set; }
        public Nullable<int> VerifyJoinField { get; set; }
        public string TTSFieldName { get; set; }
        public string SQLTableName { get; set; }
        public string SQLFieldName { get; set; }
        public Nullable<int> DefaultLength { get; set; }
        public Nullable<int> DefaultType { get; set; }
        public string DisplayedFieldName { get; set; }
        public string DispXfcTag { get; set; }
        public Nullable<int> BusinessRuleType { get; set; }
        public string Comments { get; set; }
        public string DefaultPrefix { get; set; }
        public string DefaultSuffix { get; set; }
        public string Default { get; set; }
        public Nullable<int> ClearWhenFinished { get; set; }
    
        public virtual tblView tblView { get; set; }
    }
}
