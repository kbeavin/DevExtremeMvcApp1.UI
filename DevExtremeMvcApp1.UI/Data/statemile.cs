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
    
    public partial class statemile
    {
        public int sm_type { get; set; }
        public string sm_origintype { get; set; }
        public string sm_origin { get; set; }
        public string sm_destinationtype { get; set; }
        public string sm_destination { get; set; }
        public int sm_sequence { get; set; }
        public string sm_state { get; set; }
        public Nullable<decimal> sm_freemiles { get; set; }
        public Nullable<decimal> sm_tollmiles { get; set; }
        public string sm_updatedby { get; set; }
        public Nullable<System.DateTime> sm_updatedon { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> mt_Identity { get; set; }
        public string sm_statemiles_type1 { get; set; }
        public string sm_statemiles_type2 { get; set; }
        public Nullable<double> sm_miles { get; set; }
    }
}
