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
    
    public partial class Workflow_Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workflow_Types()
        {
            this.Workflow_Activity = new HashSet<Workflow_Activity>();
            this.Workflow_ClientSide_Default_Fields = new HashSet<Workflow_ClientSide_Default_Fields>();
            this.WorkFlow_Template = new HashSet<WorkFlow_Template>();
        }
    
        public string Type_ID { get; set; }
        public string Type_Definition { get; set; }
        public string Is_Template_Type { get; set; }
        public string Is_Client_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workflow_Activity> Workflow_Activity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workflow_ClientSide_Default_Fields> Workflow_ClientSide_Default_Fields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkFlow_Template> WorkFlow_Template { get; set; }
    }
}