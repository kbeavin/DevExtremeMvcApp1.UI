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
    
    public partial class TMSOrderLineItem
    {
        public int LineItemId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public short LineNumber { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public Nullable<decimal> QuanityToShip { get; set; }
        public Nullable<decimal> Quantity1 { get; set; }
        public Nullable<decimal> Quantity2 { get; set; }
        public Nullable<decimal> Quantity3 { get; set; }
        public string SKU { get; set; }
        public string FreightClass { get; set; }
        public string cmd_code { get; set; }
        public string LineItemType1 { get; set; }
        public string LineItemType2 { get; set; }
        public string LineItemType3 { get; set; }
        public string LineItemType4 { get; set; }
        public string LineItemType5 { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> Items { get; set; }
        public Nullable<decimal> Cases { get; set; }
        public Nullable<decimal> Pallets { get; set; }
        public string QuanityToShipUnit { get; set; }
        public Nullable<int> fgt_number_pickup { get; set; }
        public Nullable<int> fgt_number_drop { get; set; }
        public string PickupLocationId { get; set; }
        public string DeliveryLocationId { get; set; }
        public Nullable<int> ord_hdrnumber { get; set; }
    }
}