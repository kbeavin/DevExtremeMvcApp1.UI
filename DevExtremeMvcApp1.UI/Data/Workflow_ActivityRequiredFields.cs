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
    
    public partial class Workflow_ActivityRequiredFields
    {
        public int Activity_ID { get; set; }
        public string Activity_Field_Name { get; set; }
        public string Activity_Field_type { get; set; }
    
        public virtual Workflow_Activity Workflow_Activity { get; set; }
        public virtual Workflow_Fields Workflow_Fields { get; set; }
    }
}
