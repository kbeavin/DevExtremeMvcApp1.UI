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
    
    public partial class DTNPricing
    {
        public long ID { get; set; }
        public string Shipper { get; set; }
        public string Supplier { get; set; }
        public string CommodityCode { get; set; }
        public System.DateTime PriceDate { get; set; }
        public decimal Price { get; set; }
        public decimal Delta { get; set; }
        public string PriceSource { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string AccountOf { get; set; }
    }
}
