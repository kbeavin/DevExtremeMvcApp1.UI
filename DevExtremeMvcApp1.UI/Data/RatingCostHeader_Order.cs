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
    
    public partial class RatingCostHeader_Order
    {
        public int ID { get; set; }
        public int CostHeaderID { get; set; }
        public int ord_hdrnumber { get; set; }
        public int HeaderType { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual RatingCostHeader RatingCostHeader { get; set; }
    }
}
