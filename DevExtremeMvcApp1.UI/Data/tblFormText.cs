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
    
    public partial class tblFormText
    {
        public int SN { get; set; }
        public Nullable<short> ControlNumber { get; set; }
        public Nullable<int> FormSN { get; set; }
        public string Name { get; set; }
        public Nullable<short> Row { get; set; }
        public Nullable<short> Col { get; set; }
        public Nullable<short> Len { get; set; }
        public string Text { get; set; }
        public string Caption { get; set; }
        public bool Visible { get; set; }
        public Nullable<int> DispatcherOnly { get; set; }
        public Nullable<int> NoPreview { get; set; }
    
        public virtual tblForm tblForm { get; set; }
    }
}
