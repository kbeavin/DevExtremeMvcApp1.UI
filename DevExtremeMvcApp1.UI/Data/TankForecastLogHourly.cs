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
    
    public partial class TankForecastLogHourly
    {
        public int LogId { get; set; }
        public int HourOffset { get; set; }
        public int Reading1 { get; set; }
        public int Reading2 { get; set; }
        public int Reading3 { get; set; }
        public int Reading4 { get; set; }
        public int Reading5 { get; set; }
        public int Reading6 { get; set; }
        public int Reading7 { get; set; }
        public int Reading8 { get; set; }
        public int Reading9 { get; set; }
        public int Reading10 { get; set; }
    
        public virtual TankForecastLog TankForecastLog { get; set; }
    }
}
