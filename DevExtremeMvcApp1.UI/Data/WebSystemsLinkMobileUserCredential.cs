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
    
    public partial class WebSystemsLinkMobileUserCredential
    {
        public int MobileUserId { get; set; }
        public string UserName { get; set; }
        public bool HasMobileAccess { get; set; }
        public bool HasPay { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string TtsUserId { get; set; }
        public Nullable<decimal> MaxPerDay { get; set; }
        public Nullable<decimal> MaxPerTransaction { get; set; }
        public Nullable<decimal> MaxPercentOfTrip { get; set; }
        public Nullable<decimal> MaxPerTrip { get; set; }
    }
}
