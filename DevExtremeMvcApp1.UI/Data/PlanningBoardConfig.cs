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
    
    public partial class PlanningBoardConfig
    {
        public int PbcId { get; set; }
        public string Description { get; set; }
        public string BoardType { get; set; }
        public string ViewName { get; set; }
        public string DriverViewName { get; set; }
        public string TractorViewName { get; set; }
        public string TrailerViewName { get; set; }
        public string CarrierViewName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateOn { get; set; }
        public Nullable<int> CriteriaFlags { get; set; }
        public Nullable<int> RelatedScreenDesignerID { get; set; }
        public string Filters { get; set; }
        public string PendingLoadViewName { get; set; }
        public string IsDefault { get; set; }
        public string ViewType { get; set; }
        public string AssetManagerViewName { get; set; }
    }
}
