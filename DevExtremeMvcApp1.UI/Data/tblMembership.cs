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
    
    public partial class tblMembership
    {
        public int SN { get; set; }
        public Nullable<int> Member { get; set; }
        public Nullable<int> GroupSN { get; set; }
    
        public virtual tblAddressBook tblAddressBook { get; set; }
        public virtual tblGroup tblGroup { get; set; }
    }
}