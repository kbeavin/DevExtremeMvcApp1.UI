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
    
    public partial class tblTMApplicationLog
    {
        public int SN { get; set; }
        public Nullable<int> MCSN { get; set; }
        public string MCInstance { get; set; }
        public string PollerInstance { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public string AssemblyName { get; set; }
        public string ModuleName { get; set; }
        public string MethodName { get; set; }
        public string StepDescription { get; set; }
        public string Message { get; set; }
        public Nullable<int> SessionID { get; set; }
    }
}
