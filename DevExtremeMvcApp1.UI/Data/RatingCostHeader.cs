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
    
    public partial class RatingCostHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RatingCostHeader()
        {
            this.RatingCostDetails = new HashSet<RatingCostDetail>();
            this.RatingCostHeader_Leg = new HashSet<RatingCostHeader_Leg>();
            this.RatingCostHeader_Order = new HashSet<RatingCostHeader_Order>();
            this.RatingCostHeader_OrderOnLeg = new HashSet<RatingCostHeader_OrderOnLeg>();
        }
    
        public int ID { get; set; }
        public string RatedBy { get; set; }
        public System.DateTime RatedDate { get; set; }
        public byte RatingSource { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingCostDetail> RatingCostDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingCostHeader_Leg> RatingCostHeader_Leg { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingCostHeader_Order> RatingCostHeader_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingCostHeader_OrderOnLeg> RatingCostHeader_OrderOnLeg { get; set; }
    }
}
