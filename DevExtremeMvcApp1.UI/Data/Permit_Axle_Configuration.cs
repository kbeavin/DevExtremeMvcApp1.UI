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
    
    public partial class Permit_Axle_Configuration
    {
        public int PAC_ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public short PAC_AxleNumber { get; set; }
        public Nullable<double> PAC_PreviousDistance { get; set; }
        public Nullable<short> PAC_TireCount { get; set; }
        public Nullable<short> PAC_TireSize { get; set; }
        public Nullable<double> PAC_Pad { get; set; }
        public Nullable<int> PAC_LoadWeight { get; set; }
        public Nullable<int> PAC_MaxWeight { get; set; }
        public Nullable<double> PAC_Width { get; set; }
        public string PAC_ScaledWeightType { get; set; }
        public Nullable<int> PAC_ScaledWeight { get; set; }
        public Nullable<double> PAC_OverHang { get; set; }
        public string pac_tirespec { get; set; }
        public Nullable<int> pac_tirerating { get; set; }
    
        public virtual Permit Permit { get; set; }
    }
}
