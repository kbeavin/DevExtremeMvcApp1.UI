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
    
    public partial class Workflow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workflow()
        {
            this.Workflow_QueueData = new HashSet<Workflow_QueueData>();
            this.WorkFlow_Data = new HashSet<WorkFlow_Data>();
        }
    
        public int WorkFlow_ID { get; set; }
        public Nullable<int> Workflow_Template_ID { get; set; }
        public Nullable<System.DateTime> Workflow_Start_Time { get; set; }
        public Nullable<System.DateTime> Workflow_End_Time { get; set; }
        public int WorkFlow_Current_Sequence_ID { get; set; }
        public Nullable<System.DateTime> WorkFlow_NextProcessTime { get; set; }
        public string Workflow_OutCome { get; set; }
        public string Workflow_StartValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workflow_QueueData> Workflow_QueueData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkFlow_Data> WorkFlow_Data { get; set; }
    }
}
