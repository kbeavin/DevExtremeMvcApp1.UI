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
    
    public partial class MetricQueuedReport
    {
        public int sn { get; set; }
        public Nullable<int> UserSN { get; set; }
        public string Status { get; set; }
        public string Report_GUID { get; set; }
        public Nullable<System.DateTime> dtCreate { get; set; }
        public Nullable<System.DateTime> dtReady { get; set; }
        public Nullable<System.DateTime> dtRead { get; set; }
        public string MachineName { get; set; }
        public string Path { get; set; }
        public Nullable<System.DateTime> dtStarted { get; set; }
        public Nullable<double> RunDuration { get; set; }
        public string SQL { get; set; }
    }
}