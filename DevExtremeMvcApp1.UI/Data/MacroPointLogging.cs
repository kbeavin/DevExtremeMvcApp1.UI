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
    
    public partial class MacroPointLogging
    {
        public string CustomerId { get; set; }
        public string LoadId { get; set; }
        public string VehicleId { get; set; }
        public string CustomerLoadId { get; set; }
        public System.DateTime DateAndTimeOfLocationUpdate { get; set; }
        public Nullable<int> LatitudeSeconds { get; set; }
        public Nullable<int> LongitudeSeconds { get; set; }
        public System.DateTime TimeSent { get; set; }
    }
}