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
    
    public partial class EmailConfirmationTemplateCarrier
    {
        public int ectc_id { get; set; }
        public int ect_id { get; set; }
        public string carrier_id { get; set; }
    
        public virtual EmailConfirmationTemplate EmailConfirmationTemplate { get; set; }
    }
}
