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
    
    public partial class driverseatinglog
    {
        public int dsl_id { get; set; }
        public int ds_id { get; set; }
        public string dsl_trc_id { get; set; }
        public string dsl_driver1_old { get; set; }
        public string dsl_driver1_new { get; set; }
        public string dsl_driver2_old { get; set; }
        public string dsl_driver2_new { get; set; }
        public string dsl_driver3_old { get; set; }
        public string dsl_driver3_new { get; set; }
        public Nullable<System.DateTime> dsl_seated_dt_old { get; set; }
        public Nullable<System.DateTime> dsl_seated_dt_new { get; set; }
        public Nullable<System.DateTime> dsl_unseated_dt_old { get; set; }
        public Nullable<System.DateTime> dsl_unseated_dt_new { get; set; }
        public System.DateTime dsl_updateddt { get; set; }
        public string dsl_updatedby { get; set; }
        public string dsl_comment { get; set; }
    }
}