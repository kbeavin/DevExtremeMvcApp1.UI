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
    
    public partial class ProductPrice
    {
        public long ID { get; set; }
        public string Shipper { get; set; }
        public string Supplier { get; set; }
        public string AccountOf { get; set; }
        public string Consignee { get; set; }
        public string CommodityCode { get; set; }
        public string PriceSource { get; set; }
        public decimal Price { get; set; }
        public System.DateTime EffectiveStartDate { get; set; }
        public System.DateTime EffectiveEndDate { get; set; }
        public decimal Overhead { get; set; }
        public decimal ProductTaxes { get; set; }
        public decimal CompanyTaxes { get; set; }
        public decimal TotalMarkups { get; set; }
        public decimal Transportation { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
