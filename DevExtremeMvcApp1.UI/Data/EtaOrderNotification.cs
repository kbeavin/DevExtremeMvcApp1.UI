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
    
    public partial class EtaOrderNotification
    {
        public int EtaOrderNotificationID { get; set; }
        public string UserID { get; set; }
        public int OrderNumber { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Exception { get; set; }
        public Nullable<bool> Delivery { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}