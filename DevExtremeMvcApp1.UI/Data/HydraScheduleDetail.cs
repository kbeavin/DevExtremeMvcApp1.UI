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
    
    public partial class HydraScheduleDetail
    {
        public int ID { get; set; }
        public string Job_Name { get; set; }
        public System.DateTime Job_SchTime { get; set; }
        public string Job_SchDay { get; set; }
        public Nullable<int> Job_SchMonth { get; set; }
        public string Job_Occurance { get; set; }
    
        public virtual HydraJob HydraJob { get; set; }
    }
}
