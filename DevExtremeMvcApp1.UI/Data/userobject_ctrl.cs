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
    
    public partial class userobject_ctrl
    {
        public int id { get; set; }
        public string control { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string visible { get; set; }
        public string enable { get; set; }
        public string text { get; set; }
        public byte[] timestamp { get; set; }
    
        public virtual userobject userobject { get; set; }
    }
}