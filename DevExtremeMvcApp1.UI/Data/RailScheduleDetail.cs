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
    
    public partial class RailScheduleDetail
    {
        public int ID { get; set; }
        public int RailScheduleID { get; set; }
        public int OriginDay { get; set; }
        public System.DateTime OriginTime { get; set; }
        public string OriginService { get; set; }
        public int DestinationDay { get; set; }
        public System.DateTime DestinationTime { get; set; }
        public string DestinationService { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> rsd_transitdays { get; set; }
    
        public virtual RailSchedule RailSchedule { get; set; }
    }
}
