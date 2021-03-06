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
    
    public partial class PowerState
    {
        public int PowerStateID { get; set; }
        public string CompanyId { get; set; }
        public string PowerId { get; set; }
        public string LoadId { get; set; }
        public Nullable<int> PlanId { get; set; }
        public Nullable<System.DateTime> BreakEnd { get; set; }
        public string BreakEndText { get; set; }
        public string Capacity { get; set; }
        public Nullable<decimal> Delay { get; set; }
        public string DelayStopSequence { get; set; }
        public Nullable<System.DateTime> DispatchPta { get; set; }
        public string DispatchPtaCity { get; set; }
        public string DispatchPtaPostal { get; set; }
        public string DispatchPtaState { get; set; }
        public string DispatchPtaText { get; set; }
        public string Division { get; set; }
        public Nullable<decimal> DriveHoursLeft { get; set; }
        public string Driver1 { get; set; }
        public string Driver1HomeCity { get; set; }
        public Nullable<System.DateTime> Driver1HomeDate { get; set; }
        public string Driver1HomeDateText { get; set; }
        public string Driver1HomePostal { get; set; }
        public string Driver1HomeState { get; set; }
        public string Driver2 { get; set; }
        public string Driver2HomeCity { get; set; }
        public Nullable<System.DateTime> Driver2HomeDate { get; set; }
        public string Driver2HomeDateText { get; set; }
        public string Driver2HomePostal { get; set; }
        public string Driver2HomeState { get; set; }
        public Nullable<decimal> DutyHoursLeft { get; set; }
        public Nullable<decimal> DutyHoursLeftWeek { get; set; }
        public Nullable<decimal> DutySpan { get; set; }
        public Nullable<System.DateTime> EstimatedPta { get; set; }
        public string EstimatedPtaCity { get; set; }
        public string EstimatedPtaCountry { get; set; }
        public string EstimatedPtaPeriod { get; set; }
        public string EstimatedPtaPostal { get; set; }
        public string EstimatedPtaState { get; set; }
        public string EstimatedPtaText { get; set; }
        public string HosSource { get; set; }
        public Nullable<decimal> HoursAvailable { get; set; }
        public Nullable<decimal> HoursAvailable11 { get; set; }
        public Nullable<decimal> HoursAvailable14 { get; set; }
        public Nullable<decimal> HoursAvailable70 { get; set; }
        public Nullable<decimal> HoursBreak { get; set; }
        public Nullable<decimal> HoursDriven { get; set; }
        public Nullable<decimal> HoursLate { get; set; }
        public Nullable<decimal> HoursLatePta { get; set; }
        public Nullable<decimal> HoursOff { get; set; }
        public Nullable<decimal> HoursRested { get; set; }
        public Nullable<decimal> HoursSinceBreak { get; set; }
        public Nullable<decimal> HoursSincePta { get; set; }
        public Nullable<decimal> HoursStale { get; set; }
        public Nullable<decimal> HoursWorked { get; set; }
        public string LateStopId { get; set; }
        public string LateStopSequence { get; set; }
        public Nullable<decimal> MilesHome1 { get; set; }
        public Nullable<decimal> MilesHome2 { get; set; }
        public Nullable<decimal> MilesOffPta { get; set; }
        public Nullable<decimal> MilesSinceBreak { get; set; }
        public string NextLoad { get; set; }
        public string NextOrder { get; set; }
        public string OrderId { get; set; }
        public Nullable<System.DateTime> Ping { get; set; }
        public string PingText { get; set; }
        public Nullable<int> PrePlans { get; set; }
        public Nullable<System.DateTime> RestBegin { get; set; }
        public string RestBeginText { get; set; }
        public Nullable<decimal> TotalDelay { get; set; }
        public string WorkStatus { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
