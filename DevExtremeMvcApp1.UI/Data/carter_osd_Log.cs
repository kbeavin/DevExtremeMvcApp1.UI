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
    
    public partial class carter_osd_Log
    {
        public Nullable<bool> osd_Log_CSRwriteup { get; set; }
        public Nullable<System.DateTime> osd_Log_Date { get; set; }
        public string osd_Log_Notes { get; set; }
        public Nullable<int> osd_Log_RptID { get; set; }
        public int LogId { get; set; }
        public string osd_Log_LogBy { get; set; }
    
        public virtual carter_osd_main carter_osd_main { get; set; }
    }
}