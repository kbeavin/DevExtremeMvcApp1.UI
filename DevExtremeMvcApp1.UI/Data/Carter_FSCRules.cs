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
    
    public partial class Carter_FSCRules
    {
        public int FSCR_ID { get; set; }
        public decimal FSCR_ChargeRange { get; set; }
        public double FSCR_IncrementMultiplier { get; set; }
        public string FSCR_Route { get; set; }
        public string FSCR_ParentCompany { get; set; }
        public decimal FSCR_LHRatePerMile { get; set; }
        public bool FSCR_IsFlateRate { get; set; }
        public System.DateTime FSCR_Createdate { get; set; }
        public string FSCR_CreatedBy { get; set; }
        public System.DateTime FSCR_EffectiveDateStart { get; set; }
        public System.DateTime FSCR_EffectiveDateEnd { get; set; }
        public Nullable<decimal> FSCR_FuelAverageBase { get; set; }
    }
}
