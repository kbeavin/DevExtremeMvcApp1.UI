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
    
    public partial class StateFuelTax
    {
        public int sft_id { get; set; }
        public string sftState { get; set; }
        public System.DateTime sftDate { get; set; }
        public decimal sftRate { get; set; }
        public string sftcreatedby { get; set; }
        public Nullable<System.DateTime> sftcreatedate { get; set; }
        public string sftupdatedby { get; set; }
        public Nullable<System.DateTime> sftupdatedate { get; set; }
        public Nullable<decimal> sftrateoverabove { get; set; }
        public Nullable<decimal> sftratepermile { get; set; }
        public string sftExcludeTollMiles { get; set; }
        public string country_code { get; set; }
        public Nullable<System.DateTime> sftend_date { get; set; }
        public Nullable<double> gross_min_wgt { get; set; }
        public Nullable<double> gross_max_wgt { get; set; }
        public string fuel_type { get; set; }
        public string fleet { get; set; }
        public string fuel_mileage_tax_type { get; set; }
    }
}
