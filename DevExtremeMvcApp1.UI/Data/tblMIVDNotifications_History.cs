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
    
    public partial class tblMIVDNotifications_History
    {
        public long NotificationHistoryID { get; set; }
        public int NotificationID { get; set; }
        public int lgh_Number { get; set; }
        public string DriverID { get; set; }
        public Nullable<int> last_checkcall_processed { get; set; }
        public Nullable<double> last_airmiles_calculated { get; set; }
        public Nullable<int> MsgSent_counter { get; set; }
        public Nullable<System.DateTime> NotificationSent_TimeStamp { get; set; }
        public Nullable<System.DateTime> Resolution_TimeStamp { get; set; }
    }
}
