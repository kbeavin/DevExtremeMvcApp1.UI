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
    
    public partial class dx_archive_audit
    {
        public long dxa_ident { get; set; }
        public System.DateTime dxa_upd_date { get; set; }
        public string dxa_upd_user { get; set; }
        public string dxa_upd_app { get; set; }
        public string Orignalvalue { get; set; }
        public string RecordValue { get; set; }
        public string evf_key { get; set; }
        public string evf_dxarchivesequence { get; set; }
        public string DisplayName { get; set; }
        public Nullable<bool> Ismodified { get; set; }
        public Nullable<bool> Evaluate { get; set; }
        public Nullable<bool> NotInRange { get; set; }
        public Nullable<bool> Revert { get; set; }
        public Nullable<bool> Isnew { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsOverwrite { get; set; }
        public Nullable<bool> IsRevertable { get; set; }
        public Nullable<bool> IsDisplayOnly { get; set; }
        public string MiscReferenceValue { get; set; }
        public Nullable<long> dx_ident { get; set; }
        public string dx_sourcename { get; set; }
        public Nullable<int> dx_seq { get; set; }
        public string dx_ordernumber { get; set; }
        public Nullable<int> dx_orderhdrnumber { get; set; }
        public string dx_billto { get; set; }
        public string dx_trpid { get; set; }
        public string dx_processed { get; set; }
    }
}
