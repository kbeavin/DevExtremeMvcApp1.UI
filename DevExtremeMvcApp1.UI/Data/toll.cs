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
    
    public partial class toll
    {
        public int toll_ident { get; set; }
        public int tb_ident { get; set; }
        public int tb_axlecount { get; set; }
        public decimal tb_cash_toll { get; set; }
        public decimal tb_card_toll { get; set; }
    
        public virtual tollbooth tollbooth { get; set; }
    }
}