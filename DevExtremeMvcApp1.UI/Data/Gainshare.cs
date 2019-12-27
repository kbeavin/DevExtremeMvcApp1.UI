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
    
    public partial class Gainshare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gainshare()
        {
            this.Benchmark_Gainshare = new HashSet<Benchmark_Gainshare>();
        }
    
        public int ID { get; set; }
        public decimal Actual { get; set; }
        public decimal Savings { get; set; }
        public decimal GSRunningTotal { get; set; }
        public decimal AmountEligibleForBenchmarkSavings { get; set; }
        public decimal Charge { get; set; }
        public decimal ChargeRatio { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public Nullable<int> CampaignId { get; set; }
        public string TariffNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Benchmark_Gainshare> Benchmark_Gainshare { get; set; }
        public virtual CompanyGainShareThreshold CompanyGainShareThreshold { get; set; }
    }
}
