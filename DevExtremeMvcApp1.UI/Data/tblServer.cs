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
    
    public partial class tblServer
    {
        public int SN { get; set; }
        public string ServerCode { get; set; }
        public Nullable<int> InBox { get; set; }
        public Nullable<int> OutBox { get; set; }
        public Nullable<int> Sent { get; set; }
        public Nullable<int> Deleted { get; set; }
        public Nullable<System.DateTime> LastPoll { get; set; }
        public Nullable<System.DateTime> PollRate { get; set; }
        public Nullable<int> Working { get; set; }
        public Nullable<int> Flags { get; set; }
        public Nullable<System.DateTime> ResetRequest { get; set; }
        public Nullable<System.DateTime> Reset { get; set; }
        public string Data { get; set; }
        public string Data2 { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}