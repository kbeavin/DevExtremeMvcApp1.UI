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
    
    public partial class SettlementAssetRestriction
    {
        public int SettlementAssetRestrictionId { get; set; }
        public string AssetType { get; set; }
        public string AssetId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int SettlementOutputRestrictionId { get; set; }
    
        public virtual SettlementOutputRestriction SettlementOutputRestriction { get; set; }
    }
}
