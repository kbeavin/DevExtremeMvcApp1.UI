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
    
    public partial class tblLatLong
    {
        public int SN { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<System.DateTime> DateAndTime { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Long { get; set; }
        public string Remark { get; set; }
        public bool UpdatePS { get; set; }
        public Nullable<int> Quality { get; set; }
        public Nullable<int> Landmark { get; set; }
        public Nullable<float> Miles { get; set; }
        public string Direction { get; set; }
        public byte[] ts { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string NearestLargeCityName { get; set; }
        public string NearestLargeCityState { get; set; }
        public string NearestLargeCityZip { get; set; }
        public string NearestLargeCityDirection { get; set; }
        public Nullable<int> NearestLargeCityMiles { get; set; }
        public string VehicleIgnition { get; set; }
        public Nullable<int> UpdateDisp { get; set; }
        public Nullable<int> Odometer { get; set; }
        public Nullable<int> TripStatus { get; set; }
        public Nullable<int> odometer2 { get; set; }
        public Nullable<int> speed { get; set; }
        public Nullable<int> speed2 { get; set; }
        public Nullable<double> heading { get; set; }
        public Nullable<int> gps_type { get; set; }
        public Nullable<double> gps_miles { get; set; }
        public Nullable<double> fuel_meter { get; set; }
        public Nullable<int> idle_meter { get; set; }
        public Nullable<int> AssociatedMsgSN { get; set; }
        public string ExtraData01 { get; set; }
        public string ExtraData02 { get; set; }
        public string ExtraData03 { get; set; }
        public string ExtraData04 { get; set; }
        public string ExtraData05 { get; set; }
        public string ExtraData06 { get; set; }
        public string ExtraData07 { get; set; }
        public string ExtraData08 { get; set; }
        public string ExtraData09 { get; set; }
        public string ExtraData10 { get; set; }
        public string ExtraData11 { get; set; }
        public string ExtraData12 { get; set; }
        public string ExtraData13 { get; set; }
        public string ExtraData14 { get; set; }
        public string ExtraData15 { get; set; }
        public string ExtraData16 { get; set; }
        public string ExtraData17 { get; set; }
        public string ExtraData18 { get; set; }
        public string ExtraData19 { get; set; }
        public string ExtraData20 { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string StatusReason { get; set; }
        public Nullable<int> CheckCallNumber { get; set; }
    
        public virtual tblCabUnit tblCabUnit { get; set; }
        public virtual tblLandmark tblLandmark { get; set; }
    }
}
