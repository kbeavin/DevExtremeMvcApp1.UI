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
    
    public partial class cdtranscheck_cashcode
    {
        public int ctcc_id { get; set; }
        public int ctc_id { get; set; }
        public decimal ctcc_cashamount { get; set; }
        public string ctcc_cashcode { get; set; }
    
        public virtual cdtranscheck cdtranscheck { get; set; }
    }
}