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
    
    public partial class Carter_FuelEconomy
    {
        public int FE_Manager { get; set; }
        public string FE_trcnumber { get; set; }
        public string FE_DriverID { get; set; }
        public string FE_Driver2ID { get; set; }
        public int FE_Distance { get; set; }
        public int FE_EngTime { get; set; }
        public Nullable<int> FE_Fuel { get; set; }
        public Nullable<decimal> FE_MPG { get; set; }
        public decimal FE_Idle { get; set; }
        public Nullable<System.DateTime> FE_PeriodStart { get; set; }
        public Nullable<System.DateTime> FE_PeriodEnd { get; set; }
        public System.DateTime FE_DateAdded { get; set; }
        public string FE_AddedBy { get; set; }
    }
}