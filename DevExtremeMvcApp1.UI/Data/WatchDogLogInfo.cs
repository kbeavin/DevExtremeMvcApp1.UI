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
    
    public partial class WatchDogLogInfo
    {
        public int sn { get; set; }
        public Nullable<System.DateTime> dateandtime { get; set; }
        public string Event { get; set; }
        public string MachineName { get; set; }
        public string WatchName { get; set; }
        public string Fired_YN { get; set; }
        public string Results_YN { get; set; }
        public string ErrorOnRun_YN { get; set; }
        public string ErrorOnEmail_YN { get; set; }
        public string ErrorDescription { get; set; }
        public Nullable<decimal> RunDuration { get; set; }
        public string MoreInfo { get; set; }
    }
}
