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
    
    public partial class cdcheck_layout
    {
        public int cdh_vendor { get; set; }
        public string cdl_columnname { get; set; }
        public int cdl_columnstart { get; set; }
        public int cdl_columnlength { get; set; }
        public Nullable<int> cdl_decimalplaces { get; set; }
    
        public virtual cdcheck_columnlist cdcheck_columnlist { get; set; }
        public virtual cdcheck_header cdcheck_header { get; set; }
    }
}
