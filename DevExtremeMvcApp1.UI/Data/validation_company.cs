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
    
    public partial class validation_company
    {
        public int valco_valcg_id { get; set; }
        public string valco_cmp_id { get; set; }
        public string valco_used_as { get; set; }
        public string valco_create_user { get; set; }
        public Nullable<System.DateTime> valco_create_date { get; set; }
        public string valco_update_user { get; set; }
        public Nullable<System.DateTime> valco_update_date { get; set; }
    
        public virtual company company { get; set; }
        public virtual validation_company_group validation_company_group { get; set; }
    }
}
