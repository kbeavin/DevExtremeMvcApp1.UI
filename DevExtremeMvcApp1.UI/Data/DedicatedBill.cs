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
    
    public partial class DedicatedBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DedicatedBill()
        {
            this.DedicatedDetails = new HashSet<DedicatedDetail>();
            this.DedicatedInvoices = new HashSet<DedicatedInvoice>();
            this.DedicatedOrders = new HashSet<DedicatedOrder>();
            this.DedicatedRateAllocations = new HashSet<DedicatedRateAllocation>();
            this.DedicatedRevenueAllocations = new HashSet<DedicatedRevenueAllocation>();
            this.DedicatedTransactions = new HashSet<DedicatedTransaction>();
            this.DedicatedTransactions1 = new HashSet<DedicatedTransaction>();
        }
    
        public int DedicatedBillId { get; set; }
        public int DedicatedMasterId { get; set; }
        public int DedicatedStatusId { get; set; }
        public System.DateTime BillDate { get; set; }
        public int DedicatedTypeId { get; set; }
        public Nullable<int> DedicatedBillOutputRestrictionId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    
        public virtual DedicatedBillOutputRestriction DedicatedBillOutputRestriction { get; set; }
        public virtual DedicatedMaster DedicatedMaster { get; set; }
        public virtual DedicatedStatu DedicatedStatu { get; set; }
        public virtual DedicatedType DedicatedType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedDetail> DedicatedDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedInvoice> DedicatedInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedOrder> DedicatedOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedRateAllocation> DedicatedRateAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedRevenueAllocation> DedicatedRevenueAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedTransaction> DedicatedTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DedicatedTransaction> DedicatedTransactions1 { get; set; }
    }
}
