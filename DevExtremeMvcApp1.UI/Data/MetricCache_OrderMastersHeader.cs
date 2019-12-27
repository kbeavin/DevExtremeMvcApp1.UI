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
    
    public partial class MetricCache_OrderMastersHeader
    {
        public string MetricCode { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string MasterOrder { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Terminal { get; set; }
        public Nullable<double> StopsPerOccurance { get; set; }
        public Nullable<decimal> LineHaul { get; set; }
        public Nullable<decimal> AssessorialAllocation { get; set; }
        public Nullable<decimal> Revenue { get; set; }
        public Nullable<double> MilesPerOccurance { get; set; }
        public Nullable<decimal> STLAmount { get; set; }
        public Nullable<decimal> RevPerMile { get; set; }
        public Nullable<double> TractorsUsed { get; set; }
        public Nullable<double> TrailersUsed { get; set; }
        public Nullable<double> DriversUsed { get; set; }
        public Nullable<double> NumberOfDays { get; set; }
        public Nullable<double> Occurance { get; set; }
        public Nullable<decimal> GrossProfit { get; set; }
        public Nullable<decimal> DriverCost { get; set; }
        public Nullable<decimal> PowerCost { get; set; }
        public Nullable<decimal> TrailerCost { get; set; }
        public Nullable<decimal> MaintCost { get; set; }
        public Nullable<decimal> FuelCost { get; set; }
        public Nullable<decimal> Overhead { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public Nullable<decimal> MarginTotal { get; set; }
        public int MetricCache_OrderMastersHeader_ident { get; set; }
    }
}
