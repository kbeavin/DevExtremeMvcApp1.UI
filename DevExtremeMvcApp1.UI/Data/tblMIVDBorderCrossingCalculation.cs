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
    
    public partial class tblMIVDBorderCrossingCalculation
    {
        public int lgh_Number { get; set; }
        public string DriverID { get; set; }
        public int ckc_number { get; set; }
        public Nullable<double> last_airmiles_calculated { get; set; }
        public int ckc_latseconds { get; set; }
        public int ckc_longseconds { get; set; }
        public Nullable<int> border_stop_latseconds { get; set; }
        public Nullable<int> border_stop_longseconds { get; set; }
        public System.DateTime ckc_updatedon { get; set; }
        public System.DateTime updatedon { get; set; }
        public string CompletedDelayAfterActualizedLastStop_BeforeMeatInspection { get; set; }
    }
}
