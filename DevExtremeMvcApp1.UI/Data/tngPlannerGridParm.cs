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
    
    public partial class tngPlannerGridParm
    {
        public int grid_id { get; set; }
        public string parm_name { get; set; }
        public int parm_sequence { get; set; }
        public string parm_datatype { get; set; }
        public string parm_edit_type { get; set; }
        public string parm_edit_type2 { get; set; }
        public string parm_value { get; set; }
    
        public virtual tngPlannerGrid tngPlannerGrid { get; set; }
    }
}
