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
    
    public partial class CarterDG
    {
        public Nullable<int> OrderHdrNumber { get; set; }
        public string OrderNumber { get; set; }
        public string RouteNumber { get; set; }
        public string RouteName { get; set; }
        public Nullable<System.DateTime> OrderStartDate { get; set; }
        public Nullable<System.DateTime> OrderCompletionDate { get; set; }
        public string RevDivn { get; set; }
        public string LoadType { get; set; }
        public string Mode { get; set; }
        public string CTID_BusDivn { get; set; }
        public int StopOrderHdrNumber { get; set; }
        public Nullable<int> StopMoveNumber { get; set; }
        public Nullable<int> StopTripNumber { get; set; }
        public int StopNumber { get; set; }
        public string StopEvent { get; set; }
        public string TrailerNumber { get; set; }
        public string StopCompanyID { get; set; }
        public string StopCompanyName { get; set; }
        public string StopCompanyAddress1 { get; set; }
        public string StopCompanyAddress2 { get; set; }
        public string StopCompanyCity { get; set; }
        public string StopCompanyState { get; set; }
        public string StopCompanyZip { get; set; }
        public Nullable<System.DateTime> StopArriveDate { get; set; }
        public Nullable<System.DateTime> StopDepartureDate { get; set; }
        public Nullable<int> TripSequence { get; set; }
        public Nullable<int> StopSequence { get; set; }
        public Nullable<int> BOLID { get; set; }
        public string ShipperID { get; set; }
        public string ShipperName { get; set; }
        public string ShipperAddress1 { get; set; }
        public string ShipperAddress2 { get; set; }
        public string ShipperCity { get; set; }
        public string ShipperState { get; set; }
        public string ShipperZip { get; set; }
        public string ConsigneeID { get; set; }
        public string ConsigneeName { get; set; }
        public string ConsigneeAddress1 { get; set; }
        public string ConsigneeAddress2 { get; set; }
        public string ConsigneeCity { get; set; }
        public string ConsigneeState { get; set; }
        public string ConsigneeZip { get; set; }
        public string BOL { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<decimal> Pieces { get; set; }
        public Nullable<decimal> Lifts { get; set; }
        public string LegOrigin { get; set; }
        public string LegDest { get; set; }
        public string BOLStatus { get; set; }
        public string BOLStage { get; set; }
        public string Driver1 { get; set; }
        public string Driver1Name { get; set; }
        public string Driver2 { get; set; }
        public string Driver2Name { get; set; }
        public string Carrier { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string InvoiceNumber { get; set; }
        public int InvoiceHdrNumber { get; set; }
        public string InvoiceStatus { get; set; }
        public string Terms { get; set; }
        public string BillTo { get; set; }
        public string BillToName { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BilltoZip { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string Payee { get; set; }
        public Nullable<decimal> RawCharge { get; set; }
        public Nullable<decimal> AmountDue { get; set; }
        public Nullable<decimal> FSUR { get; set; }
        public Nullable<decimal> MinCharge { get; set; }
        public Nullable<decimal> OOR { get; set; }
        public Nullable<decimal> CBAdjust { get; set; }
        public Nullable<decimal> FixedCost { get; set; }
        public Nullable<decimal> FixedCWT { get; set; }
        public Nullable<decimal> ContractRate { get; set; }
        public Nullable<decimal> MinCWT { get; set; }
        public Nullable<decimal> MaxCWT { get; set; }
        public Nullable<decimal> DetailMinCharge { get; set; }
        public Nullable<decimal> DetailMaxCharge { get; set; }
        public string FSCExempt { get; set; }
        public string CalcFSC { get; set; }
        public string RateFSCBy { get; set; }
        public string InvoiceBy { get; set; }
        public string CBFlag { get; set; }
        public Nullable<decimal> CBPercent { get; set; }
        public int FreightNumber { get; set; }
        public string OrderInvStatus { get; set; }
        public string SalesPersonID { get; set; }
        public string LTLPro { get; set; }
    }
}