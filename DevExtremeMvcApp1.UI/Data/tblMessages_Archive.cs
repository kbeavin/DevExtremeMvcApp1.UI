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
    
    public partial class tblMessages_Archive
    {
        public int SN { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> FromType { get; set; }
        public Nullable<int> DeliverToType { get; set; }
        public Nullable<System.DateTime> DTSent { get; set; }
        public Nullable<System.DateTime> DTReceived { get; set; }
        public Nullable<System.DateTime> DTRead { get; set; }
        public Nullable<System.DateTime> DTAcknowledged { get; set; }
        public Nullable<System.DateTime> DTTransferred { get; set; }
        public Nullable<int> Folder { get; set; }
        public string Contents { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string DeliverTo { get; set; }
        public Nullable<int> HistDrv { get; set; }
        public Nullable<int> HistDrv2 { get; set; }
        public Nullable<int> HistTrk { get; set; }
        public byte[] ts { get; set; }
        public Nullable<int> OrigMsgSN { get; set; }
        public Nullable<int> Receipt { get; set; }
        public Nullable<int> DeliveryKey { get; set; }
        public string Position { get; set; }
        public string PositionZip { get; set; }
        public string NLCPosition { get; set; }
        public string NLCPositionZip { get; set; }
        public string VehicleIgnition { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<System.DateTime> DTPosition { get; set; }
        public Nullable<int> SpecialMsgSN { get; set; }
        public Nullable<int> ResubmitOf { get; set; }
        public Nullable<int> Odometer { get; set; }
        public Nullable<int> ReplyMsgSN { get; set; }
        public Nullable<int> ReplyMsgPage { get; set; }
        public Nullable<int> ReplyFormID { get; set; }
        public Nullable<int> ReplyPriority { get; set; }
        public Nullable<int> ToDrvSN { get; set; }
        public Nullable<int> ToTrcSN { get; set; }
        public Nullable<int> FromDrvSN { get; set; }
        public Nullable<int> FromTrcSN { get; set; }
        public Nullable<int> MaxDelayMins { get; set; }
        public Nullable<int> BaseSN { get; set; }
        public string McuId { get; set; }
        public Nullable<int> Export { get; set; }
        public Nullable<System.DateTime> ArchiveDate { get; set; }
    }
}