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
    
    public partial class commodityclass
    {
        public string ccl_code { get; set; }
        public string ccl_description { get; set; }
        public string alk_hazlevel { get; set; }
        public string rand_hazlevel { get; set; }
        public string other_hazlevel { get; set; }
        public string default_uom { get; set; }
        public bool ccl_isretired { get; set; }
        public Nullable<int> ccl_displayorder { get; set; }
        public string ccl_exclusive { get; set; }
        public string ccl_volumefromloads { get; set; }
    }
}