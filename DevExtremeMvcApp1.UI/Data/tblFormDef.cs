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
    
    public partial class tblFormDef
    {
        public short FormID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<short> Direction { get; set; }
        public string DateModified { get; set; }
        public string DataSource { get; set; }
        public Nullable<short> TransactionID { get; set; }
        public bool Activate { get; set; }
        public string LastActivatedDate { get; set; }
        public Nullable<short> AllowUpdate { get; set; }
    }
}